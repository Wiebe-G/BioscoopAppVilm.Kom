using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Film.Kom
{
    internal class SearchForFilmsInApi
    {
        private readonly Passwords passwords = new();
        internal async Task<FilmInfo?> FetchFilmInfo(string input)
        {
            string FilmName = input.Trim();
            string APIKey = passwords.APIKey;
            string BaseURL = "https://omdbapi.com";

            using var client = new HttpClient();
            client.BaseAddress = new Uri(BaseURL);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var QueryString = $"t={Uri.EscapeDataString(FilmName)}&plot=full&&apikey={APIKey}";
            HttpResponseMessage response = await client.GetAsync($"?{QueryString}");

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show($"Oh oh, er ging iets niet goed. Statuscode: {response.StatusCode}. Reden: {response.ReasonPhrase}");
                return null;
            }

            string JSONResponse = await response.Content.ReadAsStringAsync();
            var MovieData = JsonSerializer.Deserialize<FilmInfo>(JSONResponse);
            // vraagteken betekent dat de variabele null mag zijn
            if (MovieData?.Response != "True")
            {
                MessageBox.Show("Film niet gevonden");
                return null;
            }
            return MovieData;
        }
    }
}
