namespace Zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumaNP = 0;
            int sumaP = 0;
            int liczbaNP = 0;
            int liczbaP = 0;

            Console.WriteLine("Podaj poczatek przedzialu");
            int pierwsza = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj poczatek przedzialu");
            int ostatnia = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = pierwsza; i <= ostatnia; i++)
            {
                if (i % 2 != 0)
                {
                    liczbaNP += 1;
                    sumaNP += i;
                }else if (i % 2 == 0)
                {
                    liczbaP += 1;
                    sumaP += i;
                }
            }
            Console.WriteLine("Suma liczb nieparzystych wynosi: " + sumaNP);
            Console.WriteLine("Liczba wartości nieparzystych: " + liczbaNP);
            Console.WriteLine("Suma liczb parzystych wynosi: " + sumaP);
            Console.WriteLine("Liczba wartości parzystych: " + liczbaP);
        }
    }
}