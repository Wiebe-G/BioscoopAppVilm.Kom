using MongoDB.Driver;
using BC = BCrypt.Net.BCrypt;

namespace Film.Kom
{
    public partial class frmLogin : Form
    {
        // Design door Avsar, functionaliteit door Wiebe
        readonly Passwords passwords = new();
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
            string username = txtUsername.Text.Trim();
            string PlainPassword = txtPassword.Text.Trim();

            var user = _Users.Find(g => g.Naam == username).FirstOrDefault();
            if (user == null) return false;
            return BC.Verify(PlainPassword, user.HashedPassword);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isLoginSucces = Login();
            if (isLoginSucces)
            {
                User user = new()
                {
                    Naam = txtUsername.Text.Trim()
                };
                // ingelogd YIPPE
                MessageBox.Show($"Welkom, {user.Naam}");
                this.Hide();
                frmMainMenu MainForm = new(user);
                MainForm.Show();
            }
            else
            {
                MessageBox.Show("Oh oh, iets niet goed gegaan met inloggen");
                txtUsername.Clear();
                txtPassword.Clear();
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
            frmRegister RegisterForm = new();
            RegisterForm.Show();
            this.Hide();
        }
    }
}