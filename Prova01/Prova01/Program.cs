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
            Console.WriteLine();
            Console.WriteLine($"SOMA = {a + b}");
            Console.WriteLine();

            Console.WriteLine("Questão 2");
            double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine($"A={(3.14159 * Math.Pow(r,2)).ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine();

            Console.WriteLine("Questão 3");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            int DIFERENCA = (A * B - C * D);
            Console.WriteLine();
            Console.WriteLine($"DIFERENCA = {DIFERENCA}");
            Console.WriteLine();

            Console.WriteLine("Questão 4");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario = y * z;
            Console.WriteLine();
            Console.WriteLine($"NUMBER = {x}");
            Console.WriteLine($"SALARY = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();

            Console.WriteLine("Questão 5");
            string[] array1 = Console.ReadLine().Split(' ');
            string[] array2 = Console.ReadLine().Split(' ');

            int qtd1 = int.Parse(array1[1]);
            int qtd2 = int.Parse(array2[1]);

            double v1 = double.Parse(array1[2], CultureInfo.InvariantCulture);
            double v2 = double.Parse(array2[2], CultureInfo.InvariantCulture);

            double conta = (qtd1 * v1) + (qtd2 * v2);
            Console.WriteLine();
            Console.WriteLine("VALOR A PAGAR: R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            Console.WriteLine("Questão 6");
            string[] lastArray = Console.ReadLine().Split(' ');

            double X = double.Parse(lastArray[0], CultureInfo.InvariantCulture);
            double Y = double.Parse(lastArray[1], CultureInfo.InvariantCulture);
            double Z = double.Parse(lastArray[2], CultureInfo.InvariantCulture);

            double ITEMA = (X * Z)/2;
            double ITEMB = 3.14159 * Math.Pow(Z, 2);
            double ITEMC = ((X + Y) * Z) / 2;
            double ITEMD = Math.Pow(Y, 2);
            double ITEME = X * Y;

            Console.WriteLine();
            Console.WriteLine("TRIANGULO: " + ITEMA.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + ITEMB.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + ITEMC.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + ITEMD.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + ITEME.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}