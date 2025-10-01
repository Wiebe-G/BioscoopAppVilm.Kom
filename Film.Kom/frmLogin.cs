using MongoDB.Driver;
using BC = BCrypt.Net.BCrypt;

namespace Film.Kom
{
    internal class User
    {
        public MongoDB.Bson.ObjectId Id { get; set; }
        public string Naam { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string HashedPassword { get; set; } = string.Empty;
        public DateTime RegisteredAt { get; set; }
    }
    public partial class frmLogin : Form
    {
        private readonly IMongoCollection<User> _Users;
        public frmLogin()
        {
            InitializeComponent();
            var client = new MongoClient("mongodb + srv://rickgeerdink2020_db_user:HWTyu7e8IBTBWhTT@cluster0.bi1idnh.mongodb.net/");
            var db = client.GetDatabase("Vilm.kom");
            _Users = db.GetCollection<User>("");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isLoginSucces = Login();
            if (isLoginSucces)
            {
                // ingelogd YIPPE
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
            if (user == null) return false;
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
