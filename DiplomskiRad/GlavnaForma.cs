using System;
using System.Windows.Forms;

namespace DiplomskiRad
{
    public partial class GlavnaForma : Form
    {
        public Korisnik PrijavljeniKorisnik { get; private set; }

        public GlavnaForma(Korisnik korisnik)
        {
            InitializeComponent();

            this.PrijavljeniKorisnik = korisnik;

            PostaviPorukuDobrodoslice();
            PodesiVidljivostKontrola();
        }

        private void PostaviPorukuDobrodoslice()
        {
            if (PrijavljeniKorisnik != null)
            {
                lblDobrodoslica.Text = "Dobrodošli, " + PrijavljeniKorisnik.Ime + " " + PrijavljeniKorisnik.Prezime + "!";
            }
        }

        private void PodesiVidljivostKontrola()
        {
            if (PrijavljeniKorisnik != null && PrijavljeniKorisnik.Uloga == "Admin")
            {
                btnAdminPanel.Visible = true;
                btnUpravljanjeKorisnicima.Visible = true;
            }
        }

        private void btnPrikaziKnjige_Click(object sender, EventArgs e)
        {
            KnjigeForm formaZaKnjige = new KnjigeForm(this.PrijavljeniKorisnik);
            formaZaKnjige.ShowDialog();
        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            AdminPanelForm formaAdminPanel = new AdminPanelForm();
            formaAdminPanel.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KnjigeForm forma = new KnjigeForm(this.PrijavljeniKorisnik);
            forma.ShowDialog();
        }

        private void btnAdminPanel_Click_1(object sender, EventArgs e)
        {
            AdminPanelForm forma = new AdminPanelForm();
            forma.ShowDialog();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIstorijaRezervacija_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpravljanjeKorisnicima_Click(object sender, EventArgs e)
        {
            UpravljanjeKorisnicimaForm forma = new UpravljanjeKorisnicimaForm();
            forma.ShowDialog();
        }
    }
}