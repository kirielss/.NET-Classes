using System;
using System.Globalization;

namespace Exerc04
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario a, b;
            a = new Funcionario();
            b = new Funcionario();
            double medio;

            Console.WriteLine("Dados do primeiro funcionário:");
            a.Nome = Console.ReadLine();
            a.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            b.Nome = Console.ReadLine();
            b.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            medio = (a.Salario + b.Salario) / 2;

            Console.WriteLine("Salário médio = " + medio.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}