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
using BC = BCrypt.Net.BCrypt;

namespace Film.Kom
{
    public partial class frmProfielpagina : Form
    {
        // Design door Avsar, functionaliteit door Wiebe en Furkan
        readonly Passwords passwords = new();
        private readonly IMongoCollection<User> _Users;
        private readonly User? _LoggedInUser;

        internal frmProfielpagina(User user)
        {
            InitializeComponent();
            // Controleer of de gebruiker wel bestaat.
            if (user == null)
            {
                MessageBox.Show($"Gebruiker niet gevonden.");
                return;
            }
            // Sla de ingelogde gebruiker op
            _LoggedInUser = user;

            // verbindt met de database en haalt de gebruikerscollectie op
            var client = new MongoClient(passwords.Database);
            var db = client.GetDatabase("Vilm");
            _Users = db.GetCollection<User>("Users");

            // Haal de volledige gebruikersgegevens op uit de database
            var DBUser = _Users.Find(g => g.Naam == user.Naam).FirstOrDefault();

            // Als de gebruiker geen admin is verberg de admin button
            if (DBUser != null && DBUser.Rol == 0)
            {
                btnAdmin.Enabled = false;
                btnAdmin.Visible = false;
            }

            // Vul de labels met gebruikersinformatie het is gehasd en wachtwoord wordt niet getoond
            lblUsernameDisplay.Text = user.Naam;
            lblPasswordDisplay.Text = DBUser?.HashedPassword ?? "(onbekend)";
            lblEmailDisplay.Text = DBUser?.Email ?? "(onbekend)";
            lblDateOfBirthDisplay.Text = DBUser != null ? $"{DBUser.Geboortedatum:yyyy-MM-dd}" : "(geen geboortedatum)";
            lblActiveSinceDisplay.Text = DBUser != null ? $"{DBUser.RegisteredAt:yyyy-MM-dd}" : "(onbekend)";

            // Koppel de knoppen aan hun functionaliteit
            btnChangeusername.Click += btnChangeusername_Click;
            btnChangepassword.Click += btnChangepassword_Click;
            btnChangemail.Click += btnChangemail_Click;
            btnDeleteaccount.Click += btnDeleteaccount_Click;

            // klik op label snelbewerking
            lblUsernameDisplay.Click += lblUsernameDisplay_Click;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (_LoggedInUser == null)
            {
                MessageBox.Show("Geen gebruiker gevonden");
                return;
            }
            frmAdmin AdminPanel = new(_LoggedInUser);
            AdminPanel.Show();
        }

        private async void btnChangeusername_Click(object? sender, EventArgs e)
        {
            // Wijzig de gebruikersnaam
            if (_LoggedInUser == null) return;

            // Nieuwe gebruikersnaam ophalen en valideren
            var newName = txtUsername?.Text?.Trim();
            if (string.IsNullOrWhiteSpace(newName))
            {
                MessageBox.Show("Voer een geldige gebruikersnaam in.");
                return;
            }

            // Controleer of de nieuwe gebruikersnaam al bestaat
            var exists = await _Users.Find(u => u.Naam == newName).FirstOrDefaultAsync();
            if (exists != null)
            {
                MessageBox.Show("Deze gebruikersnaam is al in gebruik.");
                return;
            }

            // Update de gebruikersnaam in de database
            var filter = Builders<User>.Filter.Eq(u => u.Naam, _LoggedInUser.Naam);
            var update = Builders<User>.Update.Set(u => u.Naam, newName);

            // Voer de update uit
            var result = await _Users.UpdateOneAsync(filter, update);
            if (result.ModifiedCount > 0)
            {
                // Update de lokale gebruikersnaam en alleen het display-label
                _LoggedInUser.Naam = newName;
                lblUsernameDisplay.Text = newName; // Update het display-veld op de profielpagina

                // Update eventuele open forms die exact dezelfde display-controlnaam gebruiken
                UpdateOpenFormsControlText("lblUsernameDisplay", newName);

                MessageBox.Show("Gebruikersnaam succesvol gewijzigd.");
                txtUsername.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Gebruikersnaam kon niet worden gewijzigd. Probeer opnieuw.");
            }
        }

        private async void btnChangepassword_Click(object? sender, EventArgs e)
        {
            // Wijzig het wachtwoord
            if (_LoggedInUser == null) return;

            // Nieuwe wachtwoord ophalen en valideren
            var newPassword = txtPassword?.Text ?? string.Empty;
            if (string.IsNullOrWhiteSpace(newPassword) || newPassword.Length < 8)
            {
                MessageBox.Show("Voer een geldig wachtwoord (minimaal 8 tekens) in.");
                return;
            }

            string hash = BC.HashPassword(newPassword, workFactor: 12);

            // Update het wachtwoord in de database
            var filter = Builders<User>.Filter.Eq(u => u.Naam, _LoggedInUser.Naam);
            var update = Builders<User>.Update.Set(u => u.HashedPassword, hash);

            // Voer de update uit
            var result = await _Users.UpdateOneAsync(filter, update);
            if (result.ModifiedCount > 0)
            {
                // Update het lokale wachtwoord
                MessageBox.Show("Wachtwoord succesvol bijgewerkt.");
                txtPassword.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Wachtwoord kon niet worden bijgewerkt. Probeer opnieuw.");
            }
        }


        private async void btnChangemail_Click(object? sender, EventArgs e)
        {
            // Wijzig het e-mailadres
            if (_LoggedInUser == null) return;

            // Nieuwe e-mail ophalen en valideren
            var newEmail = txtChangemail?.Text?.Trim();
            if (string.IsNullOrWhiteSpace(newEmail) || !newEmail.Contains("@"))
            {
                MessageBox.Show("Voer een geldig e-mailadres in.");
                return;
            }

            // Update het e-mailadres in de database
            var filter = Builders<User>.Filter.Eq(u => u.Naam, _LoggedInUser.Naam);
            var update = Builders<User>.Update.Set(u => u.Email, newEmail);

            // Voer de update uit
            var result = await _Users.UpdateOneAsync(filter, update);

            if (result.ModifiedCount > 0)
            {
                // Update het lokale e-mailadres en het label
                _LoggedInUser.Email = newEmail;
                lblEmailDisplay.Text = newEmail;

                // Update eventuele open forms die een control hebben met name "lblEmailDisplay"
                UpdateOpenFormsControlText("lblEmailDisplay", newEmail);

                MessageBox.Show("E-mail succesvol gewijzigd.");
                txtChangemail.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("E-mail kon niet worden gewijzigd. Probeer opnieuw.");
            }
        }

        // Verwijder het account van de gebruiker
        private async void btnDeleteaccount_Click(object? sender, EventArgs e)
        {
            if (_LoggedInUser == null) return;

            // Bevestig de verwijdering
            var confirm = MessageBox.Show("Weet je zeker dat je je account wilt verwijderen? Dit is permanent.", "Verwijder account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;
            // Verwijder de gebruiker uit de database
            var filter = Builders<User>.Filter.Eq(u => u.Naam, _LoggedInUser.Naam);
            var result = await _Users.DeleteOneAsync(filter);
            if (result.DeletedCount > 0)
            {
                MessageBox.Show("Account verwijderd.");
                this.Close();
            }
        }

        private void lblUsernameDisplay_Click(object sender, EventArgs e)
        {
            // klik op label om gebruikersnaam te wijzigen
            if (_LoggedInUser == null) return;

            txtUsername.Text = lblUsernameDisplay.Text ?? string.Empty;
            txtUsername.Focus();
            txtUsername.SelectAll();

            var tt = new ToolTip();
            tt.Show("Wijzig de gebruikersnaam in het veld en klik op 'Wijzig'.", txtUsername, 3000);
        }

        // Update controls in open forms
        private void UpdateOpenFormsControlText(string controlName, string text)
        {
            foreach (Form open in Application.OpenForms)
            {
                try
                {
                    // Zoek de control recursief
                    var ctl = FindControlRecursive(open, controlName);
                    if (ctl is Label lbl)
                    {
                        lbl.Text = text;
                    }
                    else if (ctl is TextBox tb)
                    {
                        tb.Text = text;
                    }
                }
                catch
                {
                    // negeer fouten bij het bijwerken van forms
                }
            }
        }

        // Recursieve methode om een control te vinden in een form
        private Control? FindControlRecursive(Control parent, string name)
        {
            // Basisgeval
            if (parent == null) return null;
            // Controleer of de huidige control de gezochte is
            if (parent.Name == name) return parent;
            foreach (Control c in parent.Controls)
            {
                // Recursieve aanroep
                var found = FindControlRecursive(c, name);
                if (found != null) return found;
            }
            return null;
        }

        private void BtnUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text)) return;
            if (e.KeyCode == Keys.Enter)
            {
                btnChangeusername.PerformClick();
            }
        }
        private void BtnPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text)) return;
            if (e.KeyCode == Keys.Enter)
            {
                btnChangepassword.PerformClick();
            }
        }
        private void BtnEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtChangemail.Text)) return;
            if (e.KeyCode == Keys.Enter)
            {
                btnChangemail.PerformClick();
            }
        }
    }
}