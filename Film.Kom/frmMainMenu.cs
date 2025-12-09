using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    internal partial class frmMainMenu : Form
    {
        Passwords passwords = new Passwords();
        private User _LoggedInUser;
        private IMongoCollection<FilmInfo> _Films;
        public frmMainMenu()
        {
            InitializeComponent();
            _LoggedInUser = new User();
            DisplayFiveRandomFilmsOnHomePage();
        }

        private void DisplayFiveRandomFilmsOnHomePage()
        {
            List<PictureBox> posters = new List<PictureBox>()
            {
                picFilm1, picFilm2, picFilm3, picFilm4, picFilm5
            };
            List<Label> labels = new List<Label>()
            {
                lblFilm1, lblFilm2, lblFilm3, lblFilm4, lblFilm5
            };

            var client = new MongoClient(passwords.Database);
            var db = client.GetDatabase("Vilm");
            _Films = db.GetCollection<FilmInfo>("Films");

            var result = _Films.Aggregate()
                .Match(x => x.Poster != null)
                .Sample(5).Project(x => new { x.Poster, x.Title }).ToList();

            for (int i = 0; i < result.Count; i++)
            {
                posters[i].Load(result[i].Poster);
                labels[i].Text = result[i].Title;
                frmFilmInfo FilmForm = new frmFilmInfo(result[i].Title, _LoggedInUser);
                posters[i].Click += (sender, e) =>
                {
                    FilmForm.Show();
                };
            }
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

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForFilmsInDB SearchForFilms = new();
            var MovieInfo = await SearchForFilms.SearchFunction(txtSearch.Text.Trim().ToLower());
            if (MovieInfo == null)
            {
                MessageBox.Show($"Film is niet gevonden. probeer het opnieuw");
                return;
            }
            MessageBox.Show($"Film {MovieInfo.Title} is gevonden. Hij draait in zaal {MovieInfo.Zaal} om {MovieInfo.Speeltijd}.");
            picFilm1.Load(MovieInfo.Poster);
            frmFilmInfo filmForm = new frmFilmInfo(MovieInfo.Title, _LoggedInUser);
            picFilm1.MouseClick += (sender, e) =>
            {
                filmForm.Show();
            };
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void lblFilm5_Click(object sender, EventArgs e)
        {

        }
    }
}
