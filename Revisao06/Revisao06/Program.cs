using System;
using System.Globalization;

namespace Revisao06
{
    class Program
    {
        static void Main(string[] args)
        {

            Estudante[] pensionato = new Estudante[10];

            Console.Write("Digite o número de estudantes que vão alugar quartos: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.Write("Digite o nome do estudante: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o email do estudante: ");
                string email = Console.ReadLine();
                Console.Write("Digite o número do quarto desejado entre 1 e 10: ");
                int quarto = int.Parse(Console.ReadLine());

                pensionato[i] = new Estudante { Nome = nome, Email = email, Quarto = quarto };

            }

            for (int i = 0; i < pensionato.Length; i++)
            {
                Console.WriteLine(pensionato[i]);
            }
        }
    }
}