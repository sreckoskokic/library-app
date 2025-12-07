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
    public partial class KomentariForm : Form
    {
        private Knjiga _selektovanaKnjiga;
        private Korisnik _trenutniKorisnik;

        public KomentariForm(Knjiga selektovanaKnjiga, Korisnik trenutniKorisnik)
        {
            InitializeComponent();
            _selektovanaKnjiga = selektovanaKnjiga;
            _trenutniKorisnik = trenutniKorisnik;
        }


        private void KomentariForm_Load(object sender, EventArgs e)
        {
            {
                this.Text = "Komentari i Ocene za: " + _selektovanaKnjiga.Naslov;

                // Postavljamo podrazumevanu vrednost za ocenu na 5
                cmbOcena.SelectedIndex = 4; // Indeksi idu od 0, tako da je 4 zapravo peta stavka (broj 5)

                UcitajKomentare();
            }
        }
        private void UcitajKomentare()
        {
            lbxKomentari.Items.Clear();
            using (var db = new LiteDatabase(LiteDbHelper.DbPath))
            {
                var komentari = db.GetCollection<Komentar>("komentari");
                var komentariZaKnjigu = komentari.Find(k => k.KnjigaId == _selektovanaKnjiga.Id).ToList();

                foreach (var komentar in komentariZaKnjigu)
                {
                    // Kreiramo string sa zvezdicama na osnovu ocene
                    string zvezdice = new string('★', komentar.Ocena) + new string('☆', 5 - komentar.Ocena);

                    // Formatiramo prikaz komentara da uključuje i ocenu
                    string formatiranKomentar = $"[{komentar.DatumPostavljanja.ToShortDateString()}] {zvezdice} ({komentar.KorisnickoIme}): {komentar.TekstKomentara}";
                    lbxKomentari.Items.Add(formatiranKomentar);
                }
            } 
        }

        private void btnPostaviKomentar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPostaviKomentar_Click_1(object sender, EventArgs e)
        {
            // Provera da li je ocena odabrana
            if (cmbOcena.SelectedItem == null)
            {
                MessageBox.Show("Molimo odaberite ocenu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNoviKomentar.Text))
            {
                MessageBox.Show("Polje za komentar ne može biti prazno.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var noviKomentar = new Komentar
            {
                KnjigaId = _selektovanaKnjiga.Id,
                KorisnickoIme = _trenutniKorisnik.KorisnickoIme,
                TekstKomentara = txtNoviKomentar.Text,
                DatumPostavljanja = DateTime.Now,
                // Čitamo vrednost iz ComboBox-a i pretvaramo je u broj
                Ocena = int.Parse(cmbOcena.SelectedItem.ToString())
            };

            using (var db = new LiteDatabase(LiteDbHelper.DbPath))
            {
                var komentari = db.GetCollection<Komentar>("komentari");
                komentari.Insert(noviKomentar);
            }

            MessageBox.Show("Vaš komentar i ocena su uspešno sačuvani.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNoviKomentar.Clear();
            cmbOcena.SelectedIndex = 4; // Vraćamo na podrazumevanu vrednost 5
            UcitajKomentare();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

