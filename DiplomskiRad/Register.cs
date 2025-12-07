using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;

namespace DiplomskiRad
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrujSe_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegistrujSe_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text) ||
                string.IsNullOrWhiteSpace(txtLozinka.Text) ||
                string.IsNullOrWhiteSpace(txtPotvrdiLozinku.Text) ||
                string.IsNullOrWhiteSpace(txtIme.Text) ||
                string.IsNullOrWhiteSpace(txtPrezime.Text) ||
                string.IsNullOrWhiteSpace(txtAdresa.Text) ||
                string.IsNullOrWhiteSpace(txtBrojTelefona.Text))
            {
                MessageBox.Show("Sva polja moraju biti popunjena.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            if (txtLozinka.Text != txtPotvrdiLozinku.Text)
            {
                MessageBox.Show("Lozinke se ne poklapaju.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            try
            {
                using (var db = new LiteDB.LiteDatabase(LiteDbHelper.DbPath))
                {
                    var korisniciCollection = db.GetCollection<Korisnik>("korisnici");

                    bool korisnikPostoji = korisniciCollection.Exists(k => k.KorisnickoIme == txtKorisnickoIme.Text);

                    if (korisnikPostoji)
                    {
                        MessageBox.Show("Korisničko ime '" + txtKorisnickoIme.Text + "' već postoji. Molimo izaberite drugo.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return; 
                    }

                    var noviKorisnik = new Korisnik
                    {
                        KorisnickoIme = txtKorisnickoIme.Text.ToLower(),
                        LozinkaHash = LiteDbHelper.HashPassword(txtLozinka.Text).ToLower(),

                        Ime = txtIme.Text.ToLower(),
                        Prezime = txtPrezime.Text.ToLower(),
                        Adresa = txtAdresa.Text.ToLower(),
                        BrojTelefona = txtBrojTelefona.Text.ToLower(),

                        Uloga = "Korisnik"
                    };

                    korisniciCollection.Insert(noviKorisnik);

                    korisniciCollection.EnsureIndex(k => k.KorisnickoIme, true);
                }

                MessageBox.Show("Registracija uspešna! Sada se možete prijaviti.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do neočekivane greške pri upisu u bazu: " + ex.Message, "Kritična Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtAdresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
