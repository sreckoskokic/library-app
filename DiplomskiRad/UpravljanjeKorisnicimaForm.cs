using LiteDB;
using Microsoft.VisualBasic; 
using System;
using System.Linq;
using System.Windows.Forms;

namespace DiplomskiRad
{
    public partial class UpravljanjeKorisnicimaForm : Form
    {
        private int _selektovaniId = 0;

        public UpravljanjeKorisnicimaForm()
        {
            InitializeComponent();
        }

        private void UpravljanjeKorisnicimaForm_Load(object sender, EventArgs e)
        {
            dgvKorisnici.ReadOnly = true;
            dgvKorisnici.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKorisnici.MultiSelect = false;
            UcitajKorisnike();
            OcistiPolja();
        }

        private void UcitajKorisnike()
        {
            using (var db = new LiteDatabase(LiteDbHelper.DbPath))
            {
                var korisnici = db.GetCollection<Korisnik>("korisnici").FindAll().ToList();
                dgvKorisnici.DataSource = korisnici;

                if (dgvKorisnici.Columns.Contains("LozinkaHash"))
                {
                    dgvKorisnici.Columns["LozinkaHash"].Visible = false;
                }
            }
        }

        private void OcistiPolja()
        {
            txtKorisnickoIme.Clear();
            txtLozinka.Clear();
            txtIme.Clear();
            txtPrezime.Clear();
            txtAdresa.Clear();
            txtBrojTelefona.Clear();
            cmbUloga.SelectedItem = "Korisnik";
            txtLozinka.Enabled = true;
            _selektovaniId = 0;
            dgvKorisnici.ClearSelection();
            txtKorisnickoIme.Focus();
        }

        private void dgvKorisnici_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKorisnici.SelectedRows.Count > 0)
            {
                var selektovaniKorisnik = (Korisnik)dgvKorisnici.SelectedRows[0].DataBoundItem;
                _selektovaniId = selektovaniKorisnik.Id;

                txtKorisnickoIme.Text = selektovaniKorisnik.KorisnickoIme;
                txtIme.Text = selektovaniKorisnik.Ime;
                txtPrezime.Text = selektovaniKorisnik.Prezime;
                txtAdresa.Text = selektovaniKorisnik.Adresa;
                txtBrojTelefona.Text = selektovaniKorisnik.BrojTelefona;
                cmbUloga.SelectedItem = selektovaniKorisnik.Uloga;

                txtLozinka.Clear();
                txtLozinka.Enabled = false; 
            }
        }

        private void btnPripremiZaDodavanje_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            
        }

        private void btnResetujLozinku_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPripremiZaDodavanje_Click_1(object sender, EventArgs e)
        {
            OcistiPolja();
        }

        private void btnSacuvaj_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text) ||
                string.IsNullOrWhiteSpace(txtIme.Text) ||
                string.IsNullOrWhiteSpace(txtPrezime.Text) ||
                cmbUloga.SelectedItem == null)
            {
                MessageBox.Show("Korisničko ime, Ime, Prezime i Uloga su obavezna polja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new LiteDatabase(LiteDbHelper.DbPath))
            {
                var korisnici = db.GetCollection<Korisnik>("korisnici");

                if (korisnici.Exists(k => k.KorisnickoIme == txtKorisnickoIme.Text && k.Id != _selektovaniId))
                {
                    MessageBox.Show("Korisničko ime već postoji. Molimo izaberite drugo.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Korisnik korisnik;
                if (_selektovaniId == 0) 
                {
                    if (string.IsNullOrWhiteSpace(txtLozinka.Text))
                    {
                        MessageBox.Show("Lozinka je obavezna za nove korisnike.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    korisnik = new Korisnik();
                    korisnik.LozinkaHash = LiteDbHelper.HashPassword(txtLozinka.Text);
                }
                else 
                {
                    korisnik = korisnici.FindById(_selektovaniId);
                }

                korisnik.KorisnickoIme = txtKorisnickoIme.Text;
                korisnik.Ime = txtIme.Text;
                korisnik.Prezime = txtPrezime.Text;
                korisnik.Adresa = txtAdresa.Text;
                korisnik.BrojTelefona = txtBrojTelefona.Text;
                korisnik.Uloga = cmbUloga.SelectedItem.ToString();

                korisnici.Upsert(korisnik); 
            }

            MessageBox.Show("Podaci o korisniku su uspešno sačuvani.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UcitajKorisnike();
            OcistiPolja();
        }

        private void btnObrisi_Click_1(object sender, EventArgs e)
        {
            if (_selektovaniId == 0)
            {
                MessageBox.Show("Molimo prvo selektujte korisnika iz tabele.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show($"Da li ste sigurni da želite da obrišete korisnika '{txtKorisnickoIme.Text}'?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (var db = new LiteDatabase(LiteDbHelper.DbPath))
                {
                    db.GetCollection<Korisnik>("korisnici").Delete(_selektovaniId);
                }
                MessageBox.Show("Korisnik je obrisan.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UcitajKorisnike();
                OcistiPolja();
            }
        }

        private void btnResetujLozinku_Click_1(object sender, EventArgs e)
        {
            if (_selektovaniId == 0)
            {
                MessageBox.Show("Molimo prvo selektujte korisnika iz tabele.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string novaLozinka = Interaction.InputBox("Unesite novu lozinku za korisnika '" + txtKorisnickoIme.Text + "':", "Resetovanje Lozinke", "");

            if (!string.IsNullOrWhiteSpace(novaLozinka))
            {
                using (var db = new LiteDatabase(LiteDbHelper.DbPath))
                {
                    var korisnici = db.GetCollection<Korisnik>("korisnici");
                    var korisnik = korisnici.FindById(_selektovaniId);
                    korisnik.LozinkaHash = LiteDbHelper.HashPassword(novaLozinka);
                    korisnici.Update(korisnik);
                }
                MessageBox.Show("Lozinka je uspešno resetovana.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Ime_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}