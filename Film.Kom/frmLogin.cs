using MongoDB.Driver;
using BC = BCrypt.Net.BCrypt;

namespace Film.Kom
{

    public partial class frmLogin : Form
    {
        private readonly IMongoCollection<User> _Users;
        public frmLogin()
        {
            InitializeComponent();
            // client en db aanmaken. niet veilige manier maar goed
            var client = new MongoClient("mongodb+srv://rickgeerdink2020_db_user:HWTyu7e8IBTBWhTT@cluster0.bi1idnh.mongodb.net/");
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister registerForm = new frmRegister();
            registerForm.Show();
            this.Close();
        }

        // originele event handler wou hij niet oppakken dus nu is naam niet goed :(
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            bool isLoginSucces = Login();
            if (isLoginSucces)
            {
                // ingelogd YIPPE
                MessageBox.Show($"Welkom, {txtUsername.Text}");
                this.Hide();
                frmMainMenu MainForm = new frmMainMenu();
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