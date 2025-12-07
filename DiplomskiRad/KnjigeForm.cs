
using LiteDB;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DiplomskiRad
{
    public partial class KnjigeForm : Form
    {
        private Korisnik trenutniKorisnik;

        public KnjigeForm(Korisnik korisnik)
        {
            InitializeComponent();
            this.trenutniKorisnik = korisnik;
        }

        private void KnjigeForm_Load(object sender, EventArgs e)
        {
            dtpDatumOd.Value = DateTime.Today;
            dtpDatumDo.Value = DateTime.Today.AddDays(7);

            UcitajKnjige();
            if (this.trenutniKorisnik != null && this.trenutniKorisnik.Uloga == "Admin")
            {
               
                btnUrediKnjige.Visible = true;
            }
        }

        private void UcitajKnjige()
        {
            try
            {
                using (var db = new LiteDatabase(LiteDbHelper.DbPath))
                {
                    var knjigeCollection = db.GetCollection<Knjiga>("knjige");
                    var sveKnjige = knjigeCollection.FindAll().ToList();

                    dgvKnjige.DataSource = sveKnjige;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doslo je do greške prilikom citanja knjiga: " + ex.Message);
            }
        }

        private void btnRezervisi_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRezervisi_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvKnjige.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Molimo odaberite knjigu iz tabele.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (dtpDatumDo.Value.Date < dtpDatumOd.Value.Date)
                {
                    MessageBox.Show("Datum 'do' ne može biti pre datuma 'od'.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Knjiga selektovanaKnjiga = (Knjiga)dgvKnjige.SelectedRows[0].DataBoundItem;

                if (selektovanaKnjiga.Kolicina <= 0)
                {
                    MessageBox.Show(
                        $"Žao nam je, svi primerci knjige '{selektovanaKnjiga.Naslov}' su trenutno izdati.",
                        "Knjiga nije dostupna",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                var novaRezervacija = new Rezervacija
                {
                    KnjigaId = selektovanaKnjiga.Id,
                    NaslovKnjige = selektovanaKnjiga.Naslov,
                    KorisnikId = this.trenutniKorisnik.Id,
                    KorisnickoIme = this.trenutniKorisnik.KorisnickoIme,
                    DatumOd = dtpDatumOd.Value.Date,
                    DatumDo = dtpDatumDo.Value.Date,
                    Status = "Na cekanju"
                };

                using (var db = new LiteDB.LiteDatabase(LiteDbHelper.DbPath))
                {
                    var rezervacije = db.GetCollection<Rezervacija>("rezervacije");
                    rezervacije.Insert(novaRezervacija);
                }

                MessageBox.Show("Vaš zahtev za rezervaciju knjige '" + selektovanaKnjiga.Naslov + "' je poslat na odobrenje.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do neočekivane greške: " + ex.Message, "Kritična Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrikaziKomentare_Click(object sender, EventArgs e)
        {
            if (dgvKnjige.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo prvo odaberite knjigu iz tabele.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selektovanaKnjiga = (Knjiga)dgvKnjige.SelectedRows[0].DataBoundItem;

            KomentariForm forma = new KomentariForm(selektovanaKnjiga, this.trenutniKorisnik);
            forma.ShowDialog();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUrediKnjige_Click(object sender, EventArgs e)
        {
            UredjivanjeKnjigaForm forma = new UredjivanjeKnjigaForm();
            forma.ShowDialog();

            UcitajKnjige();
        }

        private void dgvKnjige_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}