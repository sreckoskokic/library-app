
namespace DiplomskiRad
{
    public class Knjiga
    {
        public int Id { get; set; }
        public string Naslov { get; set; }
        public string Autor { get; set; }
        public string Zanr { get; set; }
        public int GodinaIzdanja { get; set; }
        public int Kolicina { get; set; }
    }
}