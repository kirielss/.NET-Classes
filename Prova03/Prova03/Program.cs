using System;

namespace Prova03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 01");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");

            Console.WriteLine("Questão 02");
            string[] arr = Console.ReadLine().Split(' ');
            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);

            while (a != 0 && b != 0)
            {
                if (a > 0 && b > 0)
                {
                    Console.WriteLine("primeiro");
                } else if (a < 0 && b > 0)
                {
                    Console.WriteLine("segundo");
                } else if (a < 0 && b < 0)
                {
                    Console.WriteLine("terceiro");
                } else
                {
                    Console.WriteLine("quarto");
                }
                arr = Console.ReadLine().Split(' ');
                a = int.Parse(arr[0]);
                b = int.Parse(arr[1]);
            }

            Console.WriteLine("Questão 03");
            int x = int.Parse(Console.ReadLine());
            int alcool = 0;
            int gasol = 0;
            int diesel = 0;

            while (x != 4)
            {
                if (x == 1)
                {
                    alcool++;
                } else if (x == 2)
                {
                    gasol++;
                } else if (x == 3)
                {
                    diesel++;
                }
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasol}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}