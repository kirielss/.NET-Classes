using System;
using System.Collections.Generic;

namespace Course9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            // aqui eu poderia abrir chaves {} e já instanciar com valores, mas n farei nessa

            list.Add("Maria");
            list.Add("Antonieta");
            list.Add("Rodrigo");
            list.Add("Faro");
            list.Insert(3, "fkn");

            foreach (string nome in list)
            {
                Console.WriteLine(nome);
            }

            string teste = list.Find(Check);
            Console.WriteLine("Primeiro nome que começa com A: " + teste);

            static bool Check(string s)
            {
                return s[0] == 'A';
            }


        }
    }
}