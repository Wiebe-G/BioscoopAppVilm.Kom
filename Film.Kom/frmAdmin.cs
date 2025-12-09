using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film.Kom
{
    public partial class frmAdmin : Form
    {
        private User _LoggedInUser;
        private readonly Passwords passwords = new Passwords();
        private readonly IMongoCollection<User> _Users;
        private readonly IMongoCollection<FilmInfo> _Films;

        public frmAdmin(User user)
        {
            InitializeComponent();
            _LoggedInUser = user;
            var client = new MongoClient(passwords.Database);
            var db = client.GetDatabase("Vilm");

            _Users = db.GetCollection<User>("Users");
            _Films = db.GetCollection<FilmInfo>("Films");
        }

        private void btnBackToProfile_Click(object sender, EventArgs e)
        {
            frmProfielpagina ProfileForm = new frmProfielpagina(_LoggedInUser);
            ProfileForm.Show();
            this.Hide();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            var DBUser = _Users.Find(g => g.Naam == _LoggedInUser.Naam).FirstOrDefault();

            if (DBUser.Rol == 0)
            {
                MessageBox.Show("Wat? Hoe ben jij hier gekomen?");
                return;
            }

            int MaxRows = 5;
            int MaxCols = 2;
            pnlTabUsers.RowStyles.Clear();

            // hoogte aanpassen
            for (int r = 0; r < MaxRows; r++)
            {
                pnlTabUsers.RowStyles.Add(
                    new RowStyle(SizeType.Percent, 100f / MaxRows)
                );
            }

            // TODO: zorg ervoor dat links een tablelayoutpanel met 4 labels voor Naam, Email, RegisteredAt en geboortedatum links komen
            // en rechts een knop om die gebruiker te verwijderen
            for (int row = 0; row < MaxRows; row++)
            {
                for (int col = 0; col < MaxCols; col++)
                {
                    SuspendLayout();
                    TableLayoutPanel Panel = new()
                    {
                        RowCount = 2,
                        ColumnCount = 2,
                        Dock = DockStyle.Fill,
                        BackColor = Color.White,
                        AutoSize = true,
                        Width = 100
                    };

                    Label UserName = new Label { Text = "Naam", TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill, AutoSize = false };

                    Label Email = new() { Text = "Email", TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill, AutoSize = false };

                    Label RegisterdAt = new() { Text = "Registratiedatum", TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill, AutoSize = false };

                    Label DateOfBirth = new() { Text = "Geboortedatum", TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill, AutoSize = false };

                    Panel.Controls.Add(UserName, 0, 0);
                    Panel.Controls.Add(Email, 0, 1);
                    Panel.Controls.Add(RegisterdAt, 1, 0);
                    Panel.Controls.Add(DateOfBirth, 1, 1);

                    Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70f));
                    Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));

                    Panel.RowStyles.Add(new RowStyle(SizeType.Percent, 60f));
                    Panel.RowStyles.Add(new RowStyle(SizeType.Percent, 40f));

                    Panel.RowCount++;

                    Button ButtonForDeleting = new()
                    {
                        Text = "Mooie knop",
                        Dock = DockStyle.Fill,
                        AutoSize = true,

                    };

                    ButtonForDeleting.Click += (s, ev) =>
                    {
                        MessageBox.Show("Gebruiker links fetchen");
                    };

                    pnlTabUsers.Controls.Add(ButtonForDeleting, col, row);
                    pnlTabUsers.Controls.Add(Panel, col, row);

                    ResumeLayout();
                }
            }
        }

        private void Test_Click(object sender, EventArgs e)
        {

        }

        private async void BtnSearch_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var MovieData = await FetchFilmInfo();
                if (MovieData == null)
                {
                    return;
                }
                MessageBox.Show($"Film {MovieData.Title} is gevonden.");
                lblFilmTitle.Text = MovieData?.Title;
                lblFilmRuntime.Text = MovieData?.Runtime;
                lblFilmGenre.Text = MovieData?.Genre;
                lblFilmPlot.Text = MovieData?.Plot;
                lblFilmRated.Text = MovieData?.Rated;
                picFilmPoster.Load(MovieData.Poster);
            }
            else
            {
                // niks doen
            }
        }

        private async Task<FilmInfo> FetchFilmInfo()
        {
            string FilmName = txtInputForAddingFilms.Text.Trim();
            string APIKey = passwords.APIKey;
            string BaseURL = "https://omdbapi.com";

            using (var client = new HttpClient())
            {
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
                if (MovieData.Response != "True")
                {
                    MessageBox.Show("Film niet gevonden");
                    return null;
                }
                return MovieData;
            }
        }

        private async void btnAddFilmToDatabase_Click(object sender, EventArgs e)
        {
            var MovieData = await FetchFilmInfo();
            if (MovieData == null)
            {
                MessageBox.Show("Ohoh");
            }
            if (string.IsNullOrWhiteSpace(txtFilmPlaytime.Text.Trim()) || string.IsNullOrWhiteSpace(txtFilmRoom.Text.Trim()))
            {
                MessageBox.Show("Alles invullen he");
                return;
            }
            var DoesFilmExist = _Films.Find(T => T.Title == MovieData.Title).FirstOrDefault();
            if (DoesFilmExist != null)
            {
                MessageBox.Show("Film staat al in de database", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var NewFilm = new FilmInfo()
            {
                Title = MovieData.Title,
                Year = MovieData.Year,
                Genre = MovieData.Genre,
                Director = MovieData.Director,
                Plot = MovieData.Plot,
                Poster = MovieData.Poster,
                Response = "True",
                Rated = MovieData.Rated,
                Runtime = MovieData.Runtime,
                Speeltijd = txtFilmPlaytime.Text.Trim(),
                Zaal = txtFilmRoom.Text.Trim()
            };
            _Films.InsertOne(NewFilm);
            MessageBox.Show($"Film {MovieData.Title} is succesvol toegevoegd aan de database.");
        }
    }
}
