namespace Zadanie3
{
    abstract class Figura
    {
        protected ConsoleColor color;

        public Figura(ConsoleColor color)
        {
            this.color = color;
        }

        public abstract double Pole();

        public override string ToString()
        {
            return $"Kolor: {color}";
        }
    }

    class Kolo : Figura
    {
        private int promien;

        public Kolo(ConsoleColor color, int promien) : base(color)
        {
            this.promien = promien;
        }

        public override double Pole()
        {
            return Math.PI * promien * promien;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nPromień: {promien}\nPole: {Pole():F2}";
        }
    }

    class Prostokat : Figura
    {
        private int dlugosc;
        private int szerokosc;

        public Prostokat(ConsoleColor color, int dlugosc, int szerokosc) : base(color)
        {
            this.dlugosc = dlugosc;
            this.szerokosc = szerokosc;
        }

        public override double Pole()
        {
            return dlugosc * szerokosc;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nDługość: {dlugosc}\nSzerokosc: {szerokosc}\nPole: {Pole():F2}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Figura[] figury = new Figura[4];

            figury[0] = new Kolo(ConsoleColor.Red, 3);
            figury[1] = new Kolo(ConsoleColor.Yellow, 2);
            figury[2] = new Prostokat(ConsoleColor.Cyan, 4, 7);
            figury[3] = new Prostokat(ConsoleColor.White, 2, 4);

            foreach(Figura f in figury)
            {
                Console.WriteLine(f.ToString());
            }
        }
    }
}