using Film.Kom;
using MongoDB.Bson;
using MongoDB.Driver;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film.Kom
{
    internal partial class frmPayment : Form
    {
        readonly Passwords passwords = new Passwords();
        private IMongoCollection<User>? _Users;
        private readonly string _FilmName;
        private IMongoCollection<FilmInfo>? _Filminfo;
        private string _Playtime = string.Empty;
        private string[] _SelectedSeats = Array.Empty<string>();

        // Price per seat (adjust if you want another price)
        private const decimal SeatPrice = 9.95m;

        private User? _LoggedInUser;

        // guard to avoid recursive TextChanged handling when we update Text programmatically
        private bool _suppressTextChanged = false;

        // Existing constructor kept for compatibility
        public frmPayment(User user, string FilmName)
        {
            InitializeComponent();
            _LoggedInUser = user;
            _FilmName = FilmName;
            InitializeFilmInfo();

            // Ensure payment button starts disabled until validation passes
            SetPaymentButtonState(false);

            // Subscribe to relevant input changes so we can validate in realtime
            TxtCreditcard.TextChanged += TxtCreditcard_TextChanged;
            TxtVervaldatumMM.TextChanged += TxtVervaldatumMM_TextChanged_1;
            TxtVervaldatumYY.TextChanged += TxtVervaldatumYY_TextChanged_1;
            TxtPas.TextChanged += TxtPas_TextChanged;
            Txtkaarthouder.TextChanged += Txtkaarthouder_TextChanged_1;

            // KeyPress handlers to restrict typing (digits only + max length)
            TxtCreditcard.KeyPress += TxtCreditcard_KeyPress;
            TxtVervaldatumMM.KeyPress += (s, e) => NumericMaxKeyPress(s, e, 2);
            TxtVervaldatumYY.KeyPress += (s, e) => NumericMaxKeyPress(s, e, 2);
            TxtPas.KeyPress += (s, e) => NumericMaxKeyPress(s, e, 4);

            // initial validation in case constructor caller provided seats via overload afterwards
            UpdatePriceDisplay();
            PaymentField_TextChanged(this, EventArgs.Empty);
        }

        // New overload: receive selected seats from reservation form
        public frmPayment(User user, string FilmName, IEnumerable<string> selectedSeats)
            : this(user, FilmName)
        {
            if (selectedSeats != null)
            {
                _SelectedSeats = selectedSeats.ToArray();
            }

            // update UI immediately if controls are already created
            if (lblSeatInfo != null)
            {
                lblSeatInfo.Text = _SelectedSeats.Length > 0
                    ? string.Join(", ", _SelectedSeats)
                    : "Geen stoelen geselecteerd";
            }

            UpdatePriceDisplay();
            PaymentField_TextChanged(this, EventArgs.Empty);
        }

        private void InitializeFilmInfo()
        {
            // keep previous UI assignments, moved out of ctor to be reusable
            lblFilmInfo.Text = _FilmName ?? string.Empty;

            var client = new MongoClient(passwords.Database);
            var db = client.GetDatabase("Vilm");
            _Filminfo = db.GetCollection<FilmInfo>("Films");

            var QueryResult = _Filminfo.Find(x => x.Title.ToLower() == _FilmName.ToLower()).FirstOrDefault();
            if (QueryResult == null)
            {
                MessageBox.Show("Oh oh");
                return;
            }
            lblRoomInfo.Text = QueryResult.Zaal;
            _Playtime = QueryResult.Speeltijd ?? string.Empty;

            UpdatePriceDisplay();
        }

        private void UpdatePriceDisplay()
        {
            if (lblPriceInfo == null) return;

            var count = _SelectedSeats?.Length ?? 0;
            var total = SeatPrice * count;
            var euroCulture = new CultureInfo("nl-NL");

            // show a small receipt-like text in the placeholder price label (use euro formatting)
            lblPriceInfo.Text = count > 0
                ? $"{count} × {SeatPrice.ToString("C", euroCulture)} = {total.ToString("C", euroCulture)}"
                : $"{SeatPrice.ToString("C", euroCulture)} per stoel";
        }

        // Central handler called when payment fields change
        private void PaymentField_TextChanged(object? sender, EventArgs e)
        {
            bool valid = ArePaymentFieldsValid();
            SetPaymentButtonState(valid);
        }

        // Enable/disable visual state for the payment button
        private void SetPaymentButtonState(bool enabled)
        {
            if (BtnIndienen == null) return;

            BtnIndienen.Enabled = enabled;
            BtnIndienen.BackColor = enabled ? Color.DodgerBlue : Color.Gray;
            // Optionally change cursor
            BtnIndienen.Cursor = enabled ? Cursors.Hand : Cursors.Default;
        }

        // Validate all required payment fields (basic, client-side only)
        private bool ArePaymentFieldsValid()
        {
            // Cardholder name
            var holder = Txtkaarthouder?.Text?.Trim() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(holder) || holder.Equals("KAARTHOUDER", StringComparison.OrdinalIgnoreCase))
                return false;

            // Card number: digits only, 16 digits
            var cardDigits = new string((TxtCreditcard?.Text ?? string.Empty).Where(char.IsDigit).ToArray());
            if (cardDigits.Length != 16) return false;

            // Expiration month/year: MM and YY expected
            var mmText = (TxtVervaldatumMM?.Text ?? string.Empty).Trim();
            var yyText = (TxtVervaldatumYY?.Text ?? string.Empty).Trim();

            if (!int.TryParse(mmText, out int mm) || mm < 1 || mm > 12) return false;
            if (!int.TryParse(yyText, out int yy) || yyText.Length < 2) return false;

            // Convert two-digit year to full year (assume 2000+)
            int fullYear = 2000 + (yy % 100);

            // Card is valid if the expiration date is end of month >= today
            try
            {
                var lastDayOfMonth = DateTime.DaysInMonth(fullYear, mm);
                var expiry = new DateTime(fullYear, mm, lastDayOfMonth, 23, 59, 59);
                if (expiry < DateTime.Now) return false;
            }
            catch
            {
                return false;
            }

            // CVV / Pas nr: digits only 3 or 4
            var cvvDigits = new string((TxtPas?.Text ?? string.Empty).Where(char.IsDigit).ToArray());
            if (!(cvvDigits.Length == 3 || cvvDigits.Length == 4)) return false;

            // All checks passed
            return true;
        }

        // --- Input sanitization / formatting helpers ---

        // Sanitize digits, limit length and optionally format as creditcard groups (4-4-4-4)
        private void SanitizeDigits(TextBox tb, int maxDigits, bool formatCard = false)
        {
            if (_suppressTextChanged) return;
            _suppressTextChanged = true;

            string original = tb.Text;
            // keep only digits
            string digits = new string(original.Where(char.IsDigit).ToArray());
            if (digits.Length > maxDigits) digits = digits.Substring(0, maxDigits);

            if (formatCard)
            {
                // format into groups of 4
                var parts = Enumerable.Range(0, (digits.Length + 3) / 4)
                    .Select(i => digits.Substring(i * 4, Math.Min(4, digits.Length - i * 4)));
                string formatted = string.Join(" ", parts);
                tb.Text = formatted;
                tb.SelectionStart = tb.Text.Length;
            }
            else
            {
                tb.Text = digits;
                tb.SelectionStart = tb.Text.Length;
            }

            _suppressTextChanged = false;
        }

        // Generic KeyPress handler that restricts to digits/backspace and max digits
        private void NumericMaxKeyPress(object? sender, KeyPressEventArgs e, int maxDigits)
        {
            if (!(sender is TextBox tb)) return;

            // allow control keys (backspace, etc.)
            if (char.IsControl(e.KeyChar))
                return;

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // count existing digits
            var digits = new string(tb.Text.Where(char.IsDigit).ToArray());
            if (digits.Length >= maxDigits)
            {
                e.Handled = true;
            }
        }

        private void TxtCreditcard_KeyPress(object sender, KeyPressEventArgs e)
        {
            // special handler for creditcard (max 16 digits)
            NumericMaxKeyPress(sender, e, 16);
        }

        private void TxtCreditcard_TextChanged(object sender, EventArgs e)
        {
            if (_suppressTextChanged) return;

            // sanitize and format to groups of 4, max 16 digits
            SanitizeDigits(TxtCreditcard, 16, formatCard: true);

            // Derive labels for the display (pad with zeros as before)
            string digits = new string((TxtCreditcard?.Text ?? string.Empty).Where(char.IsDigit).ToArray());
            string padded = digits.PadRight(16, '0');
            LblNum1.Text = padded.Substring(0, 4);
            LblNum2.Text = padded.Substring(4, 4);
            LblNum3.Text = padded.Substring(8, 4);
            LblNum4.Text = padded.Substring(12, 4);

            // run validation after the credit card textbox update
            PaymentField_TextChanged(sender, e);
        }

        private void TxtVervaldatumMM_TextChanged_1(object sender, EventArgs e)
        {
            if (_suppressTextChanged) return;

            SanitizeDigits(TxtVervaldatumMM, 2);
            LblVervaldatumMM.Text = (TxtVervaldatumMM.Text == "" || TxtVervaldatumMM.Text == "VERVALDATUM MM") ? "00" : TxtVervaldatumMM.Text.PadLeft(2, '0');

            PaymentField_TextChanged(sender, e);
        }

        private void TxtVervaldatumYY_TextChanged_1(object sender, EventArgs e)
        {
            if (_suppressTextChanged) return;

            SanitizeDigits(TxtVervaldatumYY, 2);
            LblVervaldatumYY.Text = (TxtVervaldatumYY.Text == "" || TxtVervaldatumYY.Text == "VERVALDATUM YY") ? "00" : TxtVervaldatumYY.Text.PadLeft(2, '0');

            PaymentField_TextChanged(sender, e);
        }

        private void TxtPas_TextChanged(object sender, EventArgs e)
        {
            if (_suppressTextChanged) return;

            SanitizeDigits(TxtPas, 4);
            // keep centered text as before
            PaymentField_TextChanged(sender, e);
        }

        private void Txtkaarthouder_TextChanged_1(object sender, EventArgs e)
        {
            Lblhouder.Text = (Txtkaarthouder.Text == "" || Txtkaarthouder.Text == "KAARTHOUDER") ? "Naam" : Txtkaarthouder.Text;
            PaymentField_TextChanged(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private async void frmPayment_Load(object sender, EventArgs e)
        {
            if (_LoggedInUser == null || string.IsNullOrWhiteSpace(_LoggedInUser.Naam))
            {
                return;
            }
            var email = await FetchUserEmail(_LoggedInUser.Naam);
            if (!string.IsNullOrWhiteSpace(email))
            {
                _LoggedInUser.Email = email;
            }
        }

        private async Task<string> FetchUserEmail(string Naam)
        {
            var client = new MongoClient(passwords.Database);
            var db = client.GetDatabase("Vilm");
            var collection = db.GetCollection<User>("Users");

            var filter = Builders<User>.Filter.Eq(u => u.Naam, Naam);

            var user = await collection.Find(filter).FirstOrDefaultAsync();

            return user?.Email ?? string.Empty;
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            foreach (var item in TBLpayment.Controls.OfType<PictureBox>()) item.BackColor = Color.Transparent;
            PictureBox picture = (PictureBox)sender;
            picture.BackColor = Color.PaleGreen;
            PicMastercard.Image = picture.Image;
        }

        private void TBLpayment_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private bool CheckValidityOfUserCredentials()
        {
            if (string.IsNullOrWhiteSpace(_LoggedInUser?.Naam))
            {
                MessageBox.Show("Niet ingelogd", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(_LoggedInUser.Email))
            {
                MessageBox.Show($"Geen geldige email voor {_LoggedInUser.Naam} :(");
                return false;
            }
            return true;
        }

        private void BtnIndienen_Click(object sender, EventArgs e)
        {
            // Ensure seats selected
            var seats = _SelectedSeats ?? Array.Empty<string>();
            if (seats.Length == 0)
            {
                var confirm = MessageBox.Show("Je hebt geen stoelen geselecteerd. Wil je doorgaan zonder stoelen?", "Geen stoelen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.No) return;
            }

            // Double-check validation before proceeding
            if (!ArePaymentFieldsValid())
            {
                MessageBox.Show("Vul alle creditcardgegevens correct in voordat je betaalt.", "Onvolledige gegevens", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Sender email set to Wiebe
            string OurMailAddress = "Vilmkomm@gmail.com";
            string FilmName = lblFilmInfo.Text;
            string RoomInfo = lblRoomInfo.Text;
            string SeatInfo = seats.Length > 0 ? string.Join(", ", seats) : "Geen stoelen geselecteerd";
            decimal totalAmount = SeatPrice * seats.Length;
            var euroCulture = new CultureInfo("nl-NL");
            string PriceInfo = totalAmount.ToString("C", euroCulture);

            // mail en naam van user valideren
            bool ValidCredentials = CheckValidityOfUserCredentials();
            if (!ValidCredentials)
            {
                MessageBox.Show("Informatie kon niet worden gevalideerd. Probeer opnieuw.");
                return;
            }

            try
            {
                string QRCodeValue = $"Naam: {_LoggedInUser?.Naam}. \nFilm: {FilmName}\nZaal: {RoomInfo}\nStoelen: {SeatInfo}\nTotaal betaald: {PriceInfo}\nSpeelt af om: {_Playtime}";
                var qrCodeImage = MakeQRCode(QRCodeValue);

                MailMessage mailMessage = CreateMailMessage(OurMailAddress, qrCodeImage, FilmName, RoomInfo, SeatInfo, PriceInfo);

                using var ms = new MemoryStream();

                Bitmap qr = (Bitmap)qrCodeImage;
                qr.Save(ms, ImageFormat.Png);
                ms.Position = 0;

                var attachment = new Attachment(ms, "qrcode.png", "image/png");
                mailMessage.Attachments.Add(attachment);

                using (var SmtpClient = new SmtpClient("smtp.gmail.com", 587))
                {
                    SmtpClient.Port = 587;
                    // use the wiebe sender address for SMTP credentials if appropriate
                    SmtpClient.Credentials = new NetworkCredential(OurMailAddress, passwords.GoogleAppPassword);
                    SmtpClient.EnableSsl = true;
                    SmtpClient.Send(mailMessage);
                }

                // Update UI placeholder to show receipt summary
                if (lblPriceInfo != null)
                {
                    lblPriceInfo.Text = $"Bon:\nFilm: {FilmName}\nZaal: {RoomInfo}\nStoelen: {SeatInfo}\nTotaal: {PriceInfo}";
                }

                MessageBox.Show($"Mail is verstuurd naar {_LoggedInUser?.Email}, reservering voor {FilmName} in zaal {RoomInfo}, stoelen: {SeatInfo}. Betaald: {PriceInfo}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Mail kon niet worden verstuurd, want: \n {ex.Message} \n Stacktrace: \n {ex.StackTrace}. \n Innerexception: \n {ex.InnerException}");
            }
        }

        private MailMessage CreateMailMessage(string OurMailAddress, object qrCodeImage, string FilmName, string RoomInfo, string SeatInfo, string PriceInfo)
        {
            var body = new StringBuilder();
            body.AppendLine("<h2>Film.Kom - Reserveringsbon</h2>");
            body.AppendLine($"<p><strong>Naam:</strong> {_LoggedInUser?.Naam}</p>");
            body.AppendLine($"<p><strong>Film:</strong> {FilmName}</p>");
            body.AppendLine($"<p><strong>Zaal:</strong> {RoomInfo}</p>");
            body.AppendLine($"<p><strong>Stoelen:</strong> {SeatInfo}</p>");
            body.AppendLine($"<p><strong>Totaal betaald:</strong> {PriceInfo}</p>");
            body.AppendLine($"<p><strong>Speelt af om:</strong> {_Playtime}</p>");

            var mailMessage = new MailMessage
            {
                From = new MailAddress(OurMailAddress, "Vilm.Kom"),
                Subject = $"Reservering {FilmName} - {PriceInfo}",
                Body = body.ToString(),
                IsBodyHtml = true,
            };
            mailMessage.To.Add(
                new MailAddress(
                    _LoggedInUser?.Email ?? "test@test.nl",
                    _LoggedInUser?.Naam ?? "Test"));
            return mailMessage;
        }

        private object MakeQRCode(string input)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode($"{input}", QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            return qrCodeImage;
        }
    }
}