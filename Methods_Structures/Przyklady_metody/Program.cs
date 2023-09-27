namespace Przyklady_metody
{
    internal class Program
    {
        //static double Delta(double a, double b, double c)
        //{
        //    return Math.Pow(b, 2) - 4 * a * c;
        //}
        //static void Main(string[] args)
        //{
        //    double a = -2.0, b = 1.0, c = 3.0;
        //    Console.WriteLine("{0}", Delta(a, b, c));
        //    Console.ReadKey();
        //}

        //przekazywanie argumentów przez referencje
        //static double Delta(ref double a, double b, double c)
        //{
        //    a = -5; // zmiana argumentu
        //    return Math.Pow(b, 2) - 4 * a * c;
        //}

        //static void Main(string[] args)
        //{
        //    double a = -2.0, b = 1.0, c = 3.0;
        //    Console.WriteLine("a={0}", a);
        //    Console.WriteLine("{0}", Delta(ref a, b, c));
        //    Console.WriteLine("a={0}", a); // Zmieniona wartość 'a'
        //    Console.ReadKey();
        //}

        //static double Delta(out double a, double b, double c)
        //{
        //    a = -5; // usunięcie tej linii spowoduje błąd
        //    return Math.Pow(b, 2) - 4 * a * c;
        //}

        //static void Main(string[] args)
        //{
        //    double a = -2.0, b = 1.0, c = 3.0;
        //    Console.WriteLine("a={0}", a);
        //    Console.WriteLine("{0}", Delta(out a, b, c));
        //    Console.WriteLine("a={0}", a); // Zmieniona wartość 'a'
        //    Console.ReadKey();
        //}

        //static double Delta(out double a, double b, double c)
        //{
        //    a = -5; // usunięcie tej linii spowoduje błąd
        //    return Math.Pow(b, 2) - 4 * a * c;
        //}

        //static void Main(string[] args)
        //{
        //    double b = 1.0, c = 3.0;
        //    Console.WriteLine("{0}", Delta(out double a, b, c));
        //    Console.WriteLine("a={0}", a);
        //    Console.ReadKey();
        //}

        static void Main(string[] args)
        {
            double bok;
            Console.Write("Wpisz bok kwadratu: ");
            string bokStr = Console.ReadLine();

            if (double.TryParse(bokStr, out bok) && bok > 0)
                Console.Write("Powierzchnia: {0}", Math.Pow(bok, 2));
            else
                Console.Write("Bok musi być liczbą dodatnią");

            Console.ReadKey();
        }   
    }
}