using System;
using System.ComponentModel;
using System.Globalization;

namespace Prova04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 01");
            int X = int.Parse(Console.ReadLine());

            for (int i = 1; i <= X; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Questão 02");
            int N = int.Parse(Console.ReadLine());
            int num = 0;
            int IN = 0;
            int OUT = 0;

            for (int i = 1; i <= N; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (num >= 10 && num <= 20)
                {
                    IN++;
                } else
                {
                    OUT++;
                }
            }

            Console.WriteLine($"{IN} in");
            Console.WriteLine($"{OUT} out");

            Console.WriteLine("Questão 03");
            int N3 = int.Parse(Console.ReadLine());

            for ( int i = 1; i <= N3; i++)
            {
                string[] arr = Console.ReadLine().Split(' ');
                double a = double.Parse(arr[0], CultureInfo.InvariantCulture);
                double b = double.Parse(arr[1], CultureInfo.InvariantCulture);
                double c = double.Parse(arr[2], CultureInfo.InvariantCulture);

                Console.WriteLine((((2 * a) + (3 * b) + (5 * c)) / 10).ToString("F1", CultureInfo.InvariantCulture));
            }

            Console.WriteLine("Questão 04");
            int N4 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N4; i++)
            {
                string[] arr = Console.ReadLine().Split(' ');
                double a = double.Parse(arr[0]);
                double b = double.Parse(arr[1]);

                if (b == 0)
                {
                    Console.WriteLine("divisao impossivel");
                } else
                {
                    Console.WriteLine((a/b).ToString("F1", CultureInfo.InvariantCulture));
                }

            }

            Console.WriteLine("Questão 05");

            int N5 = int.Parse(Console.ReadLine());
            int result = 1;


            if (N5 == 0)
            {
                Console.WriteLine(1);
            } else
            {
                for (int i = N5; i > 1; i--) {
                    result = result * i;
                }
                Console.WriteLine(result);
            }

            Console.WriteLine("Questão 06");

            int N6 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N6; i++)
            {
                if (N6 % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Questão 07");

            int N7 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N7; i++)
            {
                Console.Write(i + " ");
                Console.Write(Math.Pow(i, 2) + " ");
                Console.WriteLine(Math.Pow(i, 3));
            }
        }
    }
}