using System;

namespace Course3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 5 frases");
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string[] array = Console.ReadLine().Split(' ');
            string a = array[0];
            string b = array[1];
            string c = array[2];

            Console.WriteLine("Você digitou o seguinte:");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}