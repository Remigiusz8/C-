namespace Zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz długość pierwszego bok trójkąta: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Wpisz długość drugiego bok trójkąta: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Wpisz długość trzeciego bok trójkąta: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (CheckTriangle(a,b,c) == true)
            {
                Console.WriteLine("Tak, można utworzyć trójkąt.");
            } else
            {
                Console.WriteLine("Nie, nie można utworzyć trójkątu.");
            }


        }

        static bool CheckTriangle(int one, int two, int three)
        {
            bool check = true;
            if (one > two && one > three)
            {
                if (two + three > one)
                {
                    check = true;
                } else
                {
                    check = false;
                }
            } else if (two > one && two > three)
            {
                if (one + three > two)
                {
                    check = true;
                } else
                {
                    check = false;
                }
            } else if (three > one && three > two)
            {
                if (one + two > three)
                {
                    check = true;
                } else
                {
                    check = false;
                }
            }
            return check;
        }
    }
}