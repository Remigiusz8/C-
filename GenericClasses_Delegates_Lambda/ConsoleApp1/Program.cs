//stworzyć metody bezimienne 2 delegaty func i action obsłużyć dowolnie

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<double, double, double> dodawanie = (x, y) => x + y;
            Func<double, double, double> odejmowanie = (x, y) => x - y;
            Action<double> wypisz = (x, y) => x * y;
            Action<double, double> dzielenie = (x, y) => x / y;

            dzielenie(2, 3);
        }
    }
}