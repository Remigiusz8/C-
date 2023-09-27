using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    class Odcinek
    {
        public Punkt A;
        public Punkt B;

        public Odcinek(Punkt A, Punkt B)
        {
            this.A = A;
            this.B = B;
        }

        public class Punkt
        {
            private int x;
            private int y;

            public Punkt(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public int GetX() { return x; }
            public int GetY() { return y; }
        }
        
        public double Dlugosc()
        {
            return Math.Sqrt(Math.Pow(B.GetX()-A.GetX(),2) + Math.Pow(B.GetY()-A.GetY(),2));
        }
    }
}
