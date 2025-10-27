using System.Text.Json;

namespace Film.Kom
{
    public partial class frmFilmInfo : Form
    {
        private string _FilmName;
        public frmFilmInfo(string FilmName)
        {
            InitializeComponent();
            _FilmName = FilmName;

        }

        private async void frmFilmInfo_Load_1(object sender, EventArgs e)
        {
            await GetMovieInfo(_FilmName);
        }

        private async Task GetMovieInfo(string FilmName)
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

                if (response.IsSuccessStatusCode)
                {
                    // film is gevonden
                    string JSONResponse = await response.Content.ReadAsStringAsync();
                    var MovieData = JsonSerializer.Deserialize<FilmInfo>(JSONResponse);
                    // vraagteken betekent dat de variabele null mag zijn
                    if (MovieData?.Response == "True")
                    {
                        // data correct opgehaald
                        if (!string.IsNullOrWhiteSpace(MovieData.Poster) && MovieData.Poster != "N/A")
                        {
                            DisplayData(MovieData.Poster, MovieData.Title, MovieData.Plot, MovieData.Rated);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Film niet gevonden");
                    }
                }
                else
                {
                    MessageBox.Show($"{response.StatusCode} {response.RequestMessage}");
                    MessageBox.Show($"Oh oh, er ging iets niet goed. Statuscode: {response.StatusCode}. Reden: {response.ReasonPhrase}");
                }
            }
        }
        private void DisplayData(string ImageLocation, string Title, string Plot, string Rating)
        {
            picPoster.Load(ImageLocation);
            picPoster.SizeMode = PictureBoxSizeMode.StretchImage;

            lblTitle.Text = Title;
            lblPlot.Text = Plot;
            lblRating.Text = Rating;
        }

        private void btnReservering_Click(object sender, EventArgs e)
        {
            frmReservering reservering = new frmReservering();
            reservering.Show();
        }
    }
}
