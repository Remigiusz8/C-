namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random los = new Random();
                Console.WriteLine("Rozmiar tablicy: ");
                int rozmiar = int.Parse(Console.ReadLine());
                double[] tab = new double[rozmiar];

                for (int i = 0; i < rozmiar; i++)
                {
                    tab[i] = los.NextDouble();
                }

                foreach (double k in tab)
                {
                    Console.WriteLine("{0:F2}", k);
                }

                double sumaNP = 0;
                double sumaP = 0;

                for (int j = 0; j < tab.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        sumaP += tab[j];
                    }
                    else
                    {
                        sumaNP += tab[j];
                    }
                }
                Console.WriteLine("Suma liczb parzystych wynosi {0:F2}", sumaP);
                Console.WriteLine("Suma liczb nieparzystych wynosi {0:F2}", sumaNP);
            
            } catch (IOException x)
            {
                Console.Write(x.Message);
            } catch (OverflowException y)
            {
                Console.Write(y.Message);
            }


        }
    }
}