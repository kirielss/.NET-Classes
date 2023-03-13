using System;
using System.Globalization;

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

            Console.WriteLine("Questão 04");
            string[] arr2 = Console.ReadLine().Split(' ');

            int ini = int.Parse(arr2[0]);
            int fim = int.Parse(arr2[1]);

            if (ini >= fim)
            {
                fim += 24;
            }
            Console.WriteLine($"O JOGO DUROU {fim - ini} HORA(S)");

            Console.WriteLine("Questão 05");
            string[] arr3 = Console.ReadLine().Split(' ');

            int item = int.Parse(arr3[0]);
            int qtd = int.Parse(arr3[1]);

            double preco = 0.0;

            if (item == 1)
            {
                preco = 4.00;
            } else if (item == 2)
            {
                preco = 4.50;
            } else if (item == 3)
            {
                preco = 5.00;
            } else if (item == 4)
            {
                preco = 2.00;
            } else if (item == 5)
            {
                preco = 1.50;
            } else
            {
                Console.WriteLine("Pedido não encontrado no cardápio!");
            }

            double total = preco * qtd;
            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}