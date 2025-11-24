using MongoDB.Driver;
using BC = BCrypt.Net.BCrypt;

namespace Film.Kom
{

    public partial class frmLogin : Form
    {
        Passwords passwords = new Passwords();
        private readonly IMongoCollection<User> _Users;
        public frmLogin()
        {
            InitializeComponent();
            var client = new MongoClient(passwords.Database);
            var db = client.GetDatabase("Vilm");
            _Users = db.GetCollection<User>("Users");
        }

        public bool Login()
        {
            string username = txtUsername.Text;
            string PlainPassword = txtPassword.Text;

            var user = _Users.Find(g => g.Naam == username).FirstOrDefault();
            if (user == null) { return false; }
            return BC.Verify(PlainPassword, user.HashedPassword);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isLoginSucces = Login();
            if (isLoginSucces)
            {
                User user = new User();
                user.Naam = txtUsername.Text.Trim();
                // ingelogd YIPPE
                MessageBox.Show($"Welkom, {txtUsername.Text}");
                this.Hide();
                frmMainMenu MainForm = new frmMainMenu(user);
                MainForm.Show();
            }
            else
            {
                MessageBox.Show("Oh oh, iets niet goed gegaan met inloggen");
            }
        }

        private void LoginEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnLogin.PerformClick();
            }
        }

        private void btnMakeAccount_Click(object sender, EventArgs e)
        {
            frmRegister RegisterForm = new frmRegister();
            RegisterForm.Show();
            this.Hide();
        }
    }
}