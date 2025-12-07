using System;

namespace DiplomskiRad
{
    public class Komentar
    {
        public int Id { get; set; }

        public int KnjigaId { get; set; }

        public string KorisnickoIme { get; set; } 
        public string TekstKomentara { get; set; }
        public DateTime DatumPostavljanja { get; set; }
        public int Ocena { get; set; }
    }
}