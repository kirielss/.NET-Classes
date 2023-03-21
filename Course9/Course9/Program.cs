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
            list.Add("Cleiton");
            list.Insert(4, "Asriel");

            foreach (string nome in list)
            {
                Console.WriteLine(nome);
            }

            string teste = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro nome que começa com A: " + teste);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Último nome que começa com A: " + s2);

            int index1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Posição do primeiro nome começado com A: " + index1);

            int index2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Posição do último nome começado com A: " + index2);

        }
    }
}