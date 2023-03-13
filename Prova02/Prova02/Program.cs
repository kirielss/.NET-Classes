using System;

namespace Prova02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 01");
            int num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("NEGATIVO");
            } else
            {
                Console.WriteLine("NÃO NEGATIVO");
            }

            Console.WriteLine("Questão 02");
            int num2 = int.Parse(Console.ReadLine());
            if (num2 % 2 == 0)
            {
                Console.WriteLine("PAR");
            } else
            {
                Console.WriteLine("IMPAR");
            }

            Console.WriteLine("Questão 03");
            string[] arr = Console.ReadLine().Split(' ');

            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);

            if ((a % b == 0) || (b % a == 0))
            {
                Console.WriteLine("Sao Multiplos");
            } else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}