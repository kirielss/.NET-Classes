using System;

namespace Course8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[]
            {
                "Maria",
                "Joao",
                "Francisco"
            };
            for (int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }

            Console.WriteLine("----------------------------------------");

            foreach (string nome in vect)
            {
                Console.WriteLine(nome);
            }
        }
    }
}