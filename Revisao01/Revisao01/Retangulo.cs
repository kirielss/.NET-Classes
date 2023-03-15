using System;
using System.Globalization;

namespace Revisao01
{
    internal class Retangulo
    {
        public double B;
        public double H;

        public double Area()
        {
            return B * H;
        }

        public double Perimetro()
        {
            return 2 * (B + H);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(B, 2) + Math.Pow(H, 2));
        }

        public override string ToString()
        {
            return "AREA = " + Area().ToString("F2", CultureInfo.InvariantCulture) + Environment.NewLine + "PERÍMETRO = " + Perimetro().ToString("F2", CultureInfo.InvariantCulture) + Environment.NewLine + "DIAGONAL = " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
