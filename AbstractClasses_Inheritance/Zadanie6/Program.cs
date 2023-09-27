namespace Zadanie6
{
    public abstract class Macierz
    {
        public abstract double Wyznacznik();
    }

    class MacierzTrojkatna : Macierz
    {
        double[,] macierz;

        public MacierzTrojkatna(double[,] macierz)
        {
            this.macierz = macierz;
        }

        public override double Wyznacznik()
        {
            double det = 1;

            for (int i = 0; i < macierz.GetLength(0); i++)
            {
                for (int j = 0; j < macierz.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        det *= macierz[i, j];
                    }
                }
            }

            return det;
        }

        public void Wyswietl()
        {
            Console.WriteLine("Macierz trójkątna");
            for (int i = 0; i < macierz.GetLength(0); i++)
            {
                for (int j = 0; j < macierz.GetLength(1); j++)
                {
                    Console.Write(macierz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

    class MacierzJednostkowa : Macierz
    {
        int rozmiar;

        public MacierzJednostkowa(int rozmiar)
        {
            this.rozmiar = rozmiar;
        }

        public override double Wyznacznik()
        {
            return 1;
        }

        public void Wyswietl()
        {
            Console.WriteLine("Macierz jednostkowa");
            for (int i = 0; i < rozmiar; i++)
            {
                for (int j = 0; j < rozmiar; j++)
                {
                    Console.Write((i == j ? 1 : 0) + " ");
                }
                Console.WriteLine();
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MacierzTrojkatna macierz = new MacierzTrojkatna(new double[,] { { 1, 0, 0 }, { 2, 3, 0 }, { 4, 5, 6 } });
            macierz.Wyswietl();
            Console.WriteLine($"Determinum {macierz.Wyznacznik()}");

            MacierzJednostkowa B = new MacierzJednostkowa(3);
            B.Wyswietl();
            Console.WriteLine($"Determinum {B.Wyznacznik()}");
        }
    }
}