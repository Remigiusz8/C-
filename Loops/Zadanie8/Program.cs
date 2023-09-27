namespace Zadanie8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            for (int i = 1000; i <= 9999; i++)
            {
                int pdc = i / 100; //pierwsze dwie cyfry
                int odc = i % 100; //ostatnie dwie cyfry
                
                if (pdc * pdc + odc * odc == i)
                {
                    Console.WriteLine(i + " = " + pdc + "^2 " + "+ " + odc + "^2");
                }
            }
        }
    }
}