namespace Zadanie1
{
    class Energia
    {
        private int stanPoczatkowy { get; set; }
        private int stanBiezacy { get; set; }

        public Energia(int stanP, int stanB)
        {
            stanPoczatkowy = stanP;
            stanBiezacy = stanB;
        }

        public string Info()
        {
            return $"Początkowy stan: {stanPoczatkowy}\nBieżący stan: {stanBiezacy}";
        }

        public int Oblicz()
        {
            return stanBiezacy - stanPoczatkowy;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Energia e1 = new Energia(240, 480);
            Energia e2 = new Energia(32, 120);

            Console.WriteLine(e1.Info());
            Console.WriteLine(e1.Oblicz());
            Console.WriteLine();
            Console.WriteLine(e2.Info()); 
            Console.WriteLine(e2.Oblicz()); 
        }
    }
}














/*
class Energia
    {
        private double stanLicznika;
        private double stanPoczatkowy;

        public Energia() { }

        public Energia(double stanPoczatkowy, double stanLicznika)
        {
            this.stanLicznika = stanLicznika;
            this.stanPoczatkowy = stanPoczatkowy;
        }

        public double getStanPocz(double stanPoczatkowy)
        {
            return stanPoczatkowy;
        }

        public double getStan(double stanLicznika)
        {
            return stanLicznika;
        }

        public double oblicz(Energia en)
        {
            return (en.getStan(stanLicznika) - en.getStanPocz(stanPoczatkowy)) * 0.94;
        }
        
    }



Energia en1 = new Energia(0, 340);
            Energia en2 = new Energia(240, 500);

            Console.WriteLine(en1.oblicz(en1));
            Console.WriteLine(en2.oblicz(en2));
*/