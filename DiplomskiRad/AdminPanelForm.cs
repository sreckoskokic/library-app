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
    public partial class AdminPanelForm : Form
    {
        public AdminPanelForm()
        {
            InitializeComponent();
            this.dgvRezervacije.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void AdminPanelForm_Load(object sender, EventArgs e)
        {
            UcitajRezervacije();
        }
        private void UcitajRezervacije()
        {
            using (var db = new LiteDatabase(LiteDbHelper.DbPath))
            {
                var rezervacije = db.GetCollection<Rezervacija>("rezervacije")
                                    .Find(r => r.Status == "Na cekanju")
                                    .ToList();
                dgvRezervacije.DataSource = rezervacije;
            }
        }

        private void btnOdobri_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOdbij_Click(object sender, EventArgs e)
        {
           
        }

        private void PromeniStatusRezervacije(string noviStatus)
        {
            if (dgvRezervacije.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo odaberite rezervaciju.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selektovanaRezervacija = (Rezervacija)dgvRezervacije.SelectedRows[0].DataBoundItem;

            try
            {
                using (var db = new LiteDB.LiteDatabase(LiteDbHelper.DbPath))
                {
                    var knjigeCollection = db.GetCollection<Knjiga>("knjige");
                    var rezervacije = db.GetCollection<Rezervacija>("rezervacije");


                    var knjiga = knjigeCollection.FindById(selektovanaRezervacija.KnjigaId);

                    if (knjiga != null)
                    {
                        if (noviStatus == "Odobreno")
                        {
                            knjiga.Kolicina -= 1;
                        }
                        else if (noviStatus == "Odbijeno")
                        {
                          
                        }

                        knjigeCollection.Update(knjiga);
                    }

                    selektovanaRezervacija.Status = noviStatus;
                    rezervacije.Update(selektovanaRezervacija);
                }

                MessageBox.Show("Status rezervacije je uspešno promenjen.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UcitajRezervacije(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOdobri_Click_1(object sender, EventArgs e)
        {
            PromeniStatusRezervacije("Odobreno");
        }

        private void btnOdbij_Click_1(object sender, EventArgs e)
        {
            PromeniStatusRezervacije("Odbijeno");
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
            
        }

        private void btnIstorijaRezervacija_Click(object sender, EventArgs e)
        {
            IstorijaRezervacijaForm forma = new IstorijaRezervacijaForm();
            forma.ShowDialog();
        }
    }
}
