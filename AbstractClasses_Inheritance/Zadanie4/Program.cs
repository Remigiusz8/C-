namespace Zadanie4
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
            return $"{base.ToString()} Promień: {promien} Pole: {Pole():F2}";
        }
    }

    class Prostokat : Figura
    {
        private double dlugosc { get; set; }
        private double szerokosc { get; set; }

        public Prostokat(ConsoleColor color, double dlugosc, double szerokosc) : base(color)
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
            return $"{base.ToString()} Długość: {dlugosc} Szerokość: {szerokosc} Pole: {Pole()}";
        }
    }
    class Blat : Prostokat
    {
        public enum Rodzaj
        {
            granitowy = 600,
            drewniany = 250
        }

        private Rodzaj rodzaj;

        public Blat(ConsoleColor color, double dlugosc, double szerokosc, Rodzaj rodzaj) : base(color, dlugosc, szerokosc)
        {
            this.rodzaj = rodzaj;
        }

        public override double Pole()
        {
            return base.Pole();
        }

        public double Koszt()
        {
            int cena = (int)rodzaj;
            return Pole() * cena;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Rodzaj: {rodzaj} Koszt: {Koszt()}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Figura[] figury = new Figura[4];
            figury[0] = new Kolo(ConsoleColor.Red, 3);
            figury[1] = new Prostokat(ConsoleColor.Green, 4, 5);
            figury[2] = new Kolo(ConsoleColor.Blue, 2);
            figury[3] = new Blat(ConsoleColor.Yellow, 13, 15, Blat.Rodzaj.granitowy);

            foreach (var figura in figury)
            {
                Console.WriteLine(figura.ToString());
            }
        }
    }
}