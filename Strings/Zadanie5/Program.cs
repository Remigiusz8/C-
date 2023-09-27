namespace Zadanie5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string klucz = "GA-DE-RY-PO-LU-KI";
            //string[] kody = klucz.Split('-'); 
            string key = "gaderypoluki";
            string slowo = "kanapa";
            for (int i = 0; i < slowo.Length; i++)
            {
                for (int j = 0; j < key.Length; j++)
                {
                    if (slowo[i] == key[j])
                    {
                        if (j % 2 == 0)
                        {
                            char temp = slowo[i];
                            slowo[i] = key[j];
                        }
                    }
                }
            }
            
            
        }
    }
}