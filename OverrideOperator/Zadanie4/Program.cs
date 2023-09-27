namespace Zadanie4
{
    struct Kolo
    {
        private double r;
        private int x;
        private int y;

        public Kolo(double r, int x, int y)
        {
            this.r = r;
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"Promień: {r} Współrzędne środka: ({x}, {y})";
        }

        public static Kolo operator + (Kolo k, double i)
        {
            return new Kolo(k.r + i, k.x, k.y);
        }

        public static Kolo operator < (Kolo k1, Kolo k2)
        {
            return new Kolo(k1.r, k1.x, k1.y);
        }

        public static Kolo operator > (Kolo k1, Kolo k2)
        {
            return new Kolo(k1.r, k1.x, k1.y);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Kolo one = new Kolo(1, 2, 3);
            Kolo two = new Kolo(0.5, 4, 6);
            Kolo three = new Kolo(5, 7, 8);
            Console.WriteLine(one + 2);
            Console.WriteLine(one < two);
            Console.WriteLine(three > one);
        }
    }
}