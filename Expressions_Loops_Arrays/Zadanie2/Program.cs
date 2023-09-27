namespace Zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Podaj długość ciągu arytmetycznego: ");
                int dlCiag = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj r ");
                double r = double.Parse(Console.ReadLine());
                double[] tab = new double[dlCiag];

                for (int i = 0; i < dlCiag - 1; i++)
                {
                    if (i == 0)
                    {
                        tab[i] = 0.33;
                    }
                    tab[i + 1] = tab[i] + r;
                }

                foreach (double k in tab)
                {
                    Console.WriteLine("{0:F2}", k);
                }
            }
            catch (IOException x)
            {
                Console.WriteLine(x.Message);
            }catch (OverflowException y)
            {
                Console.WriteLine(y.Message);
            }catch (FormatException z)
            {
                Console.WriteLine(z.Message);
            }
        }
    }
}