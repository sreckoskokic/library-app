using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DiplomskiRad
{
    public partial class UredjivanjeKnjigaForm : Form
    {
        private int _selektovaniId = 0;

        public UredjivanjeKnjigaForm()
        {
            InitializeComponent();
        }

        private void UredjivanjeKnjigaForm_Load(object sender, EventArgs e)
        {
            dgvKnjigeEdit.ReadOnly = true;
            dgvKnjigeEdit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKnjigeEdit.MultiSelect = false;

            UcitajKnjige();
            OcistiPoljaZaUnos();
        }

        private void UcitajKnjige()
        {
            using (var db = new LiteDatabase(LiteDbHelper.DbPath))
            {
                var knjige = db.GetCollection<Knjiga>("knjige").FindAll().ToList();
                dgvKnjigeEdit.DataSource = knjige;
            }
        }

        private void OcistiPoljaZaUnos()
        {
            txtNaslov.Clear();
            txtAutor.Clear();
            txtZanr.Clear();
            txtGodinaIzdanja.Clear();
            txtKolicina.Clear();
            _selektovaniId = 0; 
            dgvKnjigeEdit.ClearSelection();
            txtNaslov.Focus();
        }

        private void dgvKnjigeEdit_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKnjigeEdit.SelectedRows.Count > 0)
            {
                var selektovanaKnjiga = (Knjiga)dgvKnjigeEdit.SelectedRows[0].DataBoundItem;
                txtNaslov.Text = selektovanaKnjiga.Naslov;
                txtAutor.Text = selektovanaKnjiga.Autor;
                txtZanr.Text = selektovanaKnjiga.Zanr;
                txtGodinaIzdanja.Text = selektovanaKnjiga.GodinaIzdanja.ToString();
                txtKolicina.Text = selektovanaKnjiga.Kolicina.ToString();

                _selektovaniId = selektovanaKnjiga.Id; 
            }
        }

        private void btnDodajNovi_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDodajNovi_Click_1(object sender, EventArgs e)
        {
            OcistiPoljaZaUnos();
        }

        private void btnSacuvaj_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaslov.Text) || !int.TryParse(txtGodinaIzdanja.Text, out int godina) || !int.TryParse(txtKolicina.Text, out int kolicina))
            {
                MessageBox.Show("Molimo popunite sva polja ispravno. Godina i količina moraju biti brojevi.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var knjiga = new Knjiga
            {
                Id = _selektovaniId,
                Naslov = txtNaslov.Text,
                Autor = txtAutor.Text,
                Zanr = txtZanr.Text,
                GodinaIzdanja = godina,
                Kolicina = kolicina
            };

            using (var db = new LiteDatabase(LiteDbHelper.DbPath))
            {
                var knjigeCollection = db.GetCollection<Knjiga>("knjige");

                if (knjiga.Id == 0) 
                {
                    knjigeCollection.Insert(knjiga);
                }
                else 
                {
                    knjigeCollection.Update(knjiga);
                }
            }

            MessageBox.Show("Podaci su uspešno sačuvani.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UcitajKnjige();
            OcistiPoljaZaUnos();
        }

        private void btnObrisi_Click_1(object sender, EventArgs e)
        {
            if (_selektovaniId == 0)
            {
                MessageBox.Show("Molimo prvo selektujte knjigu iz tabele koju želite da obrišete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var rezultat = MessageBox.Show($"Da li ste sigurni da želite da obrišete knjigu '{txtNaslov.Text}'?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (rezultat == DialogResult.Yes)
            {
                using (var db = new LiteDatabase(LiteDbHelper.DbPath))
                {
                    var knjigeCollection = db.GetCollection<Knjiga>("knjige");
                    knjigeCollection.Delete(_selektovaniId);
                }

                MessageBox.Show("Knjiga je uspešno obrisana.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UcitajKnjige();
                OcistiPoljaZaUnos();
            }
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