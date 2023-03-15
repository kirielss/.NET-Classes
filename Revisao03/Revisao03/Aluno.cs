using System;
using System.Globalization;

namespace Revisao03 
{
    internal class Aluno
    {
        public string Nome;
        public double N1;
        public double N2;
        public double N3;

        public double Media()
        {
            return (N1 + N2 + N3);
        }

        public string AprovadoCheck()
        {
            if (Media() > 60)
            {
                return "APROVADO";
            }
            else
            {
                return "REPROVADO" + Environment.NewLine + "FALTARAM " + (60 - Media()).ToString("F2", CultureInfo.InvariantCulture) + " PONTOS";
            }
        }
    }
}
