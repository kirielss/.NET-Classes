using System;
using System.Globalization;

namespace Revisao03
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno x = new Aluno();

            Console.Write("Nome do aluno: ");
            x.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            x.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + x.Media().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(x.AprovadoCheck());
        }
    }
}