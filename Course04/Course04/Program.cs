using System;
using System.Globalization;

namespace Course04
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto x = new Produto();
            double total;

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            x.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            x.Quantidade = int.Parse(Console.ReadLine());

            total = x.ValorTotalEmEstoque();
            Console.WriteLine("Dados do produto: " + x + total.ToString("F2", CultureInfo.InvariantCulture));

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            x.AdicionarProdutos(int.Parse(Console.ReadLine()));

            total = x.ValorTotalEmEstoque();
            Console.WriteLine("Dados atualizados: " + x + total.ToString("F2", CultureInfo.InvariantCulture));

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            x.RemoverProdutos(int.Parse(Console.ReadLine()));

            total = x.ValorTotalEmEstoque();
            Console.WriteLine("Dados atualizados: " + x + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}