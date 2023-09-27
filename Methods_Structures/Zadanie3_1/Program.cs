namespace Zadanie3_1
{
    struct ZnakNaKonsoli
    {
        char znak;
        int wspX;
        int wspY;

        public ZnakNaKonsoli(int wspX, int wspY, char znak)
        {
            this.wspX = wspX;
            this.wspY = wspY;
            this.znak = znak;
        }

        public void Ustaw()
        {
            Console.Clear();
            Console.SetCursorPosition(wspX, wspY);
            Console.Write(znak);
        }

        public void Zmiana()
        {
            bool key = true;

            while (key)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.LeftArrow)
                {
                    wspX--;
                    Ustaw();

                }
                else if (Console.ReadKey(true).Key == ConsoleKey.RightArrow)
                {
                    wspX++;
                    Ustaw();

                }
                else if (Console.ReadKey(true).Key == ConsoleKey.UpArrow)
                {
                    wspY--;
                    Ustaw();

                }
                else if (Console.ReadKey(true).Key == ConsoleKey.DownArrow)
                {
                    wspY++;
                    Ustaw();

                }
                else if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    key = false;
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ZnakNaKonsoli jeden = new ZnakNaKonsoli(2, 13, '$');
            jeden.Ustaw();
            jeden.Zmiana();
        }
    }
}