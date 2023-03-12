using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte x = 100;
            byte n1 = 255;
            int n2 = 1000;
            int n3 =  2147483647;
            long n4 = 2147483648L;
            bool completo = false;
            char genero = 'F';
            char letra = '\u0046';
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria Joestar";
            nome = "Joana D'arc";
            object obj1 = "Miguel de Cervantes";
            object obj2 = 69.41;
            int x1 = int.MinValue;
            int x2 = int.MaxValue;
            sbyte x3 = sbyte.MinValue;
            sbyte x4 = sbyte.MaxValue;
            decimal x5 = decimal.MaxValue;

            n1++;

            Console.WriteLine(x);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(x3);
            Console.WriteLine(x4);
            Console.WriteLine(x5);
        }
    }
}