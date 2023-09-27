using System.Security.Cryptography.X509Certificates;

namespace Zadanie3
{
    class Matrix
    {
        private int a11;
        private int a12;
        private int a21;
        private int a22;

        public Matrix(int a11, int a12, int a21, int a22)
        {
            this.a11 = a11;
            this.a12 = a12;
            this.a21 = a21;
            this.a22 = a22;
        }

        public override string ToString()
        {
            return $"{a11} {a12}\n{a21} {a22}";
        }

        public static Matrix operator * (Matrix M1, Matrix M2)
        {
            return new Matrix((M1.a11 * M2.a11 + M1.a12 * M2.a21),(M1.a11 * M2.a12 + M1.a12 * M2.a22),(M1.a21 * M2.a11 + M1.a22 * M2.a21),(M1.a21 * M2.a12 + M1.a22 * M2.a22));
        }

        public static Matrix operator + (Matrix M1, Matrix M2)
        {
            return new Matrix(M1.a11 + M2.a11, M1.a12 + M2.a12, M1.a21 + M2.a21, M1.a22 + M2.a22);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix A = new Matrix(3,4, 7, 8);
            Matrix B = new Matrix(0, 1, 1, 0);
            Console.WriteLine(A.ToString());
            Console.WriteLine();
            Console.WriteLine(B.ToString());
            Console.WriteLine();
            Console.WriteLine(A+B);
            Console.WriteLine();
            Console.WriteLine(A*B);
        }
    }
}