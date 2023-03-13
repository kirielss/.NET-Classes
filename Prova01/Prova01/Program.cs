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
            Console.WriteLine($"SOMA = {a + b}");

            Console.WriteLine("Questão 2");
            double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"A={(3.14159 * Math.Pow(r,2)).ToString("F4", CultureInfo.InvariantCulture)}");

            Console.WriteLine("Questão 3");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            int DIFERENCA = (A * B - C * D);
            Console.WriteLine($"DIFERENCA = {DIFERENCA}");

            Console.WriteLine("Questão 4");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario = y * z;
            Console.WriteLine($"NUMBER = {x}");
            Console.WriteLine($"SALARY = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine("Questão 5");
            string[] array1 = Console.ReadLine().Split(' ');
            string[] array2 = Console.ReadLine().Split(' ');

            int qtd1 = int.Parse(array1[1]);
            int qtd2 = int.Parse(array2[1]);

            double v1 = double.Parse(array1[2], CultureInfo.InvariantCulture);
            double v2 = double.Parse(array2[2], CultureInfo.InvariantCulture);

            double conta = (qtd1 * v1) + (qtd2 * v2);
            Console.WriteLine("VALOR A PAGAR: R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}