using System;
using System.Globalization;

namespace exec02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Masculino ou Feminino?");
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine("Qual sua altura?");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Agora digite seu nome, sexo, idade e altura respectivamente");
            string[] array = Console.ReadLine().Split(' ');
            string nome = array[0];
            string sexo = array[1];
            string idade = array[2];
            string altura = array[3];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }
}