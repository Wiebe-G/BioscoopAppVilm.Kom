using Npgsql;

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
            string Username = txtUsername.Text.Trim();
            string Password = txtPassword.Text.Trim();
            string HashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(Password, 13);
            using (var conn = new NpgsqlConnection(connStr))
            {
                string query = "INSERT INTO gebruikers (username, password) VALUES (@u, @p)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("u", Username);
                    cmd.Parameters.AddWithValue("p", HashedPassword);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool Login()
        {
            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT passwordh FROM gebruikers WHERE username = @u";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("u", lblUsername.Text);

                    var result = cmd.ExecuteScalar();
                    if (result == null) return false;

                    string hash = (string)result;

                    return BCrypt.Net.BCrypt.Verify(lblPassword.Text, hash);
                }
            }
        }
    }
}
