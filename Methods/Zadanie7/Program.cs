using System.Diagnostics.CodeAnalysis;

namespace Zadanie7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ZROBIĆ WERSJĘ BEZ UŻYCIA TABLIC!!! JAKO DOMOWE
            // ZROBIĆ PRZECIĄŻONE WERSJE METODY POLA TRÓJKĄTA Z ZADANIA 8
            // DOKOŃCZYĆ TO ZADANIE I ZROBIĆ RESZTĘ

            Console.WriteLine("Podaj liczbę elementów ciągu: ");
            int liczba = int.Parse(Console.ReadLine());

            Console.WriteLine("Suma elementów ciągu Fibonacciego: {0}", Fibonacci(liczba));
        }

        static int Fibonacci(int n)
        {
            int[] tab = new int[n];
            int suma = 0;

            if (n > 0)
            {
                for (int i = 0; i < tab.Length; i++)
                {
                    if (i == 0)
                    {
                        tab[i] = 0;
                    } else if (i == 1)
                    {
                        tab[i] = 1;
                    } else
                    {
                        tab[i] = tab[i - 1] + tab[i - 2];
                    }
                    suma += tab[i];
                }
            } else
            {
                //return -1;
                throw new Exception("Ujemna wartość elementu!");
            }
            return suma;
        }
    }
}