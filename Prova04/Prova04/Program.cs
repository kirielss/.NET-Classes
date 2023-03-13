using System;
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
        }
    }
}