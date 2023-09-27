namespace Zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj odległość w kilometrach: ");
            double km = double.Parse(Console.ReadLine());
            Console.WriteLine("Wartość w milach morskich - {0}", Mila(km));
            Console.WriteLine();
            Console.WriteLine("Podaj prędkość: ");
            double vel = double.Parse(Console.ReadLine());
            Console.WriteLine("Wpisz jednostkę (m/s, km/h, wezly): ");
            string info = Console.ReadLine();

            switch(info)
            {
                case "m/s":
                    Console.WriteLine("Km/h na m/s: {0}", Ms(vel));
                    break;
            }
        }
        static double Mila(double mile)
        {
            return mile * 1.852 ;
        }

        static double Ms(double m)
        {
            return m * (10 / 36);
        }
    }
}