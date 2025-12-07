
using LiteDB; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DiplomskiRad
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            UbaciPocetneKnjige(); 

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

        static void UbaciPocetneKnjige()
        {


            using (var db = new LiteDB.LiteDatabase(LiteDbHelper.DbPath))
            {
                var knjigeCollection = db.GetCollection<Knjiga>("knjige");

                if (knjigeCollection.Count() == 0)
                {
                    var knjige = new System.Collections.Generic.List<Knjiga>
            {
                new Knjiga { Naslov = "Na Drini cuprija", Autor = "Ivo Andric", Zanr = "Istorijski roman", GodinaIzdanja = 1945, Kolicina = 5 },
                new Knjiga { Naslov = "Gospodar prstenova", Autor = "J.R.R. Tolkien", Zanr = "Fantastika", GodinaIzdanja = 1954, Kolicina = 10 },
                new Knjiga { Naslov = "Hari Poter i Kamen mudrosti", Autor = "J.K. Rowling", Zanr = "Fantastika", GodinaIzdanja = 1997, Kolicina = 12 },
                new Knjiga { Naslov = "Zlocin i kazna", Autor = "Fjodor Dostojevski", Zanr = "Klasik", GodinaIzdanja = 1866, Kolicina = 7 },
                new Knjiga { Naslov = "Autostoperski vodic kroz galaksiju", Autor = "Douglas Adams", Zanr = "Naucna fantastika", GodinaIzdanja = 1979, Kolicina = 8 },
                new Knjiga { Naslov = "1984", Autor = "George Orwell", Zanr = "Distopija", GodinaIzdanja = 1949, Kolicina = 6 },
                new Knjiga { Naslov = "Besnilo", Autor = "Borislav Pekic", Zanr = "Triler", GodinaIzdanja = 1983, Kolicina = 4 },
                new Knjiga { Naslov = "Mali Princ", Autor = "Antoine de Saint-Exupéry", Zanr = "Dečija književnost", GodinaIzdanja = 1943, Kolicina = 15 },
                new Knjiga { Naslov = "Lovac u zitu", Autor = "J.D. Salinger", Zanr = "Klasik", GodinaIzdanja = 1951, Kolicina = 5 },
                new Knjiga { Naslov = "Stepski vuk", Autor = "Hermann Hesse", Zanr = "Filozofski roman", GodinaIzdanja = 1927, Kolicina = 3 },
                new Knjiga { Naslov = "Derviš i smrt", Autor = "Meša Selimović", Zanr = "Psihološki roman", GodinaIzdanja = 1966, Kolicina = 6 },
                new Knjiga { Naslov = "Hazarski rečnik", Autor = "Milorad Pavić", Zanr = "Postmoderna", GodinaIzdanja = 1984, Kolicina = 3 },
                new Knjiga { Naslov = "Prokleta avlija", Autor = "Ivo Andrić", Zanr = "Pripovetka", GodinaIzdanja = 1954, Kolicina = 7 },
                new Knjiga { Naslov = "Sto godina samoće", Autor = "Gabriel García Márquez", Zanr = "Magijski realizam", GodinaIzdanja = 1967, Kolicina = 8 },
                new Knjiga { Naslov = "Ime ruže", Autor = "Umberto Eco", Zanr = "Istorijski triler", GodinaIzdanja = 1980, Kolicina = 5 },
                new Knjiga { Naslov = "Dina", Autor = "Frank Herbert", Zanr = "Naucna fantastika", GodinaIzdanja = 1965, Kolicina = 9 },
                new Knjiga { Naslov = "Majstor i Margarita", Autor = "Mihail Bulgakov", Zanr = "Satira", GodinaIzdanja = 1967, Kolicina = 4 },
                new Knjiga { Naslov = "Koreni", Autor = "Dobrica Ćosić", Zanr = "Istorijski roman", GodinaIzdanja = 1954, Kolicina = 5 },
                new Knjiga { Naslov = "Ubistvo u Orijent Ekspresu", Autor = "Agatha Christie", Zanr = "Krimi roman", GodinaIzdanja = 1934, Kolicina = 10 },
                new Knjiga { Naslov = "Čovek po imenu Uve", Autor = "Fredrik Backman", Zanr = "Moderna fikcija", GodinaIzdanja = 2012, Kolicina = 11 },
                new Knjiga { Naslov = "Seobe", Autor = "Miloš Crnjanski", Zanr = "Istorijski roman", GodinaIzdanja = 1929, Kolicina = 4 },
                new Knjiga { Naslov = "Alhemičar", Autor = "Paulo Coelho", Zanr = "Alegorija", GodinaIzdanja = 1988, Kolicina = 15 },
                new Knjiga { Naslov = "Proces", Autor = "Franz Kafka", Zanr = "Apsurd", GodinaIzdanja = 1925, Kolicina = 6 },
                new Knjiga { Naslov = "Gorski vijenac", Autor = "Petar II Petrović-Njegoš", Zanr = "Ep", GodinaIzdanja = 1847, Kolicina = 3 },
                new Knjiga { Naslov = "Igra prestola", Autor = "George R. R. Martin", Zanr = "Epska fantastika", GodinaIzdanja = 1996, Kolicina = 13 },
                new Knjiga { Naslov = "Zovem se Crveno", Autor = "Orhan Pamuk", Zanr = "Istorijski misterija", GodinaIzdanja = 1998, Kolicina = 5 },
                new Knjiga { Naslov = "Kad su cvetale tikve", Autor = "Dragoslav Mihailović", Zanr = "Drama", GodinaIzdanja = 1968, Kolicina = 4 },
                new Knjiga { Naslov = "Čekajući Godoa", Autor = "Samuel Beckett", Zanr = "Teatar apsurda", GodinaIzdanja = 1953, Kolicina = 2 },
                new Knjiga { Naslov = "Gordost i predrasuda", Autor = "Jane Austen", Zanr = "Ljubavni roman", GodinaIzdanja = 1813, Kolicina = 8 },
                new Knjiga { Naslov = "Solunska 28", Autor = "Nele Karajlić", Zanr = "Istorijska fikcija", GodinaIzdanja = 2014, Kolicina = 7 }
            };
                    knjigeCollection.InsertBulk(knjige);
                }
            }
        }
    }
}