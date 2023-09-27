namespace Zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz tekst: ");
            string sentence = Console.ReadLine();
            int suma = 0;
            int wyrazy = 0;
            int znaki = 0;
            int spacje = 0;

            foreach (string s in sentence.Split(" "))
            {
                if (s.EndsWith(".") || s.EndsWith("?") || s.EndsWith("!"))
                {
                    suma += 1;
                }
                wyrazy += 1;
                
            }
            Console.WriteLine();
            Console.WriteLine("Liczba zdań: {0}",suma);
            Console.WriteLine("Liczba wyrazów: {0}",wyrazy);

            char[] arr = sentence.ToCharArray();

            foreach (char c in arr)
            {
                if (c == ' ')
                {
                    spacje += 1;
                } else
                {
                    znaki += 1;
                }
            }
            Console.WriteLine("Liczba znaków: {0}", znaki);
            Console.WriteLine("Liczba spacji: {0}", spacje);
        }
    }
}