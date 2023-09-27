using System.Collections;

namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool ON = true;
                while (ON)
                {
                    Console.WriteLine("Wybierz opcję z menu: ");
                    Console.WriteLine("[1] - Rejestrowanie pomiaru \n[2] - Przeglądanie danych rekord po rekordzie \n[3] - Przeglądanie danych ekranami \n[4] - Usuwanie ostatniego wpisu \n[5] - Usuwanie wpisu o określonej dacie \n[6] - Wyjście z programu");
                    int opcja = int.Parse(Console.ReadLine());

                    switch (opcja)
                    {
                        case 1:
                            string dane = Czytaj();
                            Zapisz(dane);
                            break;
                        case 2:
                            Odczyt();
                            break;
                        case 3:
                            Przegladaj();
                            break;
                        case 4:
                            Usun();
                            break;
                        case 5:
                            UsunData();
                            break;
                        case 6:
                            ON = Koniec(ON);
                            break;
                        default:
                            Console.Write("Podano nieprawidłową wartość, proszę spróbować jeszcze raz");
                            break;
                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static string Czytaj()
        {
            try
            {
                Console.WriteLine("Podaj rok: ");
                int rok = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj miesiąc: ");
                int msc = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj dzień: ");
                int dzien = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj godzinę: ");
                int godz = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj minutę: ");
                int min = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj sekundę: ");
                int sek = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj temperaturę: ");
                int temp = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj ciśnienie: ");
                int cis = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj opady: ");
                int opady = int.Parse(Console.ReadLine());

                string wiersz = (rok + ";" + msc + ";" + dzien + ";" + godz + ";" + min + ";" + sek + ";" + temp + ";" + cis + ";" + opady);
                return wiersz;
            }catch (Exception x)
            {
                return x.Message;
            }
        }

        static void Zapisz(string plik)
        {
            string sciezka = @"C:\Users\Remek\source\repos\Zadanie1\dane.txt";
            StreamWriter dane;

            if (!File.Exists(sciezka))
            {
                dane = File.CreateText(sciezka);
            }
            else
            {
                dane = new StreamWriter(sciezka, true);
            }

            dane.WriteLine(plik);
            dane.Flush();
            dane.Close();
        }

        static string Odczyt()
        {
            try
            {
                StreamReader text = new StreamReader(@"C:\Users\Remek\source\repos\Zadanie1\dane.txt");
                string line;
                while ((line = text.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    Console.WriteLine("Czy chcesz wyświetlić kolejny wpis? (t/n)");
                    string decyzja = Console.ReadLine();
                    if (decyzja == "t")
                    {
                        continue;
                    }
                    else if (decyzja == "n")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Błąd");
                        break;
                    }
                }
                text.Close();
                return line;
            }
            catch (Exception x)
            {
                return x.Message;
            }
        }

        static void Przegladaj()
        {
            StreamReader text = new StreamReader(@"C:\Users\Remek\source\repos\Zadanie1\dane.txt");
            string line;
            int lineCount = File.ReadAllLines(@"C:\Users\Remek\source\repos\Zadanie1\dane.txt").Length;
            int i = 1;
            while ((line = text.ReadLine()) != null)
            {
                Console.WriteLine(line);

                if (i % 20 == 0)
                {
                    Console.WriteLine("Czy chcesz wyświetlić kolejną paczkę pomiarów? (t/n)");
                    string decyzja = Console.ReadLine();

                    if (decyzja == "t")
                    {
                        i++;
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    i++;
                }
            }
            text.Close();
        }

        static void Usun()
        {
            try
            {   
                string filepath = @"C:\Users\Remek\source\repos\Zadanie1\dane.txt";
                List<string> lines = File.ReadAllLines(filepath).ToList();
                File.WriteAllLines(filepath, lines.GetRange(0, lines.Count - 1).ToArray());

            }catch (Exception x)
            {
                Console.WriteLine(x.Message);
            } 
        }

        static void UsunData()
        {
            try
            {
                string path = @"C:\Users\Remek\source\repos\Zadanie1\dane.txt";
                List<string> lines = File.ReadAllLines(path).ToList();
                Console.WriteLine("Podaj datę wpisu do usunięcia");
                Console.WriteLine("Rok: ");
                string rok = Console.ReadLine();
                Console.WriteLine("Miesiąc: ");
                string msc = Console.ReadLine();
                Console.WriteLine("Dzień: ");
                string dzien = Console.ReadLine();
                
                for (int i = 0; i < lines.Count; i++)
                {
                    if (lines[i].StartsWith(rok) && lines[i].Contains(msc) && lines[i].Contains(dzien))
                    {
                        lines.RemoveAt(i);
                    }
                }

                File.WriteAllLines(path, lines);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
        }

        static bool Koniec(bool number)
        {
            number = false;
            return number;
        }
    }
}