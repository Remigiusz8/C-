namespace Zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz tekst: ");
            string wiersz = Console.ReadLine();
            string sciezka = @"C:\Users\Remek\source\repos\Zadanie3\dane.txt";

            if (File.Exists(sciezka))
            {
                File.Delete(sciezka);
            }

            using (FileStream strumien = File.Create(sciezka))
            {
                for (int i = 0; i < wiersz.Length; i++)
                {
                    byte[] bytes = BitConverter.GetBytes(wiersz[i]);

                    foreach (byte m in bytes)
                    {
                        strumien.WriteByte(m);
                    }
                }
                strumien.Close();
            }

            using (StreamReader info = new StreamReader(sciezka))
            {
                Console.WriteLine(info.ReadToEnd());
            }
        }
    }
}