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
        private User _LoggedInUser;
        public frmMainMenu()
        {
            InitializeComponent();
            _LoggedInUser = new User();
        }

        public frmMainMenu(User user)
        {
            InitializeComponent();
            _LoggedInUser = user;
            //User user = new User();
            if (string.IsNullOrWhiteSpace(user.Naam))
            {
                btnLogin.Text = "Inloggen";
                lblUsername.Text = "Gast";
            }
            else
            {
                btnLogin.Text = "Uitloggen";
                lblUsername.Text = user.Naam;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
            this.Hide();
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

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }
    }
}
