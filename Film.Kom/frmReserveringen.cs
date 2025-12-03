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
    public partial class frmStoelen_reservation : Form
    {
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
            // zorg ervoor dat dit het ook echt berekent en niet gewoon de string er neer zet 
            lblEindtijd.Text = MovieData.Speeltijd + MovieData.Runtime;
            picPoster.Load(MovieData.Poster);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            frmPayment paymentForm = new frmPayment(_User, _Filmname);
            paymentForm.Show();
        }
    }
}
