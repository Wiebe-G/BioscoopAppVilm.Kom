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
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film.Kom
{
    public partial class frmPayment : Form
    {
        readonly Passwords passwords = new Passwords();
        private readonly IMongoCollection<User>? _Users;

        private User? _LoggedInUser;
        public frmPayment(User user)
        {
            InitializeComponent();
            _LoggedInUser = user;
            lblFilmInfo.Text = _LoggedInUser.Naam;
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
                _LoggedInUser.Email = await FetchUserEmail(_LoggedInUser.Naam);
            }
        }

        private async Task<string> FetchUserEmail(string Naam)
        {
            var client = new MongoClient(passwords.Database);
            var db = client.GetDatabase("Vilm");
            var collection = db.GetCollection<User>("Users");

            var filter = Builders<User>.Filter.Eq(u => u.Naam, Naam);

            var user = await collection.Find(filter).FirstOrDefaultAsync();

            return user?.Email;
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            foreach (var item in TBLpayment.Controls.OfType<PictureBox>()) item.BackColor = Color.Transparent;
            PictureBox picture = (PictureBox)sender;
            picture.BackColor = Color.PaleGreen;
            PicMastercard.Image = picture.Image;
        }

        private void TxtCreditcard_TextChanged(object sender, EventArgs e)
        {
            string text = TxtCreditcard.Text.Replace(" ", ""); // spaties weghalen
            if (text == "CREDIT-NUMMER")
                return;

            // Maak altijd 16 tekens door nullen toe te voegen aan het eind
            text = text.PadRight(16, '0');

            // Verdeel het in groepen van 4
            LblNum1.Text = text.Substring(0, 4);
            LblNum2.Text = text.Substring(4, 4);
            LblNum3.Text = text.Substring(8, 4);
            LblNum4.Text = text.Substring(12, 4);
        }

        private void TxtCreditcard_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar >= '0' && e.KeyChar <= '9' || (e.KeyChar == (char)Keys.Back)) ? false : true;
        }

        private void Txtkaarthouder_TextChanged_1(object sender, EventArgs e)
        {
            Lblhouder.Text = (Txtkaarthouder.Text == "" | Txtkaarthouder.Text == "KAARTHOUDER") ? "Naam" : Txtkaarthouder.Text;
        }

        private void TxtVervaldatumMM_TextChanged_1(object sender, EventArgs e)
        {
            LblVervaldatumMM.Text = (TxtVervaldatumMM.Text == "" | TxtVervaldatumMM.Text == "VERVALDATUM MM") ? "00" : TxtVervaldatumMM.Text;
        }

        private void TxtVervaldatumYY_TextChanged_1(object sender, EventArgs e)
        {
            LblVervaldatumYY.Text = (TxtVervaldatumYY.Text == "" | TxtVervaldatumYY.Text == "VERVALDATUM YY") ? "00" : TxtVervaldatumYY.Text;
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
                MessageBox.Show("Niet ingelogd", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            string OurMailAddress = "vilmkomm@gmail.com";
            string FilmName = lblFilmInfo.Text;
            string RoomInfo = lblRoomInfo.Text;
            string SeatInfo = lblSeatInfo.Text;
            string PriceInfo = lblPriceInfo.Text;
            //mail en naam van user valideren
            bool ValidCredentials = CheckValidityOfUserCredentials();
            if (!ValidCredentials)
            {
                MessageBox.Show("Informatie kon niet worden gevalideerd. Probeer opnieuw.");
                return;
            }
            try
            {
                string QRCodeValue = $"Naam: {_LoggedInUser.Naam}. \n Film: {FilmName} \n Zaal: {RoomInfo} " +
                    $"\n Stoelen: {SeatInfo} \n Prijs: {PriceInfo}. (prijs, bijv. stoelen*9.95)";
                var qrCodeImage = MakeQRCode(QRCodeValue);

                MailMessage mailMessage = CreateMailMessage(OurMailAddress, qrCodeImage);

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
                MessageBox.Show($"Mail is verstuurd naar {_LoggedInUser.Email}, " +
                    $"reservering voor {FilmName} in zaal {RoomInfo}, met stoelen {SeatInfo}.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Mail kon niet worden verstuurd, want: \n {ex.Message} \n Stacktrace: \n {ex.StackTrace}. \n Innerexception: \n {ex.InnerException}");
            }
        }

        private MailMessage CreateMailMessage(string OurMailAddress, object qrCodeImage)
        {
            var mailMessage = new MailMessage
            {
                From = new MailAddress(OurMailAddress, "Film.Kom"),
                Subject = "Reservering voor Film.Kom (TEST MAIL)",
                Body = $"{qrCodeImage}",
                IsBodyHtml = true,
            };
            mailMessage.To.Add(
                new MailAddress(
                    _LoggedInUser.Email ?? "test@test.nl",
                    _LoggedInUser.Naam ?? "Test"));
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
