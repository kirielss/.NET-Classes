using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao06
{
    internal class Estudante
    {
        public string Nome;
        public string Email;
        public int Quarto;

        public override string ToString()
        {
            return $"{Quarto}: {Nome}, {Email}";
        }
    }
}
