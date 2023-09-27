using System.Collections.Generic;
using System.Globalization;

namespace Zadanie3
{
    interface IFigura
    {
        ConsoleColor Kolor { get; set; }
        double Pole();
    }

    public class Kolo : IFigura
    {
        double promien;
        public ConsoleColor Kolor { get; set; }

        public Kolo(double promien, ConsoleColor Kolor)
        {
            this.promien = promien;
            this.Kolor = Kolor;
        }

        public override string ToString()
        {
            return $"Promień: {promien}, Kolor: {Kolor}, Pole: {Pole():F2}";
        }

        public double Pole()
        {
            return Math.PI * promien * promien;
        }
    }

    public class Prostokat : IFigura
    {
        int a;
        int b;
        public ConsoleColor Kolor { get; set; }

        public Prostokat(int a, int b, ConsoleColor Kolor)
        {
            this.a = a;
            this.b = b;
            this.Kolor = Kolor;
        }

        public override string ToString()
        {
            return $"Bok 1: {a}, Bok 2: {b}, Kolor: {Kolor}, Pole: {Pole()}";
        }

        public double Pole()
        {
            return a * b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<IFigura> figury = new List<IFigura>();
            figury.Add(new Kolo(4, ConsoleColor.Red));
            figury.Add(new Kolo(2, ConsoleColor.White));
            figury.Add(new Kolo(1.5, ConsoleColor.Blue));
            figury.Add(new Prostokat(2, 3, ConsoleColor.DarkBlue));
            figury.Add(new Prostokat(1, 5, ConsoleColor.Yellow));
            figury.Add(new Prostokat(4, 3, ConsoleColor.Cyan));

            for (int i = 0; i < figury.Count; i++)
            {
                Console.WriteLine(figury[i].ToString());
            }
        }
    }
}