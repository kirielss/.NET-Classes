using System;

namespace Revisao05
{
    internal class Calc
    {
        public static double Dolar(double total, double indice)
        {
            return (total + total * 0.06) * indice;
        }
    }
}
