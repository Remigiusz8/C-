using System.Threading.Channels;

namespace Zadanie3
{
    public class Country
    {
        public static string ShowCountry(string str)
        {
            return str;
        }
    }

    public class City
    { 
        public static string ShowCity(string str)
        {
            return str;
        }
    }

    public delegate string Dzialanie(string str);

    internal class Program
    {
        static void Main(string[] args)
        {
            Dzialanie d1 = new Dzialanie(City.ShowCity);
            Dzialanie d2 = new Dzialanie(Country.ShowCountry);

            Console.WriteLine(d1("Bangkok"));
            Console.WriteLine(d2("Tajlandia"));
        }
    }
}