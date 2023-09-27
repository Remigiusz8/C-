namespace Zadanie9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadz y");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadz a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadz b");
            double b = double.Parse(Console.ReadLine());
            double x;

            Console.Clear();
            Console.WriteLine("{0} = {1}x + {2}", y, a, b);

            if (b >= 0)
            {
                y -= b;
                b -= b;
            }
            else if (b <= 0)
            {
                y -= b;
                b -= b;
            }
            else
            {
                b = 0;
            }
            Console.WriteLine("{0} = {1}x + {2}", y, a, b);
            if (a == 0)
            {
                Console.WriteLine("x = 0");
            }
            else
            {
                y /= a;
                a /= a;
            }
            Console.WriteLine("{0} = {1}x + {2}", y, a, b);
            Console.WriteLine("x = {0}", y);
        }
    }
}