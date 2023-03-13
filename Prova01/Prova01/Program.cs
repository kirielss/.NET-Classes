using System;
using System.Globalization;

namespace Prova01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 1");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a + b);

            Console.WriteLine("Questão 2");
            double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine((3.14159 * Math.Pow(r,2)).ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("Questão 3");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            int DIFERENCA = (A * B - C * D);
            Console.WriteLine(DIFERENCA);

            Console.WriteLine("Questão 4");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario = y * z;
            Console.WriteLine(x);
            Console.WriteLine(salario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}