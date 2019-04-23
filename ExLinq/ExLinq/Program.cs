using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;

namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o caminho do arquivo :");
            string path = Console.ReadLine();
            List<Produto> prod = new List<Produto>();

            using (StreamReader sr = File.OpenText(path))
            {
                while(!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string nome = fields[0];
                    double preco = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    prod.Add(new Produto(nome, preco));
                }
            }

            var avg = prod.Select(p => p.Preco).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Média dos preços= "+avg.ToString("F2", CultureInfo.InvariantCulture));
            var nomes = prod.Where(p => p.Preco < avg).OrderByDescending(p => p.Nome).Select(p => p.Nome);

            foreach(string nome in nomes)
                Console.WriteLine(nome);
        }
    }
}
