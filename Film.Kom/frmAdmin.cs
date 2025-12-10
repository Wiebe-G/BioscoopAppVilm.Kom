using MongoDB.Bson;
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
    internal partial class frmAdmin : Form
    {
        private readonly User _LoggedInUser;
        private readonly Passwords passwords = new();
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
            frmProfielpagina ProfileForm = new(_LoggedInUser);
            ProfileForm.Show();
            this.Hide();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                var DBUser = _Users.Find(g => g.Naam == _LoggedInUser.Naam).FirstOrDefault();

                if (DBUser.Rol == 0)
                {
                    MessageBox.Show("Wat? Hoe ben jij hier gekomen?");
                    return;
                }
                FetchAllUsers();

                //LoadFilmsIntoTable();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fout: {ex.Message} \n Stacktrace: {ex.StackTrace} \n Innerexception: {ex.InnerException}");
            }
        }

        private void LoadFilmsIntoTable()
        {
            MessageBox.Show("Deze method is om alle films in de 2e tab te laten zien zodat je ze kunt aanpassen. " +
                "Dit komt nog wel");
        }

        private void FetchAllUsers()
        {
            var EmptyFilter = Builders<User>.Filter.Empty;
            var AllUsers = _Users.Find(EmptyFilter).ToList();

            LoadUsersIntoTable(AllUsers);
        }

        private void LoadUsersIntoTable(List<User> AllUsers)
        {
            int MaxRows = AllUsers.Count;
            if (MaxRows == 0)
            {
                MessageBox.Show("Geen gebruikers gevonden");
                pnlTabUsers.Controls.Clear();
                pnlTabUsers.RowStyles.Clear();
                pnlTabUsers.RowCount = 0;
                return;
            }

            pnlTabUsers.SuspendLayout();
            pnlTabUsers.Controls.Clear();
            pnlTabUsers.RowStyles.Clear();
            pnlTabUsers.RowCount = MaxRows;
            pnlTabUsers.AutoScroll = true;

            // Hier wel wat hulp gehad van gpt, maar goed 
            int ContainerHeight = Math.Max(1, pnlTabUsers.ClientSize.Height);
            int MinRowHeight = Math.Max(100, (int)(ContainerHeight * 0.2f));

            long TotalMinHeight = (long)MinRowHeight * MaxRows;
            bool UsePercent = TotalMinHeight <= ContainerHeight;

            // hoogte aanpassen
            for (int r = 0; r < MaxRows; r++)
            {
                if (UsePercent)
                {
                    pnlTabUsers.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / MaxRows)
                );
                }
                else
                {
                    pnlTabUsers.RowStyles.Add(new RowStyle(SizeType.Absolute, MinRowHeight));
                }
            }

            int i = 0;

            for (int row = 0; row < MaxRows; row++)
            {
                CreateTablesForUserDisplay(out TableLayoutPanel Panel, MinRowHeight, AllUsers, i);

                Button DeleteUserButton = new()
                {
                    Text = $"Verwijder gebruiker {AllUsers[i].Naam}",
                    Dock = DockStyle.Fill,
                    AutoSize = true,
                    TextAlign = ContentAlignment.MiddleCenter,
                };


                pnlTabUsers.Controls.Add(DeleteUserButton, 1, row);
                pnlTabUsers.Controls.Add(Panel, 0, row);

                i++;
            }
            pnlTabUsers.ResumeLayout();
        }

        private void CreateTablesForUserDisplay(out TableLayoutPanel Panel, int MinRowHeight, List<User> AllUsers, int Iterator)
        {
            Panel = new()
            {
                RowCount = 2,
                ColumnCount = 2,
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                AutoSize = false,
                Width = 100,
                AutoScroll = false,
                MinimumSize = new Size(0, MinRowHeight),
                Height = MinRowHeight,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset,
            };

            for (int i = 0; i < Panel.ColumnCount; i++)
            {
                Panel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / Panel.ColumnCount));
            }

            pnlTabUsers.VerticalScroll.Value = 1;
            Label UserName = new()
            {
                Text = $"Naam: {AllUsers[Iterator].Naam}",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                AutoSize = false,
                MinimumSize = new Size(0, 1)
            };

            Label Email = new()
            {
                Text = $"Email: {AllUsers[Iterator].Email}",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                AutoSize = false,
                MinimumSize = new Size(0, 1)
            };

            Label RegisterdAt = new()
            {
                Text = $"Lid sinds: {AllUsers[Iterator].RegisteredAt}",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                AutoSize = false,
                MinimumSize = new Size(0, 1)
            };

            Label DateOfBirth = new()
            {
                Text = $"Geboren op: {AllUsers[Iterator].Geboortedatum}",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                AutoSize = false,
                MinimumSize = new Size(0, 1)
            };

            // Wou dit met een loop doen maar winforms dacht daar anders over :(
            UserName.Font = new Font(UserName.Font, FontStyle.Bold);
            Email.Font = new Font(Email.Font, FontStyle.Bold);
            RegisterdAt.Font = new Font(RegisterdAt.Font, FontStyle.Bold);
            DateOfBirth.Font = new Font(DateOfBirth.Font, FontStyle.Bold);

            Panel.Controls.Add(UserName, 0, 0);
            Panel.Controls.Add(Email, 0, 1);
            Panel.Controls.Add(RegisterdAt, 1, 0);
            Panel.Controls.Add(DateOfBirth, 1, 1);

            Panel.ColumnStyles.Clear();
            Panel.RowStyles.Clear();

            Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70f));
            Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));

            Panel.RowStyles.Add(new RowStyle(SizeType.Percent, 60f));
            Panel.RowStyles.Add(new RowStyle(SizeType.Percent, 40f));

        }

        private async void BtnSearch_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
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
                    picFilmPoster.Load(MovieData?.Poster);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fout opgetreden: {ex.Message}.\nStacktrace: {ex.StackTrace}");
                }
            }
        }

        private async Task<FilmInfo?> FetchFilmInfo()
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
                if (MovieData?.Response != "True")
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
