namespace Zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Odcinek odcinekAB = new Odcinek(new (4, 0), new (4, 6));
            Console.WriteLine(odcinekAB.Dlugosc()); 
        }
    }
}