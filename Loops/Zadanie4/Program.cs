namespace Zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;

            Console.WriteLine("Podaj ostatnia wartosc wieksza od 0: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= number; i++)
            {
                suma += i;
            }
            double sum = Convert.ToDouble(suma);
            double num = Convert.ToDouble(number);
            double srednia = sum / num;

            Console.WriteLine("Suma wynosi {0}", suma);
            Console.WriteLine("Srednia cyfr wynosi {0}", srednia);
            
        }
    }
}