using System.Text.Json;

namespace Film.Kom
{
    public partial class frmFilmInfo : Form
    {
        public async Task filmMainMethod(string FilmName)
        {
            InitializeComponent();
            await GetMovieInfo(FilmName);

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

                var QueryString = $"t={Uri.EscapeDataString(FilmName)}&apikey={APIkey}";
                HttpResponseMessage response = await client.GetAsync(QueryString);

                if (response.IsSuccessStatusCode)
                {
                    // film is gevonden
                    string JSONResponse = await response.Content.ReadAsStringAsync();
                    var FilmData = JsonSerializer.Deserialize<FilmInfo>(JSONResponse);

                    if (FilmData?.Response == "True")
                    {
                        // data correct opgehaald
                        MessageBox.Show($"film gegevens: {FilmData.FilmName} - {FilmData.Year} " +
                            $"- {FilmData.Genre} - {FilmData.Genre} - {FilmData.Director} -" +
                            $"{FilmData.Plot} - {FilmData.Poster} poster url");
                        // zet dit in labels!!!!
                    }
                    else
                    {
                        MessageBox.Show("Film niet gevonden");
                    }
                }
                else
                {
                    MessageBox.Show($"Oh oh, er ging iets niet goed. {response.StatusCode}");
                }
            }
        }
    }
    internal class FilmInfo
    {
        public string FilmName { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public string Director { get; set; } = string.Empty;
        public string Plot { get; set; } = string.Empty;
        public string Poster { get; set; } = string.Empty;
        public string Response { get; set; } = string.Empty;
    }
}
