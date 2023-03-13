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

            Console.WriteLine("Questão 06");
            double numb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



            if ((numb >= 0) && (numb <= 25))
            {
                Console.WriteLine("Intervalo [0,25]");
            } else if ((numb > 25) && (numb <= 50))
            {
                Console.WriteLine("Intervalo (25,50]");
            } else if ((numb > 50) && (numb <= 75))
            {
                Console.WriteLine("Intervalo (50,75]");
            } else if ((numb > 75) && (numb <= 100))
            {
                Console.WriteLine("Intervalo (75,100]");
            } else
            {
                Console.WriteLine("Fora de intervalo");
            }

            Console.WriteLine("Questão 07");
            string[] arr4 = Console.ReadLine().Split(' ');

            double x = double.Parse(arr4[0], CultureInfo.InvariantCulture);
            double y = double.Parse(arr4[1], CultureInfo.InvariantCulture);

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            } else if (x == 0 || y == 0)
            {
                if (x == 0)
                {
                    Console.WriteLine("Eixo X");
                } else
                {
                    Console.WriteLine("Eixo Y");
                }
            } else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            } else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            } else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            } else
            {
                Console.WriteLine("Q2");
            }

            Console.WriteLine("Questão 08");
            double z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double result = 0.0;

            if (z >= 0 && z <= 2000)
            {
                Console.WriteLine("Isento");
            } else if (z > 2000 && z <= 3000)
            {
                z -= 2000;
                result = z * 0.08;
                Console.WriteLine("R$ " + result.ToString("F2", CultureInfo.InvariantCulture));
            } else if (z > 3000 && z <= 4500)
            {
                z -= 3000;
                result = z * 0.18 + 80;
                Console.WriteLine("R$ " + result.ToString("F2", CultureInfo.InvariantCulture));
            } else
            {
                z -= 4500;
                result = z * 0.28 + 270 + 80;
                Console.WriteLine("R$ " + result.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}