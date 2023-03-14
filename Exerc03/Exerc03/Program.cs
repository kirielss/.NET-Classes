using System;

namespace Exerc03
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();
            string maisVelha;

            Console.WriteLine("Dados da primeira pessoa:");
            p1.Nome = Console.ReadLine();
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            p2.Nome = Console.ReadLine();
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade == p2.Idade)
            {
                maisVelha = "Têm a mesma idade!!!";
            }
            else if (p1.Idade >= p2.Idade)
            {
                maisVelha = p1.Nome;
            }
            else
            {
                maisVelha = p2.Nome;
            }

            Console.WriteLine($"Pessoa mais velha: {maisVelha}");
        }
    }
}