using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film.Kom
{
    internal partial class frmMainMenu : Form
    {
        // Design door Avsar, functionaliteit door Wiebe
        private readonly Passwords passwords = new();
        private readonly User _LoggedInUser;
        private IMongoCollection<FilmInfo> _Films;

        // Slideshow
        private List<string> _slideshowPosters = new();
        private int _slideshowIndex = 0;
        private Random _random = new Random();
        private string _lastPoster = "";

        public frmMainMenu()
        {
            InitializeComponent();
            _LoggedInUser = new User();
            DisplayFiveRandomFilmsOnHomePage();
            LoadSlideshowPosters();
        }

        public frmMainMenu(User user)
        {
            InitializeComponent();
            _LoggedInUser = user;

            if (string.IsNullOrWhiteSpace(user.Naam))
            {
                btnLogin.Text = "Inloggen";
                lblUsername.Text = "Gast";
            }
            else
            {
                btnLogin.Text = $"{user.Naam} ";
                lblUsername.Text = user.Naam;
                btnLogin.Click -= btnLogin_Click;
                btnLogin.MouseClick += (sender, e) =>
                {
                    frmProfielpagina ProfileForm = new(user);
                    ProfileForm.Show();
                };
            }

            DisplayFiveRandomFilmsOnHomePage();
            LoadSlideshowPosters();
        }

        private void DisplayFiveRandomFilmsOnHomePage()
        {
            List<PictureBox> posters = new() { picFilm1, picFilm2, picFilm3, picFilm4, picFilm5 };
            List<Label> labels = new() { lblFilm1, lblFilm2, lblFilm3, lblFilm4, lblFilm5 };

            var client = new MongoClient(passwords.Database);
            var db = client.GetDatabase("Vilm");
            _Films = db.GetCollection<FilmInfo>("Films");

            var result = _Films.Aggregate()
                .Match(x => x.Poster != null)
                .Sample(5)
                .Project(x => new { x.Poster, x.Title })
                .ToList();

            for (int i = 0; i < result.Count; i++)
            {
                posters[i].Load(result[i].Poster);
                labels[i].Text = result[i].Title;

                frmFilmInfo FilmForm = new(result[i].Title, _LoggedInUser);
                posters[i].Click += (sender, e) =>
                {
                    FilmForm.Show();
                };
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new();
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

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string FilmSearchInput = txtSearch.Text.ToLower().Trim();

            if (string.IsNullOrWhiteSpace(FilmSearchInput))
            {
                MessageBox.Show("Geen zoekopdracht ingevuld.");
                return;
            }
            // film opzoeken in de api
            var MovieDataFromApiResult = await new SearchForFilmsInApi().FetchFilmInfo(FilmSearchInput);

            if (MovieDataFromApiResult == null)
            {
                MessageBox.Show("Film is niet goed opgehaald. Probeer het opnieuw.");
                return;
            }
            // de titel die uit de api is gehaald gebruiken als query in de database
            var MovieInfo = await new SearchForFilmsInDB().SearchFunction(MovieDataFromApiResult.Title);

            if (MovieInfo == null)
            {
                MessageBox.Show($"Film {MovieDataFromApiResult.Title} is niet gevonden. Probeer het opnieuw.");
                return;
            }

            MessageBox.Show($"Film {MovieInfo.Title} is gevonden. Hij draait in zaal {MovieInfo.Zaal} om {MovieInfo.Speeltijd}.");
            picFilm1.Load(MovieInfo.Poster);

            frmFilmInfo filmForm = new(MovieInfo.Title, _LoggedInUser);
            picFilm1.MouseClick += (sender, e) =>
            {
                filmForm.Show();
            };
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        // --- Slideshow timer tick ---
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_slideshowPosters.Count == 0) return;

            string nextPoster;
            do
            {
                int index = _random.Next(_slideshowPosters.Count);
                nextPoster = _slideshowPosters[index];
            } while (nextPoster == _lastPoster && _slideshowPosters.Count > 1);

            picSlideshow.Load(nextPoster);
            _lastPoster = nextPoster;
        }

        // --- Load posters for slideshow ---
        private void LoadSlideshowPosters()
        {
            var client = new MongoClient(passwords.Database);
            var db = client.GetDatabase("Vilm");
            var films = db.GetCollection<FilmInfo>("Films");

            _slideshowPosters = films
                .Find(f => f.Poster != null)
                .Project(f => f.Poster)
                .ToList();

            if (_slideshowPosters.Count > 0)
            {
                int startIndex = _random.Next(_slideshowPosters.Count);
                picSlideshow.Load(_slideshowPosters[startIndex]);
                _lastPoster = _slideshowPosters[startIndex];

                timer1.Interval = 3000; // 3 seconden
                timer1.Tick += timer1_Tick;
                timer1.Start();
            }
        }
    }
}
