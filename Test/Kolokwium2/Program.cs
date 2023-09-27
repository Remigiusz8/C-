namespace Kolokwium2
{
    abstract class Funkcja
    {
        protected int a;
        protected int b;
        protected int x;

        public Funkcja(int x, int a, int b)
        {
            this.x = x; this.a = a; this.b = b;
        }
        public abstract int ObliczWartoscFunkcji();

        public override string ToString()
        {
            return $"x = {x}, a = {a}, b = {b}";
        }
    }

    class FunkcjaLiniowa : Funkcja
    {

        public FunkcjaLiniowa(int x, int a, int b) : base(x, a, b) { }
        
        public override int ObliczWartoscFunkcji()
        {
            return a * x + b;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, y = {a}x + {b}, wartość y = {ObliczWartoscFunkcji()}";
        }
    }

    class FunkcjaKwadratowa : Funkcja
    {
        private int c;

        public FunkcjaKwadratowa(int x, int a, int b, int c) : base(x, a, b)
        {
            this.c = c;
        }

        public override int ObliczWartoscFunkcji()
        {
            return a * x * x + b * x + c;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, c = {c}, y = {a}x^2 + {b}x + {c}, wartość y = {ObliczWartoscFunkcji()}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Funkcja[] one = new Funkcja[4];

            one[0] = new FunkcjaLiniowa(2, 3, 4);
            one[1] = new FunkcjaKwadratowa(2, 1, 3, 4);
            one[2] = new FunkcjaLiniowa(4, 2, 1);
            one[3] = new FunkcjaKwadratowa(2, 2, 2, 2);

            foreach(var i in one)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}