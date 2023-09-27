namespace Zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj x: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj y: ");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj z: ");
            double z = double.Parse(Console.ReadLine());

            double[] tab = new double[] { x, y, z };
            double[] tab1 = new double[] {1.45, 5.43, 4.3};
            double[] result = Vector(tab, tab1);

            foreach (double i in result)
            {
                Console.WriteLine(i);
            }
        }

        static double[] Vector(double[] punkt, double[] przesuniecie)
        {
            double[] wyniki = new double[punkt.Length];

            for (int i = 0; i < punkt.Length; i++)
            {
                wyniki[i] = punkt[i] + przesuniecie[i];
            }
            return wyniki;
        }
    }
}