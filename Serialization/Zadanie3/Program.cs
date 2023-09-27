using System.Xml.Serialization;

namespace Zadanie3
{
    static public class ZapisOdczytXML
    {
        // Serializacja
        public static void Zapisz<Typ>(string plik, Typ obj)
        {
            if (string.IsNullOrEmpty(plik))
                throw new ArgumentNullException(nameof(plik));
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));
            XmlSerializer xSer = new XmlSerializer(typeof(Typ));
            using (var fs = new FileStream(plik, FileMode.Create))
            {
                xSer.Serialize(fs, obj);
            }
        }
        // Deserializacja
        public static Typ Pobierz<Typ>(string plik)
        {
            if (string.IsNullOrEmpty(plik))
                throw new ArgumentNullException(nameof(plik));
            var xSer = new XmlSerializer(typeof(Typ));
            using (var fs = new FileStream(plik, FileMode.Open))
            {
                return (Typ)xSer.Deserialize(fs);
            }
        }
    }

    [XmlRoot("KolekcjaTowarow")]
    public class ZbiorTowarow
    {
        [XmlArray("Towary"), XmlArrayItem("Towar")]
        public List<Towar> listaTowarow = null;

        public ZbiorTowarow(Towar[] tab)
        {
            listaTowarow = new List<Towar>(tab);
        }
        // konstruktor domyślny konieczny dla serializacji
        public ZbiorTowarow() { }
    }

    public class Towar
    {
        //[XmlAttribute("Nazwa")]
        public string Nazwa { get; set; }
        public double Cena { get; set; }
        public double Ilosc { get; set; }

        public Towar(string n1, double c1, double il)
        {
            Nazwa = n1;
            Cena = c1;
            Ilosc = il;
        }
        // konstruktor domyślny konieczny dla serializacji
        public Towar() { }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Serializacja i deserializacja XML";
            string plik = @"C:\Users\Remek\source\repos\Zadanie3\Towary.xml";

            // test zapisu(serializacji) obiektów do XML
            Towar[] tabTowary =
                    { new Towar("Długopis", 4.5, 10),
                        new Towar("Ołówek", 2.5, 25),
                        new Towar("Blok rysunkowy", 3.0, 15) };
            ZbiorTowarow obj = new ZbiorTowarow(tabTowary);
            ZapisOdczytXML.Zapisz(plik, obj);

            // test deserializacji 
            var kolekcjaTowarow = ZapisOdczytXML.Pobierz<ZbiorTowarow>(plik);
            foreach (var element in kolekcjaTowarow.listaTowarow)
            {
                Console.WriteLine($"{element.Nazwa,15} " +
                                    $"{element.Cena,5} " +
                                    $"{element.Ilosc,5}");
            }
            Console.ReadKey();
        }
    }
}