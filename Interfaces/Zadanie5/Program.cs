namespace Zadanie5
{
    interface IPremia
    {
        public double podstawaPremii { get; }
        double Premia();
    }

    class Pracownik : IPremia, IComparable<Pracownik>
    {
        protected string nazwisko;
        protected string imie;
        public double podstawaPremii { get; }

        public Pracownik(string naz, string im, double podstawaPremii)
        {
            nazwisko = naz;
            imie = im;
            this.podstawaPremii = podstawaPremii;
        }
        public virtual double Premia() => podstawaPremii * 0.1;

        public int CompareTo(Pracownik obj)
        {
            if(nazwisko == obj.nazwisko)
            {
                return 1;
            }
            else if(imie == obj.imie)
            {
                return 1;
            }
            return 0;
        }

        public void Sort()
        {
            Sort();
        }
    }

    class Dyrektor : Pracownik
    {
        public Dyrektor(string naz, string im, double pP) : base(naz, im, pP) { }
        public override double Premia()
        {
            return base.Premia() * 2;
        }

        public int CompareTo(Dyrektor other)
        {
            if(nazwisko == other.nazwisko)
            {
                return 1;
            }
            else if(imie == other.imie)
            {
                return 1;
            }
            return 0;
        }
    }

    class Klient
    {
        // Klasa Klient nie implementuje interfejsu IPremia
        string nazwisko;
        string imie;

        public Klient(string naz, string im)
        {
            nazwisko = naz;
            imie = im;
        }
    }

    class DyrektorNaczelny : Dyrektor
    {
        double kwotaSpecjalna;

        public DyrektorNaczelny(string naz, string im, double pP, double kS) : base(naz, im, pP)
        {
            kwotaSpecjalna = kS;
        }

        public override double Premia()
        {
            return base.Premia() + kwotaSpecjalna;
        }
    }

    class Program
    {
        static void Main()
        {
            // Tablica z elementami typu IPremia
            // Podczas definicji tablicy użyto rzutowania, które stanowi zabezpieczenie na wypadek 
            // próby wpisania obiektu klasy, która nie implementuje danego interfejsu (jak np. klasa Klient).
            IPremia[] tab = { new Pracownik("Kowalski", "Jan", 10000) as IPremia,
                              new Dyrektor("Nowak", "Adam", 10000) as IPremia,
                              new Klient("Testowy", "Tomasz") as IPremia,
                              new DyrektorNaczelny("Nowy", "Gosc", 10000, 150) as IPremia};

            // W pętli  wyświetli się premia dla dwóch obiektów (z klasy Pracownik i klasy Dyrektor), 
            // przy czym dla każdego z tych obiektów wywoła się właściwa wersja wirtualnej metody Premia.
            // Natomiast dla obiektu trzeciego (z klasy Klient) nic się nie wyświetli - dla tego obiektu 
            // próba rzutowania na typ IPremia zwraca null. 
            foreach (IPremia i1 in tab)
            {
                if (i1 != null)
                {
                    Console.WriteLine($"{i1.GetType().Name} {i1.Premia()}");
                }
            }
            Console.WriteLine("\n");

            foreach (IPremia i1 in tab)
            {
                //Console.WriteLine(i1.ToString());
            }
        }
    }
}





/*
 interface IPremia
    {
        double podstawaPremii { get; }
        double Premia();
    }

    class Pracownik : IPremia, IComparable<Pracownik>
    {
        string nazwisko;
        string imie;
        public double podstawaPremii { get; }

        public Pracownik(string naz, string im, double pP)
        {
            nazwisko = naz;
            imie = im;
            podstawaPremii = pP;
        }
        public virtual double Premia() => podstawaPremii * 0.1;

        public int CompareTo(Pracownik other)
        {
            return this.imie.CompareTo(other.imie);
        }
    }

    class Dyrektor : Pracownik
    {
        public Dyrektor(string naz, string im, double pP) : base(naz, im, pP) { }
        public override double Premia()
        {
            return base.Premia() * 2;
        }

        public int CompareTo(Dyrektor other)
        {
            return this.nazwisko.CompareTo(other.nazwisko);
        }
    }

    class Klient
    {
        // Klasa Klient nie implementuje interfejsu IPremia
        string nazwisko;
        string imie;
        public Klient(string naz, string im)
        {
            nazwisko = naz;
            imie = im;
        }

        public int CompareTo(Klient other)
        {
            return this.imie.CompareTo(other.imie);
        }
    }
 
 
 
 */