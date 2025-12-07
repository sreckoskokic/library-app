using LiteDB;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DiplomskiRad
{
    public partial class IstorijaRezervacijaForm : Form
    {
        public IstorijaRezervacijaForm()
        {
            InitializeComponent();
        }

        private void IstorijaRezervacijaForm_Load(object sender, EventArgs e)
        {
            UcitajIstoriju();
        }

        private void UcitajIstoriju()
        {
            try
            {
                using (var db = new LiteDatabase(LiteDbHelper.DbPath))
                {
                    var rezervacije = db.GetCollection<Rezervacija>("rezervacije");

                    var istorija = rezervacije.Find(r => r.Status != "Na cekanju").ToList();

                    dgvIstorija.DataSource = istorija;
                    this.dgvIstorija.Columns["Notifikovan"].HeaderText = "Obavešten";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške prilikom učitavanja istorije: " + ex.Message);
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

        private void dgvIstorija_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}