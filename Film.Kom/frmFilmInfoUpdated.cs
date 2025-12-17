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
    internal partial class frmFilmInfoUpdated : Form
    {
        // Design door avsar gedaan, functionaliteit door Wiebe, zelfde als op frmFilmInfo
        private string _FilmName;
        private readonly User _LoggedInUser;

        public frmFilmInfoUpdated(string FilmName, User user)
        {
            InitializeComponent();
            _FilmName = FilmName;
            _LoggedInUser = user;
            UpdateLoginButton();
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

        private async void frmFilmInfoUpdated_Load(object sender, EventArgs e)
        {
            await FetchMovieInfo(_FilmName);
        }

        internal async Task FetchMovieInfo(string FilmName)
        {
            SearchForFilmsInDB SearchForFilms = new();
            var MovieData = await SearchForFilms.SearchFunction(FilmName.Trim().ToLower());
            if (MovieData == null)
            {
                MessageBox.Show($"Film is niet gevonden. probeer het opnieuw");
                return;
            }
            if (!string.IsNullOrWhiteSpace(MovieData.Poster) && MovieData.Poster != "N/A")
            {
                ShowDataOnTheForm(MovieData);
            }
        }

        private void ShowDataOnTheForm(FilmInfo MovieData)
        {
            picPoster.Load(MovieData.Poster);
            picPoster.SizeMode = PictureBoxSizeMode.StretchImage;

            lblTitle.Text = $"Titel: {MovieData.Title} ";
            lblPlot.Text = $"Plot: {MovieData.Plot}";
            if (MovieData.Rated == "R")
            {
                lblRating.Text = $"Rating: {MovieData.Rated}, dus geen kinderen meenemen";
            }
            else
            {
                lblRating.Text = $"Rating: {MovieData.Rated}, dus kinderen mogen mee";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin LoginForm = new();
            LoginForm.Show();
        }

        private void btnReservering_Click(object sender, EventArgs e)
        {
            frmStoelen_reservation ReserveringsForm = new(_LoggedInUser, _FilmName);
            ReserveringsForm.Show();
        }
    }
}
