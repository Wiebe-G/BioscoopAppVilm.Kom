using MongoDB.Driver;
using System.Text.RegularExpressions;
using BC = BCrypt.Net.BCrypt;

namespace Film.Kom
{
    public partial class frmRegister : Form
    {
        // Design door Avsar (zelfde als login), functionaliteit door Wiebe
        readonly Passwords passwords = new Passwords();
        private readonly IMongoCollection<User> _Users;
        public frmRegister()
        {
            InitializeComponent();

            var client = new MongoClient(passwords.Database);
            var db = client.GetDatabase("Vilm");
            _Users = db.GetCollection<User>("Users");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string Name = txtUsername.Text.Trim();
            string Mail = txtMail.Text.Trim();
            string PlainPassword = txtPassword.Text.Trim();
            string PlainPasswordRepeat = txtPasswordRepeat.Text.Trim();

            // als een veld leeg is
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Mail) || string.IsNullOrEmpty(PlainPassword))
            {
                MessageBox.Show("Vul alle velden in.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // wachtwoorden matchen niet
            if (PlainPassword != PlainPasswordRepeat)
            {
                MessageBox.Show("Wachtwoorden komen niet overeen.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (PlainPassword.Length < 8)
            {
                MessageBox.Show("Wachtwoord niet lang genoeg");
                return;
            }


            // emal klopt niet
            if (!Mail.Contains("@"))
            {
                MessageBox.Show($"Email {Mail} is waarschijnlijk niet echt. Als dit niet klopt, neem contact met ons op");
                return;
            }

            // Check of gebruiker al bestaat
            var bestaande = _Users.Find(u => u.Naam == Name || u.Email == Mail).FirstOrDefault();
            if (bestaande != null)
            {
                MessageBox.Show("Gebruiker of e-mailadres bestaat al.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hash = BC.HashPassword(PlainPassword, workFactor: 12);

            // nieuwe instanstie van User class, en daar de data in zetten
            var NewUser = new User
            {
                Naam = Name,
                Email = Mail,
                HashedPassword = hash,
                RegisteredAt = DateTime.Now,
                Rol = 0
            };
            // data in de db
            _Users.InsertOne(NewUser);

            MessageBox.Show("Registratie succesvol!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmLogin LoginForm = new frmLogin();
            LoginForm.Show();
            this.Hide();
        }
        private void LoginEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnRegister.PerformClick();
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            this.Close();
            loginForm.Show();
            //this.Hide();
        }
    }
}
