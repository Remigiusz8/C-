namespace Zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Remek\source\repos\Zadanie4\dane.txt");

            List<String> dane = new List<String>();
            double srednia = 0;
            string wiersz;
            while ((wiersz = sr.ReadLine()) != null)
            {
                dane.Clear();
                dane.Add(wiersz);

                foreach (string elem in dane)
                {
                    Console.WriteLine(elem);
                }
            }
            
        }
    }
}