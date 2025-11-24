using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film.Kom
{
    public partial class frmMainMenu : Form
    {
        Passwords passwords = new Passwords();
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
            SearchFunction();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private async Task SearchFunction()
        {
            string FilmName = txtSearch.Text;
            string APIkey = passwords.APIKey;
            string BaseURL = "https://www.omdbapi.com";

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseURL);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                var QueryString = $"t={Uri.EscapeDataString(FilmName)}&plot=full&&apikey={APIkey}";
                HttpResponseMessage response = await client.GetAsync($"?{QueryString}");

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Oh oh, er ging iets niet goed. Statuscode: {response.StatusCode}. Reden: {response.ReasonPhrase}");
                    return;
                }
                string JSONResponse = await response.Content.ReadAsStringAsync();
                var MovieData = JsonSerializer.Deserialize<FilmInfo>(JSONResponse);
                // vraagteken betekent dat de variabele null mag zijn
                if (MovieData?.Response != "True")
                {
                    MessageBox.Show("Film niet gevonden");
                    return;
                }
                // TODO: zorg ervoor dat de meeste recente zoekopdracht op plek 1 komt, en op 1 na laaste op 2, etc
                MessageBox.Show($"Film {FilmName} is gevonden. {MovieData.Year}");
                picFilm1.Load(MovieData.Poster);
                frmFilmInfo filmForm = new frmFilmInfo(FilmName, _LoggedInUser);
                picFilm1.MouseClick += (sender, e) =>
                {
                    filmForm.Show();
                };
            }
        }

        private void lblFilm5_Click(object sender, EventArgs e)
        {

        }
    }
}
