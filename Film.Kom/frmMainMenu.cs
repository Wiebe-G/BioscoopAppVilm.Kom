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
    public partial class frmMainMenu : Form
    {
        Passwords passwords = new Passwords();
        private User _LoggedInUser;
        private IMongoCollection<FilmInfo> _Films;
        public frmMainMenu()
        {
            InitializeComponent();
            _LoggedInUser = new User();

            var client = new MongoClient(passwords.Database);
            var db = client.GetDatabase("Vilm");
            _Films = db.GetCollection<FilmInfo>("Films");

            var result = _Films.Aggregate()
                .Match(x => x.Poster != null)
                .Sample(5).Project(x => new { x.Poster }).ToList();

            picFilm1.Load(result[0].Poster);
            picFilm2.Load(result[1].Poster);
            picFilm3.Load(result[2].Poster);
            picFilm4.Load(result[3].Poster);
            picFilm5.Load(result[4].Poster);
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
                btnLogin.Text = $"{user.Naam} ";
                lblUsername.Text = user.Naam;
                btnLogin.Click -= btnLogin_Click;
                btnLogin.MouseClick += (sender, e) =>
                {
                    frmProfielpagina ProfileForm = new frmProfielpagina(user);
                    ProfileForm.Show();
                };
            }

            var client = new MongoClient(passwords.Database);
            var db = client.GetDatabase("Vilm");
            _Films = db.GetCollection<FilmInfo>("Films");

            var result = _Films.Aggregate()
                .Match(x => x.Poster != null)
                .Sample(5).Project(x => new { x.Poster }).ToList();

            for (int i = 0; i < result.Count; i++)
            {
                MessageBox.Show($"Poster {result} nummer {i}");
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
