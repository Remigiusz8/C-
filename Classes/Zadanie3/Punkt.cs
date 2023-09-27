using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    internal class Punkt
    {
        private int[] tab = new int[3];
        private int x = 0;
        private int y = 0;

        public Punkt(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Punkt(int[] tab)
        {
            this.tab = tab;
        }

        public void Wyswietl()
        {
            Console.WriteLine($"({x}, {y})");
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }

        public static bool NaProstej(Punkt[] tab)
        {
            double dlugoscAB = Math.Sqrt(Math.Pow(tab[1].getX() - tab[0].getX(), 2) + Math.Pow(tab[1].getY() - tab[0].getY(), 2));
            double dlugoscAC = Math.Sqrt(Math.Pow(tab[2].getX() - tab[0].getX(), 2) + Math.Pow(tab[2].getY() - tab[0].getY(), 2));
            double dlugoscBC = Math.Sqrt(Math.Pow(tab[1].getX() - tab[2].getX(), 2) + Math.Pow(tab[1].getY() - tab[2].getY(), 2));

            if (dlugoscAB + dlugoscAC == dlugoscBC || dlugoscAB + dlugoscBC == dlugoscAC || dlugoscAC + dlugoscBC == dlugoscAB)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
