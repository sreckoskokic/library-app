using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;

namespace DiplomskiRad
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPrijaviSe_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text) || string.IsNullOrWhiteSpace(txtLozinka.Text))
            {
                MessageBox.Show("Unesite i korisničko ime i lozinku.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Korisnik pronadjeniKorisnik;
                string hesovanaLozinka = LiteDbHelper.HashPassword(txtLozinka.Text);

                using (var db = new LiteDB.LiteDatabase(LiteDbHelper.DbPath))
                {
                    var korisniciCollection = db.GetCollection<Korisnik>("korisnici");
                    pronadjeniKorisnik = korisniciCollection.FindOne(k => k.KorisnickoIme == txtKorisnickoIme.Text && k.LozinkaHash == hesovanaLozinka);
                }

                if (pronadjeniKorisnik != null)
                {
                    MessageBox.Show("Prijava uspešna! Dobrodošli.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    using (var db = new LiteDB.LiteDatabase(LiteDbHelper.DbPath))
                    {
                        var rezervacijeCollection = db.GetCollection<Rezervacija>("rezervacije");

                        var rezervacijeZaNotifikaciju = rezervacijeCollection.Find(r =>
                            r.KorisnikId == pronadjeniKorisnik.Id && 
                            r.Status != "Na cekanju" &&              
                            r.Notifikovan == false).ToList();        

                        if (rezervacijeZaNotifikaciju.Any()) 
                        {
                            var sb = new System.Text.StringBuilder();
                            sb.AppendLine("Stigle su nove odluke o vašim rezervacijama:\n");

                            foreach (var rez in rezervacijeZaNotifikaciju)
                            {
                                sb.AppendLine($"- Knjiga: '{rez.NaslovKnjige}' -> Status: {rez.Status}");
                                rez.Notifikovan = true; 
                            }

                            MessageBox.Show(sb.ToString(), "Obaveštenja o Rezervacijama", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            rezervacijeCollection.Update(rezervacijeZaNotifikaciju);
                        }
                    }

                    if (pronadjeniKorisnik.Uloga == "Admin")
                    {
                        bool imaNovihZahteva = false;
                        using (var db = new LiteDB.LiteDatabase(LiteDbHelper.DbPath))
                        {
                            var rezervacije = db.GetCollection<Rezervacija>("rezervacije");
                            imaNovihZahteva = rezervacije.Exists(r => r.Status == "Na cekanju");
                        }

                        if (imaNovihZahteva)
                        {
                            var rezultat = MessageBox.Show(
                                "Imate novih zahteva za rezervaciju knjiga. Da li želite da ih sada pregledate?",
                                "Novi Zahtevi",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

                            if (rezultat == DialogResult.Yes)
                            {
                                AdminPanelForm adminPanel = new AdminPanelForm();
                                adminPanel.ShowDialog();
                            }
                        }
                    }

                    this.Hide();
                    GlavnaForma glavnaForma = new GlavnaForma(pronadjeniKorisnik);
                    glavnaForma.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Pogrešno korisničko ime ili lozinka.", "Neuspešna prijava", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do neočekivane greške pri čitanju iz baze: " + ex.Message, "Kritična Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistracija_Click_1(object sender, EventArgs e)
        {

            Register registerForm = new Register();
            registerForm.ShowDialog();
            this.txtKorisnickoIme.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtKorisnickoIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }
    }
    
    
}
