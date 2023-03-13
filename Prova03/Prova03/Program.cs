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

        }
    }
}