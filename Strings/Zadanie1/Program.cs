namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Wariant 1

            Console.WriteLine("Podaj imię: ");
            string name = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko: ");
            string surname = Console.ReadLine();

            if (name.EndsWith("a"))
            {
                Console.Write("Szanowna Pani {0} {1}.", name, surname);
            } else
            {
                Console.Write("Szanowny Pan {0} {1}.", name, surname);
            }
            Console.WriteLine();
            //Wariant 2

            Console.WriteLine("Podaj imię i nazwisko: ");
            string name2 = Console.ReadLine();

            foreach (string s in name2.Split(" "))
            {
                if (s.EndsWith("a"))
                {
                    Console.Write("Szanowna Pani {0}.", name2);
                    break;
                } else
                {
                    Console.Write("Szanowny Pan {0}.", name2);
                    break;
                }
            }
            Console.WriteLine();
            //Wariant 3

            Console.WriteLine("Podaj nazwisko i imię: ");
            string name3 = Console.ReadLine();
            string[] imie = name3.Split(' ');

            for (int i = imie.Length-1; i >= 0; i--)
            {
                if (imie[0].EndsWith('a'))
                {
                    Console.Write("Szanowna Pani {0} ", imie[i]);
                } else
                {
                    Console.Write("Szanowny Pan {0} ", imie[i]);
                }
            }
        }
    }
}