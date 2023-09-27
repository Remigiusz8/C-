using System.Runtime.CompilerServices;

namespace Zadanie5
{
    class Program
    {
     
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static string Conc(string a, string b)
        {
            return a + b;
        }

        delegate T Ref<T>(T a, T b);

        static void Main(string[] args)
        {
            Ref<string> t1 = new Ref<string>(Conc);
            Ref<int> t2 = new Ref<int>(Sum);

            Console.WriteLine(t1("Hello ", "world"));
            Console.WriteLine(t2(3, 5));
        }
    }
}