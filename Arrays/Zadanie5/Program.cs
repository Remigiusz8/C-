namespace Zadanie5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Wprowadź długość tablicy ");
            try
            {
                int n = int.Parse(Console.ReadLine());
                try
                {
                    int[] tab = new int[n];
                    int[] tab1 = new int[n];
                    Console.WriteLine();

                    for (int i = 0; i < n; i++)
                    {
                        tab[i] = random.Next();
                        tab1[i] = tab[i];
                    }

                    for (int j = 0; j < n; j++)
                    {
                        for (int k = j; k < tab1.Length; k++)
                        {
                            if (tab1[j] < tab1[k])
                            {
                                int temp = tab1[j];
                                tab1[j] = tab1[k];
                                tab1[k] = temp;
                            }
                        }
                    }
                    
                    Console.WriteLine("tablica");
                    foreach (int i in tab)
                    {
                        Console.WriteLine(i);
                    }

                    Console.WriteLine();
                    Console.WriteLine("Posortowana tablica");
                    foreach (int j in tab1)
                    {
                        Console.WriteLine(j);
                    }

                } catch(OverflowException ov)
                {
                    Console.WriteLine(ov.Message);
                }
                
            } catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }   
    }
}