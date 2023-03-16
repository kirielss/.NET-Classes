using System;
using System.Globalization;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            double inicial = -1;
            Console.Write("Entre com o número da conta: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Entre com o nome do titular da conta: ");
            string pessoa = Console.ReadLine();

            while (!(pessoa != null && pessoa.Split(' ').Length > 1))
            {
                Console.WriteLine("Atenção! Você deve digitar seu nome e sobrenome!");
                pessoa = Console.ReadLine();
            }

            while (inicial == -1)
            {
                Console.Write("Haverá depósito inicial? (s/n) ");
                char resp = char.Parse(Console.ReadLine());
                if (resp == 's')
                {
                    Console.Write("Entre com o valor de depósito inicial: ");
                    inicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                else if (resp == 'n')
                {
                    inicial = 0;
                } else
                {
                    Console.WriteLine("Resposta ínválida. Digite apenas um caractere 's' ou 'n'");
                }
            }

            Conta x = new Conta(pessoa, num, inicial);

            Console.WriteLine("Dados da conta: " + x);

            Console.Write("Entre com um valor para depósito: ");
            x.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados: " + Environment.NewLine + x);

            Console.Write("Entre com um valor para saque: ");
            x.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados: " + Environment.NewLine + x);



        }
    }
}