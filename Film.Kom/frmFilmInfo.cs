using System.Text.Json;

namespace Film.Kom
{
    public partial class frmFilmInfo : Form
    {
        private string _FilmName;
        private User _LoggedInUser;
        public frmFilmInfo(string FilmName)
        {
            InitializeComponent();
            _FilmName = FilmName;
            _LoggedInUser = new User();
            UpdateLoginButton();
        }

        public frmFilmInfo(string FilmName, User user)
        {
            InitializeComponent();
            _FilmName = FilmName;
            _LoggedInUser = user ?? new User();
            UpdateLoginButton();
        }

        private async void frmFilmInfo_Load(object sender, EventArgs e)
        {
            await GetMovieInfo(_FilmName);
        }

        private void UpdateLoginButton()
        {
            if (string.IsNullOrWhiteSpace(_LoggedInUser?.Naam))
            {
                btnLogin.Text = "Log in";
            }
            else
            {
                btnLogin.Text = _LoggedInUser?.Naam;
            }
        }

        internal async Task GetMovieInfo(string FilmName)
        {
            // fetch met omdbapi info over de film
            // en display de info
            string APIkey = "4bed3fd6";
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
                if (!string.IsNullOrWhiteSpace(MovieData.Poster) && MovieData.Poster != "N/A")
                {
                    DisplayData(MovieData.Poster, MovieData.Title, MovieData.Plot, MovieData.Rated);
                }
            }
        }
        private void DisplayData(string ImageLocation, string Title, string Plot, string Rating)
        {
            picPoster.Load(ImageLocation);
            picPoster.SizeMode = PictureBoxSizeMode.StretchImage;

            lblTitle.Text = $"Titel: {Title} ";
            lblPlot.Text = $"Plot: {Plot}";
            if (Rating == "R")
            {
                lblRating.Text = $"Rating: {Rating}, dus geen kinderen meenemen";
            }
            else
            {
                lblRating.Text = $"Rating: {Rating}, dus kinderen mogen mee";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
            this.Hide();
        }

        private void btnReservering_Click(object sender, EventArgs e)
        {
            frmPayment PaymentForm = new frmPayment(_LoggedInUser);
            PaymentForm.Show();
        }
    }
}
