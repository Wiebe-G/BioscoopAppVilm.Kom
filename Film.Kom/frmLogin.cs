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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isLoginSucces = Login();
            if (isLoginSucces)
            {
                // ingelogd YIPPE
                // stuur ze hier door naar hoofdform
            }
            else
            {
                MessageBox.Show("Oh oh, iets niet goed gegaan met inloggen");
            }
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
            this.Hide();
        }
    }
}