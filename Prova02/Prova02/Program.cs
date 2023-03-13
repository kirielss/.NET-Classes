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
        }
    }
}