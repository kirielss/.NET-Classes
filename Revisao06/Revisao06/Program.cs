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

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Aluguel #" + i);

                Console.Write("Digite o nome do estudante: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o email do estudante: ");
                string email = Console.ReadLine();

                Console.Write("Digite o número do quarto desejado entre 0 e 9: ");
                int quarto = int.Parse(Console.ReadLine());

                pensionato[quarto] = new Estudante(nome, email);

            }

            for (int i = 0; i < pensionato.Length; i++)
            {
                if (pensionato[i] != null)
                {
                    Console.WriteLine(i + ": " + pensionato[i]);
                }
            }
        }
    }
}