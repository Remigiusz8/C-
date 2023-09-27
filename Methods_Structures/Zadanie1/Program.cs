using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Authentication.ExtendedProtection;

namespace Zadanie1
{
    class Zadanie
    {
        private string pole;

        public Zadanie(){}

        public void Wpisz()
        {
            Console.WriteLine("Wpisz tekst: ");
            pole = Console.ReadLine();
        }

        public int Znak()
        {
            string newText = "";

            for(int i = 0; i < pole.Length; i++)
            {
                if (Char.IsDigit(pole[i]))
                {
                    newText = newText + pole[i];
                }
            }
            Console.WriteLine(newText);

            int numer;

            if (Int32.TryParse(newText, out numer))
            {
                return numer;
            }
            else
            {
                Console.WriteLine("Nie udało się przekonwertować");
                return Int32.MaxValue;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Zadanie one = new Zadanie();
            one.Wpisz();
            one.Znak();
        }
    }
}