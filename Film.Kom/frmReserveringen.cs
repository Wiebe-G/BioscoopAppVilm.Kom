using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film.Kom
{
    internal partial class frmStoelen_reservation : Form
    {
        private List<Seat> _allSeats = new();
        private List<string> _selectedSeats = new();
        private bool _seatsInitialized = false;

        public class Seat
        {
            public string Id { get; set; }
            public bool IsReserved { get; set; }
            public bool IsSelected { get; set; }
        }

        private User _User;
        private readonly string _Filmname;
        private readonly IMongoCollection<FilmInfo> _Films;
        Passwords passwords = new Passwords();
        public frmStoelen_reservation(User user, string FilmName)
        {
            InitializeComponent();
            _User = user;
            _Filmname = FilmName.Trim().ToLower();

            var client = new MongoClient(passwords.Database);
            var db = client.GetDatabase("Vilm");
            _Films = db.GetCollection<FilmInfo>("Films");
        }

        private async void frmStoelen_reservation_Load(object sender, EventArgs e)
        {
            SearchForFilmsInDB SearchForFilm = new();
            var MovieData = await SearchForFilm.SearchFunction(_Filmname);
            lblTopTitle.Text = MovieData.Title;
            lblTitel.Text = MovieData.Title;
            lblZaal.Text = MovieData.Zaal;
            lblSpeelduur.Text = MovieData.Runtime;
            lblBegintijd.Text = MovieData.Speeltijd;
            lblEindtijd.Text = "Reken het zelf maar uit";
            picPoster.Load(MovieData.Poster);
        }
        private async void frmStoelen_reservation_Shown(object sender, EventArgs e)
        {
            if (!_seatsInitialized)
            {
                await InitializeSeatsAsync();
                _seatsInitialized = true;
            }
        }

        private IEnumerable<Control> GetAllButtons(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                yield return c;

                foreach (Control child in GetAllButtons(c))
                {
                    yield return child;
                }
            }
        }

        private async Task InitializeSeatsAsync()
        {
            _allSeats.Clear();
            _selectedSeats.Clear();

            List<string> reservedFromDb = new List<string>();
            try
            {
                var filmDoc = await _Films.Find(f => f.Title.ToLower() == _Filmname.ToLower()).FirstOrDefaultAsync();
                if (filmDoc != null && filmDoc.ReservedSeats != null)
                    reservedFromDb = filmDoc.ReservedSeats;
            }
            catch
            {
                MessageBox.Show("Fout bij het ophalen van gereserveerde stoelen uit de database.");
            }

            var buttons = GetAllButtons(this)
                .OfType<Button>()
                .Where(b => b.Name.StartsWith("btnStoel", StringComparison.OrdinalIgnoreCase))
                .ToList();

            foreach (var btn in buttons)
            {
                var id = btn.Name.Replace("btnStoel", "", StringComparison.OrdinalIgnoreCase);

                var seat = new Seat
                {
                    Id = id,
                    IsReserved = reservedFromDb.Any(s => string.Equals(s, id, StringComparison.OrdinalIgnoreCase)),
                    IsSelected = false
                };

                _allSeats.Add(seat);
                btn.Tag = seat;
                btn.Click -= Seat_Click;
                btn.Click += Seat_Click;
            }

            UpdateSeatColors();
        }

        private void UpdateSeatColors()
        {
            var buttons = GetAllButtons(this)
                .OfType<Button>()
                .Where(b => b.Name.StartsWith("btnStoel", StringComparison.OrdinalIgnoreCase));

            foreach (var btn in buttons)
            {
                var seat = btn.Tag as Seat;
                if (seat == null) continue;

                if (seat.IsReserved)
                {
                    btn.BackColor = Color.Black;
                    btn.Enabled = false;
                }
                else if (seat.IsSelected)
                {
                    btn.BackColor = Color.Green;
                    btn.Enabled = true;
                }
                else
                {
                    btn.BackColor = Color.LightGray;
                    btn.Enabled = true;
                }
            }
        }

        private void Seat_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var seat = btn.Tag as Seat;
            if (seat == null) return;

            if (seat.IsReserved)
            {
                MessageBox.Show($"Stoel {seat.Id} is al gereserveerd.");
                return;
            }

            seat.IsSelected = !seat.IsSelected;

            if (seat.IsSelected)
            {
                if (!_selectedSeats.Contains(seat.Id))
                    _selectedSeats.Add(seat.Id);
            }
            else
            {
                if (_selectedSeats.Contains(seat.Id))
                    _selectedSeats.Remove(seat.Id);
            }

            UpdateSeatColors();
        }

        public string[] GetSelectedSeatsArray()
        {
            return _selectedSeats.ToArray();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            var selectedSeats = GetSelectedSeatsArray();
            frmPayment paymentForm = new frmPayment(_User, _Filmname, selectedSeats);
            paymentForm.Show();
        }

    }
}