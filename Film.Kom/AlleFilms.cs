using MongoDB.Driver;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Film.Kom
{
    public partial class frmAlleFilms : Form
    {
        private readonly IMongoCollection<FilmInfo> _Films;

        public frmAlleFilms()
        {
            InitializeComponent();

            var passwords = new Passwords();
            var client = new MongoClient(passwords.Database);
            var db = client.GetDatabase("Vilm");

            _Films = db.GetCollection<FilmInfo>("Films");
        }

        private void frmAlleFilms_Load(object sender, EventArgs e)
        {
            SetupTableLayout();
            LoadAllFilms();
        }

        private void SetupTableLayout()
        {
            pnlMovies.SuspendLayout();

            pnlMovies.Controls.Clear();
            pnlMovies.RowStyles.Clear();
            pnlMovies.ColumnStyles.Clear();

            pnlMovies.ColumnCount = 5;
            pnlMovies.RowCount = 0;

            for (int i = 0; i < 5; i++)
            {
                pnlMovies.ColumnStyles.Add(
                    new ColumnStyle(SizeType.Absolute, 220)
                );
            }

            pnlMovies.AutoScroll = true;

            pnlMovies.ResumeLayout();
        }

        private void LoadAllFilms()
        {
            var films = _Films.Find(FilterDefinition<FilmInfo>.Empty).ToList();

            pnlMovies.SuspendLayout();
            pnlMovies.Controls.Clear();
            pnlMovies.RowStyles.Clear();
            pnlMovies.RowCount = 0;

            int col = 0;
            int row = 0;

            foreach (var film in films)
            {
                if (col == 0)
                {
                    pnlMovies.RowCount++;
                    pnlMovies.RowStyles.Add(
                        new RowStyle(SizeType.Absolute, 350)
                    );
                }

                Panel filmCard = CreateFilmCard(film);
                pnlMovies.Controls.Add(filmCard, col, row);

                col++;

                if (col == 5)
                {
                    col = 0;
                    row++;
                }
            }

            pnlMovies.ResumeLayout();
        }

        private Panel CreateFilmCard(FilmInfo film)
        {
            Panel card = new Panel
            {
                Width = 200,
                Height = 320,
                Margin = new Padding(10),
                BackColor = Color.Black,
                Cursor = Cursors.Hand
            };

            PictureBox poster = new PictureBox
            {
                Dock = DockStyle.Top,
                Height = 260,
                SizeMode = PictureBoxSizeMode.Zoom,
                Cursor = Cursors.Hand
            };

            if (!string.IsNullOrWhiteSpace(film.Poster))
            {
                try
                {
                    poster.Load(film.Poster); // betrouwbaarder dan LoadAsync
                }
                catch
                {
                    poster.BackColor = Color.DarkGray;
                }
            }

            Label title = new Label
            {
                Text = film.Title,
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Cursor = Cursors.Hand
            };

            card.Click += (s, e) => ShowFilmInfo(film);
            poster.Click += (s, e) => ShowFilmInfo(film);
            title.Click += (s, e) => ShowFilmInfo(film);

            card.Controls.Add(title);
            card.Controls.Add(poster);

            return card;
        }

        private void ShowFilmInfo(FilmInfo film)
        {
            MessageBox.Show(
                $"Titel: {film.Title}\n\n" +
                $"Genre: {film.Genre}\n" +
                $"Duur: {film.Runtime}\n" +
                $"Rating: {film.Rated}\n\n" +
                $"{film.Plot}",
                "Film informatie",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnBibliotheek_Click(object sender, EventArgs e)
        {
            frmMainMenu menu = new frmMainMenu();
            menu.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new();
            loginForm.Show();
            this.Hide();
        }
    }
}
