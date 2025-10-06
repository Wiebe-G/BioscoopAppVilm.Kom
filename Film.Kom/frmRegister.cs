using MongoDB.Driver;
using BC = BCrypt.Net.BCrypt;

namespace Film.Kom
{
    public partial class frmRegister : Form
    {
        private readonly IMongoCollection<User> _Users;
        public frmRegister()
        {
            InitializeComponent();

            var client = new MongoClient("mongodb+srv://rickgeerdink2020_db_user:HWTyu7e8IBTBWhTT@cluster0.bi1idnh.mongodb.net/");
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
    }
}
