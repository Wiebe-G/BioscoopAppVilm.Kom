using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Film.Kom
{
    public partial class frmBibliotheek : Form
    {

        private readonly Passwords passwords = new();
        private readonly User _LoggedInUser;
        private IMongoCollection<FilmInfo> _Films;

        public frmBibliotheek() //gast gebruiker
        {
            InitializeComponent();
            _LoggedInUser = new User();
        }

        public frmBibliotheek(User user) //ingelogde gebruiker
        {
            InitializeComponent();
            _LoggedInUser = user;
        }

        private void ConnectToDatabase() //Database
        {
            var client = new MongoClient(passwords.Database);
            var database = client.GetDatabase("Vilm");
            _Films = database.GetCollection<FilmInfo>("Films");
        }


        private void frmBibliotheek_Load(object sender, EventArgs e)
        {
            pnlFilms.AutoScroll = true;
            pnlFilms.HorizontalScroll.Enabled = false;
            pnlFilms.HorizontalScroll.Visible = false;

            ConnectToDatabase();
            LoadFilms();        
        }


        private void LoadFilms() //Films laden in bibliotheek
        {
            pnlFilms.Controls.Clear();

            var films = _Films
                .Find(Builders<FilmInfo>.Filter.Empty)
                .ToList();

            int filmsPerRow = 5;
            int posterWidth = 250;
            int posterHeight = 350;
            int margin = 10;

            int currentY = 10;

            for (int i = 0; i < films.Count; i += filmsPerRow)
            {
                Panel pnlRow = new Panel
                {
                    Height = posterHeight + 30,
                    Width = pnlFilms.ClientSize.Width,
                    Left = 0,
                    Top = currentY
                };

                for (int j = 0; j < filmsPerRow && (i + j) < films.Count; j++)
                {
                    FilmInfo film = films[i + j];

                    PictureBox pb = new PictureBox
                    {
                        Width = posterWidth,
                        Height = posterHeight,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Left = j * (posterWidth + margin),
                        Top = 0,
                        Cursor = Cursors.Hand
                    };

                    if (!string.IsNullOrEmpty(film.Poster))
                        pb.Load(film.Poster);

                    Label lbl = new Label
                    {
                        Text = film.Title,
                        Width = posterWidth,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Top = pb.Bottom + 5,
                        Left = pb.Left
                    };

                    pb.Click += (s, e) => // Open film info
                    {
                        frmFilmInfo filmForm = new(film.Title, _LoggedInUser);
                        filmForm.Show();
                    };

                    pnlRow.Controls.Add(pb);
                    pnlRow.Controls.Add(lbl);
                }

                pnlFilms.Controls.Add(pnlRow);
                currentY += pnlRow.Height + margin;
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new();
            loginForm.Show();
            this.Hide();
        }

        private void btnBibliotheek_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenu = new(_LoggedInUser);
            mainMenu.Show();
            this.Hide();
        }
    }
}
