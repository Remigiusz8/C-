namespace Zadanie7
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

    class MacierzDiagonalna : Macierz
    {
        protected double[,] macierz;

        public MacierzDiagonalna(double[,] macierz)
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
            Console.WriteLine("Macierz diagonalna");
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

    sealed class MacierzSkalarna : MacierzDiagonalna
    {
        public MacierzSkalarna(double[,] macierz) : base(macierz) { }

        public override double Wyznacznik()
        {
            double det = 1;

            for (int i = 0; i < macierz.GetLength(0); i++)
            {
                for (int j = 0; j < macierz.GetLength(1); j++)
                {
                    if (i == 1 && j == 1)
                    {
                        det *= Math.Pow(macierz[i, j], macierz.GetLength(0));
                    }
                }
            }

            return det;
        }

        public void Wyswietl()
        {
            Console.WriteLine("Macierz skalarna");
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

            MacierzDiagonalna C = new MacierzDiagonalna(new double[,] { { 3, 0, 0, 0 }, { 0, 4, 0, 0 }, { 0, 0, 2, 0 }, { 0, 0, 0, 5 } });
            C.Wyswietl();
            Console.WriteLine($"Determinum {C.Wyznacznik()}");

            MacierzSkalarna D = new MacierzSkalarna(new double[,] { { 2, 0, 0, 0 }, { 0, 2, 0, 0 }, { 0, 0, 2, 0 }, { 0, 0, 0, 2 } });
            D.Wyswietl();
            Console.WriteLine($"Determinum {D.Wyznacznik()}");
        }
    }
}