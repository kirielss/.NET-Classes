using System;
using System.Globalization;

namespace Revisao02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario x = new Funcionario();

            Console.Write("Nome: " );
            x.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            x.SalarioBruto = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );
            Console.Write("Imposto: ");
            x.Imposto = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );

            Console.WriteLine("Funcionário: " + x);

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            x.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Dados atualizados: " + x);
        }
    }
}