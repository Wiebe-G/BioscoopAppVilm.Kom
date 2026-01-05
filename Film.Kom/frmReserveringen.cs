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
        // Design door Avsar en Rick, functionaliteit door Furkan en Wiebe
        private User _User;
        private readonly string _Filmname;
        private readonly IMongoCollection<FilmInfo> _Films;
        private readonly IMongoCollection<ReserveringenInfo> _Reserveringen;
        Passwords passwords = new();
        private readonly List<Seat> _allSeats = new();
        private readonly List<string> _selectedSeats = new();
        private bool _seatsInitialized = false;

        public class Seat
        {
            public string Id { get; set; }
            public bool IsReserved { get; set; }
            public bool IsSelected { get; set; }
        }
        public frmStoelen_reservation(User user, string FilmName)
        {
            InitializeComponent();
            _User = user;
            _Filmname = FilmName.Trim().ToLower();

            var client = new MongoClient(passwords.Database);
            var db = client.GetDatabase("Vilm");
            _Films = db.GetCollection<FilmInfo>("Films");
            _Reserveringen = db.GetCollection<ReserveringenInfo>("Reserveringen");
        }

        private async void frmStoelen_reservation_Load(object sender, EventArgs e)
        {
            var MovieData = await new SearchForFilmsInDB().SearchFunction(_Filmname);
            lblTopTitle.Text = MovieData.Title;
            lblTitel.Text = MovieData.Title;
            lblZaal.Text = MovieData.Zaal;
            lblSpeelduur.Text = MovieData.Runtime;
            lblBegintijd.Text = MovieData.Speeltijd;
            lblEindtijd.Text = "Reken het zelf maar uit";
            picPoster.Load(MovieData.Poster);

            await FetchReserveringenFromDatabase(MovieData.Title.ToLower());
        }

        private async Task FetchReserveringenFromDatabase(string FilmNameInLowercase)
        {
            var FilterForReserveringen = Builders<ReserveringenInfo>.Filter.Eq(r => r.ReserveringTitle, FilmNameInLowercase);
            var AllFilmsWithReservedSeats = _Reserveringen.Find(FilterForReserveringen).ToList();

            LoadReseveringen(AllFilmsWithReservedSeats);
        }

        private void LoadReseveringen(List<ReserveringenInfo> AllReserveringenForThisMovie)
        {
            // TODO:
            // Fix deze onzin die niet werkt
            // Update 05/01/2026: Het werkt nu half. Bedankt furkanGPT5 voor het maken van de rest van deze pagina
            var AllSeats = GetAllButtons(tblStoelen).ToList();
            foreach (var Reservering in AllReserveringenForThisMovie)
            {
                foreach (var Stoel in Reservering.Stoelen)
                {
                    var SeatName = $"btnStoel{Stoel}";

                    var Seat = AllSeats.FirstOrDefault(s => s.Name == SeatName);

                    if (Seat != null)
                    {
                        Seat.BackColor = Color.Red;
                        Seat.Click += (sender, e) =>
                        {
                            MessageBox.Show($"Stoel {Seat.Name} is al gereserveerd.");
                            return;
                        };
                    }
                }
            }
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