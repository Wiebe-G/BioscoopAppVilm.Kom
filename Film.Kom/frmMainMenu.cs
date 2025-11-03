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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
            User user = new User();
            if (string.IsNullOrWhiteSpace(user.Naam))
            {
                btnLogin.Text = "Inloggen";
                lblUsername.Text = "Gast";
            }
            else
            {
                btnLogin.Text = user.Naam;
                lblUsername.Text = user.Naam;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
        }

        private void Search_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Werkt nog niet");
        }
    }
}
