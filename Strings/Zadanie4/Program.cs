namespace Zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string symbol = "monitory11/12/2021LCD";

            try
            {
                string data = symbol.Substring(8, 10);
                int miesiac = Convert.ToInt32(data.Substring(0, 2));
                int dzien = Convert.ToInt32(data.Substring(3, 2));
                int rok = Convert.ToInt32(data.Substring(6, 4));

                DateTime date = new DateTime(rok, miesiac, dzien);
                Console.WriteLine(date.ToLongDateString());
            }
            catch
            {

            }

            
        }
    }
}