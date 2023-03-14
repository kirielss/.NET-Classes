using System;
using System.Globalization;

namespace Course04
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos(int q)
        {
            Quantidade += q;
            return;
        }

        public void RemoverProdutos(int q)
        {
            Quantidade -= q;
            return;
        }

        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: $ ";
        }


    }
}
