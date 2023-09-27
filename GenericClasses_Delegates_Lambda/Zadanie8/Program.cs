namespace Zadanie8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double VAT = 0.23;
            Func<double, double> obliczVat = x => x * (1 + VAT);

            Console.WriteLine(obliczVat(15.24));
        }
    }
}