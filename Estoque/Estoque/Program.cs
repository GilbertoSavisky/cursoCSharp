using System;
using System.Globalization;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade :");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: {produto}");

            Console.WriteLine();
            Console.Write("Digite o num de produtos a ser adicionados ao estoque:");

            int qte = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {produto}");

            Console.WriteLine();
            Console.Write("Digite o num de produtos a ser removidos ao estoque:");

            qte = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {produto}");
        }
    }
}
