namespace Zadanie5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random random = new Random();
                int los = random.Next(1, 10001);
                //Console.WriteLine(los);

                for (int i = 5; i >= 1; i--)
                {
                    Console.WriteLine("Zgadnij liczbę! Pozostało prób: {0}", i);
                    int number = int.Parse(Console.ReadLine());
                    if (number == los)
                    {
                        Console.WriteLine("Gratulacje odgadłeś liczbę!");
                        break;
                    }
                    else
                    {
                        if (number > los)
                        {
                            Console.WriteLine("Szukana cyfra jest mniejsza.");
                        }
                        else
                        {
                            Console.WriteLine("Szukana cyfra jest większa.");
                        }
                    }
                }
            } 
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
        }
    }
}