using System.Collections.Immutable;

namespace Zadanie5
{
    class Pracownik
    {
        int idPrac;
        string nazwisko;
        string imie;
        string email;

        public Pracownik(int idP, string naz)
        {
            idPrac = idP;
            nazwisko = naz;
        }

        public Pracownik(int idP, string naz, string im, string em) : this(idP, naz)
        {
            imie = im;
            email = em;
        }

        public override string ToString()
        {
            return $"{idPrac} {nazwisko} {imie} {email}";
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Pracownik[] pracownicy = new Pracownik[3];

            pracownicy[0] = new Pracownik(1,"Kowalski");
            pracownicy[1] = new Pracownik(2, "Ziomek", "Stefan", "stefek@praca.pl");
            pracownicy[2] = new Pracownik(3, "Nowak");

            foreach(var i in pracownicy)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}