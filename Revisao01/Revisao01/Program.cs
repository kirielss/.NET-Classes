using System;
using System.Globalization;

namespace Revisao01
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo x = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo");
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.H = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(x);
        }
    }
}