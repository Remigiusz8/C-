using System.Collections;
using System.Text.RegularExpressions;

namespace Zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList value = new ArrayList();
            string line;
            StreamReader text = new StreamReader(@"C:\Users\Remek\source\repos\Zadanie2\dane.txt");
            while ((line = text.ReadLine()) != null)
            {
                value.Add(line);
            }
            text.Close();

            foreach(string v in value)
            {
                Console.WriteLine(v);
            }
        }
    }
}