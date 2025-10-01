using Npgsql;
using BC = BCrypt.Net.BCrypt;

namespace Film.Kom
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private readonly string connStr = "Host=localhost;Port=5432;Username=postgres;Password=root;Database=VILM_Project";

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        public bool Login()
        {
            string username = txtUsername.Text;
            string PlainPassword = txtPassword.Text;
            using (var Conn = new NpgsqlConnection(connStr))
            {
                Conn.Open();
                string query = "SELECT password FROM gebruikers WHERE username = @u";
                using (var cmd = new NpgsqlCommand(query, Conn))
                {
                    cmd.Parameters.AddWithValue("u", username);

                    var result = cmd.ExecuteScalar();
                    if (result == null) return false;

                    string hash = (string)result;
                    return BC.Verify(PlainPassword, hash);
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister registerForm = new frmRegister();
            registerForm.Show();
            this.Hide();
        }
    }
}
