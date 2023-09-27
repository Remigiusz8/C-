using System;
namespace Zadanie4
{
    
    internal class ClassA
    {
        public static int MethodA()
        {
            return 100;
        }
    }

    internal class ClassB
    {
        public static int MethodB()
        {
            return 200;      
        }
    }

    internal class Program
    {
        delegate int Del();

        static void Main(string[] args)
        {
            Del del1 = ClassA.MethodA;
            Del del2 = ClassB.MethodB;
            Del del = del1 + del2;
            Console.WriteLine(del());
        }
    }
}