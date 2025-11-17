using Film.Kom;
using MongoDB.Bson;
using MongoDB.Driver;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private readonly IMongoCollection<User>? _Users;

        private User? _LoggedInUser;
        public frmPayment()
        {
            InitializeComponent();
            MessageBox.Show("Test");
            //_LoggedInUser = null;
        }

        private async void frmPayment_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Test 2");
            _LoggedInUser.Email = await FetchUserEmail(_LoggedInUser.Naam);
        }

        private async Task<string> FetchUserEmail(string Naam)
        {
            var client = new MongoClient("mongodb+srv://rickgeerdink2020_db_user:HWTyu7e8IBTBWhTT@cluster0.bi1idnh.mongodb.net/");
            var db = client.GetDatabase("Vilm");
            var collection = db.GetCollection<User>("Users");

            var filter = Builders<User>.Filter.Eq(u => u.Naam, Naam);

            var user = await collection.Find(filter).FirstOrDefaultAsync();

            return user?.Email;
        }

        public frmPayment(User user)
        {
            InitializeComponent();
            _LoggedInUser = user;
            lblFilmInfo.Text = _LoggedInUser.Naam;

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
            //if (TxtCreditcard.Text != "CREDIT-NUMMER")
            //{
            //    switch (TxtCreditcard.Text.Count())
            //    {
            //        case 0: LblNum1.Text = LblNum2.Text = LblNum3.Text = LblNum4.Text = "0000"; break;
            //        case 1: LblNum1.Text = int.Parse(TxtCreditcard.Text.Substring(0, 1)).ToString("0000"); break;
            //        case 2: LblNum1.Text = int.Parse(TxtCreditcard.Text.Substring(0, 2)).ToString("0000"); break;
            //        case 3: LblNum1.Text = int.Parse(TxtCreditcard.Text.Substring(0, 3)).ToString("0000"); break;
            //        case 4: LblNum1.Text = int.Parse(TxtCreditcard.Text.Substring(0, 4)).ToString("0000"); LblNum2.Text = "0000"; break;
            //        case 5: LblNum2.Text = int.Parse(TxtCreditcard.Text.Substring(4, 1)).ToString("0000"); break;
            //        case 6: LblNum2.Text = int.Parse(TxtCreditcard.Text.Substring(4, 2)).ToString("0000"); break;
            //        case 7: LblNum2.Text = int.Parse(TxtCreditcard.Text.Substring(4, 3)).ToString("0000"); break;
            //        case 8: LblNum2.Text = int.Parse(TxtCreditcard.Text.Substring(4, 4)).ToString("0000"); LblNum3.Text = "0000"; break;
            //        case 9: LblNum3.Text = int.Parse(TxtCreditcard.Text.Substring(8, 1)).ToString("0000"); break;
            //        case 10: LblNum3.Text = int.Parse(TxtCreditcard.Text.Substring(8, 2)).ToString("0000"); break;
            //        case 11: LblNum3.Text = int.Parse(TxtCreditcard.Text.Substring(8, 3)).ToString("0000"); break;
            //        case 12: LblNum3.Text = int.Parse(TxtCreditcard.Text.Substring(8, 4)).ToString("0000"); LblNum4.Text = "0000"; break;
            //        case 13: LblNum4.Text = int.Parse(TxtCreditcard.Text.Substring(12, 1)).ToString("0000"); break;
            //        case 14: LblNum4.Text = int.Parse(TxtCreditcard.Text.Substring(12, 2)).ToString("0000"); break;
            //        case 15: LblNum4.Text = int.Parse(TxtCreditcard.Text.Substring(12, 3)).ToString("0000"); break;
            //        case 16: LblNum4.Text = int.Parse(TxtCreditcard.Text.Substring(12, 4)).ToString("0000"); break;
            //    }
            //}
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


        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void BtnIndienen_MouseDown_1(object sender, MouseEventArgs e)
        //{
        //    BtnIndienen.ForeColor = Color.White;
        //}

        //private void BtnIndienen_MouseLeave_1(object sender, EventArgs e)
        //{
        //    BtnIndienen.ForeColor = Color.White;
        //}

        //private void BtnIndienen_MouseEnter_1(object sender, EventArgs e)
        //{
        //    BtnIndienen.ForeColor = Color.Black;
        //}

        private void BtnIndienen_Click(object sender, EventArgs e)
        {
            // mail en naam van user pakken
            if (string.IsNullOrWhiteSpace(_LoggedInUser?.Naam))
            {
                MessageBox.Show("Niet ingelogd", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(_LoggedInUser.Email))
            {
                MessageBox.Show($"Geen geldige email voor {_LoggedInUser.Naam} :(");
                return;
            }
            var qrCodeImage = MakeQRCode();
            var mailMessage = new MailMessage
            {
                From = new MailAddress("ons@email.com", "Film.Kom"),
                Subject = "Reservering voor Film.Kom (TEST MAIL)",
                Body = $"{qrCodeImage}",
                IsBodyHtml = false
            };
            mailMessage.To.Add(
                new MailAddress(
                    _LoggedInUser.Email ?? "test@test.nl",
                    _LoggedInUser.Naam ?? "Test"));

            try
            {
                var SmtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("ons@email.com", "wachtwoord"),
                    EnableSsl = true
                };
                SmtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Mail kon niet worden verstuurd, want {ex.Message} en {ex.StackTrace}");
            }
        }

        private object MakeQRCode()
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode("", QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            return qrCodeImage;
        }


    }
}
