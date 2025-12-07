
using System;

namespace DiplomskiRad
{
    public class Rezervacija
    {
        public int Id { get; set; }

        public int KnjigaId { get; set; }
        public int KorisnikId { get; set; }
        public string NaslovKnjige { get; set; } 
        public string KorisnickoIme { get; set; } 

        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public string Status { get; set; }
        public bool Notifikovan { get; set; }
    }
}