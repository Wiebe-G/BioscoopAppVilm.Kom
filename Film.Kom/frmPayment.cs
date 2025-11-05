using Film.Kom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film.Kom
{
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
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
            if (TxtCreditcard.Text != "CREDIT-NUMMER")
            {
                switch (TxtCreditcard.Text.Count())
                {
                    case 0: LblNum1.Text = LblNum2.Text = LblNum3.Text = LblNum4.Text = "0000"; break;
                    case 1: LblNum1.Text = int.Parse(TxtCreditcard.Text.Substring(0, 1)).ToString("0000"); break;
                    case 2: LblNum1.Text = int.Parse(TxtCreditcard.Text.Substring(0, 2)).ToString("0000"); break;
                    case 3: LblNum1.Text = int.Parse(TxtCreditcard.Text.Substring(0, 3)).ToString("0000"); break;
                    case 4: LblNum1.Text = int.Parse(TxtCreditcard.Text.Substring(0, 4)).ToString("0000"); LblNum2.Text = "0000"; break;
                    case 5: LblNum2.Text = int.Parse(TxtCreditcard.Text.Substring(4, 1)).ToString("0000"); break;
                    case 6: LblNum2.Text = int.Parse(TxtCreditcard.Text.Substring(4, 2)).ToString("0000"); break;
                    case 7: LblNum2.Text = int.Parse(TxtCreditcard.Text.Substring(4, 3)).ToString("0000"); break;
                    case 8: LblNum2.Text = int.Parse(TxtCreditcard.Text.Substring(4, 4)).ToString("0000"); LblNum3.Text = "0000"; break;
                    case 9: LblNum3.Text = int.Parse(TxtCreditcard.Text.Substring(8, 1)).ToString("0000"); break;
                    case 10: LblNum3.Text = int.Parse(TxtCreditcard.Text.Substring(8, 2)).ToString("0000"); break;
                    case 11: LblNum3.Text = int.Parse(TxtCreditcard.Text.Substring(8, 3)).ToString("0000"); break;
                    case 12: LblNum3.Text = int.Parse(TxtCreditcard.Text.Substring(8, 4)).ToString("0000"); LblNum4.Text = "0000"; break;
                    case 13: LblNum4.Text = int.Parse(TxtCreditcard.Text.Substring(12, 1)).ToString("0000"); break;
                    case 14: LblNum4.Text = int.Parse(TxtCreditcard.Text.Substring(12, 2)).ToString("0000"); break;
                    case 15: LblNum4.Text = int.Parse(TxtCreditcard.Text.Substring(12, 3)).ToString("0000"); break;
                    case 16: LblNum4.Text = int.Parse(TxtCreditcard.Text.Substring(12, 4)).ToString("0000"); break;
                }
            }
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

        private void BtnIndienen_MouseDown_1(object sender, MouseEventArgs e)
        {
            BtnIndienen.ForeColor = Color.White;
        }

        private void BtnIndienen_MouseLeave_1(object sender, EventArgs e)
        {
            BtnIndienen.ForeColor = Color.White;
        }

        private void BtnIndienen_MouseEnter_1(object sender, EventArgs e)
        {
            BtnIndienen.ForeColor = Color.Black;
        }

        private void LblNum2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
