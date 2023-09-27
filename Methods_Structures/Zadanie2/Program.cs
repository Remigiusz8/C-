namespace Zadanie2
{
    class Zadanie
    {
        private string pole;

        public Zadanie() { }

        public void Wpisz()
        {
            Console.WriteLine("Wpisz tekst: ");
            pole = Console.ReadLine();
        }

        public int Znak()
        {
            string newText = "";

            for (int i = 0; i < pole.Length; i++)
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

        public string Litery()
        {
            string newText = "";

            foreach(char c in pole)
            {
                if (Char.IsLower(c))
                {
                    newText = newText + Char.ToUpper(c);
                }
                else if (Char.IsUpper(c))
                {
                    newText = newText + Char.ToLower(c);
                }
                else
                {
                    newText = newText + c;
                }
            }
            Console.Write("Nowy Tekst: ");
            return newText;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Zadanie one = new Zadanie();
            one.Wpisz();
            one.Znak();
            Console.WriteLine(one.Litery());
        }
    }
}