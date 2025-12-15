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
using MongoDB.Driver.Core;

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
        private const decimal SeatPrice = 9.95m;
        private User? _LoggedInUser;
        private bool _suppressTextChanged = false;
        public frmPayment(User user, string FilmName)
        {
            InitializeComponent();
            _LoggedInUser = user;
            _FilmName = FilmName;
            InitializeFilmInfo();
            SetPaymentButtonState(false);

            TxtCreditcard.TextChanged += TxtCreditcard_TextChanged;
            TxtVervaldatumMM.TextChanged += TxtVervaldatumMM_TextChanged_1;
            TxtVervaldatumYY.TextChanged += TxtVervaldatumYY_TextChanged_1;
            TxtPas.TextChanged += TxtPas_TextChanged;
            Txtkaarthouder.TextChanged += Txtkaarthouder_TextChanged_1;

            TxtCreditcard.KeyPress += TxtCreditcard_KeyPress;
            TxtVervaldatumMM.KeyPress += (s, e) => NumericMaxKeyPress(s, e, 2);
            TxtVervaldatumYY.KeyPress += (s, e) => NumericMaxKeyPress(s, e, 2);
            TxtPas.KeyPress += (s, e) => NumericMaxKeyPress(s, e, 4);

            UpdatePriceDisplay();
            PaymentField_TextChanged(this, EventArgs.Empty);
        }

        public frmPayment(User user, string FilmName, IEnumerable<string> selectedSeats)
            : this(user, FilmName)
        {
            if (selectedSeats != null)
            {
                _SelectedSeats = selectedSeats.ToArray();
            }

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

            lblPriceInfo.Text = count > 0
                ? $"{count} × {SeatPrice.ToString("C", euroCulture)} = {total.ToString("C", euroCulture)}"
                : $"{SeatPrice.ToString("C", euroCulture)} per stoel";
        }

        private void PaymentField_TextChanged(object? sender, EventArgs e)
        {
            bool valid = ArePaymentFieldsValid();
            SetPaymentButtonState(valid);
        }

        private void SetPaymentButtonState(bool enabled)
        {
            if (BtnIndienen == null) return;

            BtnIndienen.Enabled = enabled;
            BtnIndienen.BackColor = enabled ? Color.DodgerBlue : Color.Gray;
            BtnIndienen.Cursor = enabled ? Cursors.Hand : Cursors.Default;
        }

        private bool ArePaymentFieldsValid()
        {
            var holder = Txtkaarthouder?.Text?.Trim() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(holder) || holder.Equals("KAARTHOUDER", StringComparison.OrdinalIgnoreCase))
                return false;

            var cardDigits = new string((TxtCreditcard?.Text ?? string.Empty).Where(char.IsDigit).ToArray());
            if (cardDigits.Length != 16) return false;

            var mmText = (TxtVervaldatumMM?.Text ?? string.Empty).Trim();
            var yyText = (TxtVervaldatumYY?.Text ?? string.Empty).Trim();

            if (!int.TryParse(mmText, out int mm) || mm < 1 || mm > 12) return false;
            if (!int.TryParse(yyText, out int yy) || yyText.Length < 2) return false;

            int fullYear = 2000 + (yy % 100);

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

            var cvvDigits = new string((TxtPas?.Text ?? string.Empty).Where(char.IsDigit).ToArray());
            if (!(cvvDigits.Length == 3 || cvvDigits.Length == 4)) return false;

            return true;
        }

        private void SanitizeDigits(TextBox tb, int maxDigits, bool formatCard = false)
        {
            if (_suppressTextChanged) return;
            _suppressTextChanged = true;

            string original = tb.Text;
            string digits = new string(original.Where(char.IsDigit).ToArray());
            if (digits.Length > maxDigits) digits = digits.Substring(0, maxDigits);

            if (formatCard)
            {
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

        private void NumericMaxKeyPress(object? sender, KeyPressEventArgs e, int maxDigits)
        {
            if (!(sender is TextBox tb)) return;

            if (char.IsControl(e.KeyChar))
                return;

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            var digits = new string(tb.Text.Where(char.IsDigit).ToArray());
            if (digits.Length >= maxDigits)
            {
                e.Handled = true;
            }
        }

        private void TxtCreditcard_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericMaxKeyPress(sender, e, 16);
        }

        private void TxtCreditcard_TextChanged(object sender, EventArgs e)
        {
            if (_suppressTextChanged) return;

            SanitizeDigits(TxtCreditcard, 16, formatCard: true);

            string digits = new string((TxtCreditcard?.Text ?? string.Empty).Where(char.IsDigit).ToArray());
            string padded = digits.PadRight(16, '0');
            LblNum1.Text = padded.Substring(0, 4);
            LblNum2.Text = padded.Substring(4, 4);
            LblNum3.Text = padded.Substring(8, 4);
            LblNum4.Text = padded.Substring(12, 4);

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

        private async Task<bool> TryReserveSeatsAsync(string filmTitle, string[] seats)
        {
            if (seats == null || seats.Length == 0) return true;

            var client = new MongoClient(passwords.Database);
            var db = client.GetDatabase("Vilm");
            var col = db.GetCollection<FilmInfo>("Films");

            var titleFilter = Builders<FilmInfo>.Filter.Eq(f => f.Title, filmTitle);

            var anyInReserved = Builders<FilmInfo>.Filter.AnyIn(f => f.ReservedSeats, seats);
            var notInReserved = Builders<FilmInfo>.Filter.Not(anyInReserved);

            var filter = Builders<FilmInfo>.Filter.And(titleFilter, notInReserved);

            var update = Builders<FilmInfo>.Update.PushEach(f => f.ReservedSeats, seats);

            try
            {
                var result = await col.FindOneAndUpdateAsync(filter, update, new FindOneAndUpdateOptions<FilmInfo>
                {
                    ReturnDocument = ReturnDocument.After
                });

                return result != null;
            }
            catch (MongoCommandException)
            {
                return false;
            }
        }

        private async void BtnIndienen_Click(object sender, EventArgs e)
        {
            var seats = _SelectedSeats ?? Array.Empty<string>();
            if (seats.Length == 0)
            {
                var confirm = MessageBox.Show("Je hebt geen stoelen geselecteerd. Wil je doorgaan zonder stoelen?", "Geen stoelen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.No) return;
            }

            if (!ArePaymentFieldsValid())
            {
                MessageBox.Show("Vul alle creditcardgegevens correct in voordat je betaalt.", "Onvolledige gegevens", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var seatsToReserve = seats.ToArray();
            bool reserved = await TryReserveSeatsAsync(_FilmName, seatsToReserve);
            if (!reserved)
            {
                MessageBox.Show("Sommige van de geselecteerde stoelen zijn inmiddels door iemand anders gereserveerd. Vernieuw de stoelpagina en probeer opnieuw.", "Stoelen niet beschikbaar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string OurMailAddress = "vilmkomm@gmail.com";
                string FilmName = lblFilmInfo.Text;
                string RoomInfo = lblRoomInfo.Text;
                string SeatInfo = seatsToReserve.Length > 0 ? string.Join(", ", seatsToReserve) : "Geen stoelen geselecteerd";
                decimal totalAmount = SeatPrice * seatsToReserve.Length;
                var euroCulture = new CultureInfo("nl-NL");
                string PriceInfo = totalAmount.ToString("C", euroCulture);

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
                    SmtpClient.Credentials = new NetworkCredential(OurMailAddress, passwords.GoogleAppPassword);
                    SmtpClient.EnableSsl = true;
                    SmtpClient.Send(mailMessage);
                }

                if (lblPriceInfo != null)
                {
                    lblPriceInfo.Text = $"Bon:\nFilm: {FilmName}\nZaal: {RoomInfo}\nStoelen: {SeatInfo}\nTotaal: {PriceInfo}";
                }

                MessageBox.Show($"Mail is verstuurd naar {_LoggedInUser?.Email}, reservering voor {FilmName} in zaal {RoomInfo}, stoelen: {SeatInfo}. Betaald: {PriceInfo}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Mail kon niet worden verstuurd, want: \n {ex.Message}");
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