namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] tab = new double[10];
            try
            {
                Console.WriteLine("Podaj 10 cyfr");

                for (int i = 0; i < 10; i++)
                {
                    int j = int.Parse(Console.ReadLine());
                    tab[i] = j;
                }

                foreach (int k in tab)
                {
                    Console.WriteLine("{0:F4}", k);
                }
            }
            catch(FormatException fex) //kursor na Parse, wypisuje możliwe wyjątki. Dodac tutaj i przypisac nazwe zmiennej
            {
                Console.WriteLine("Wprowadzono błędną wartość do tablicy");
                Console.WriteLine(fex.Message); //wypisuje exceptions
            }
        }
    }
}