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
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Film.Kom
{
    public partial class frmProfielpagina : Form
    {
        readonly Passwords passwords = new Passwords();
        private readonly IMongoCollection<User> _Users;
        private readonly User? _LoggedInUser;
        public frmProfielpagina()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }
        internal frmProfielpagina(User user)
        {
            InitializeComponent();
            if (user == null)
            {
                MessageBox.Show($"Gebruiker niet gevonden.");
                return;
            }
            _LoggedInUser = user;

            var client = new MongoClient(passwords.Database);
            var db = client.GetDatabase("Vilm");
            _Users = db.GetCollection<User>("Users");

            var DBUser = _Users.Find(g => g.Naam == user.Naam).FirstOrDefault();

            lblUsernameDisplay.Text = user.Naam;
            // waarom ook display voor wachtwoord?
            lblPasswordDisplay.Text = DBUser.HashedPassword;
            lblEmailDisplay.Text = DBUser.Email;
            // is placeholder, totdat we ook echt DOB toevoegen aan de db
            lblDateOfBirthDisplay.Text = $"{DBUser.Geboortedatum}";
            lblActiveSinceDisplay.Text = $"{DBUser.RegisteredAt}";
        }
    }
}
