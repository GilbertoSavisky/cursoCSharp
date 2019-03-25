using System.Collections.Generic;
using System.Globalization;
using System;
using ExercFixContribuintes.Entities;

namespace ExercFixContribuintes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoa = new List<Pessoa>();

            Console.Write("Digite o número de contribuintes -> ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do contribuinte #{i}");
                Console.Write("Física ou Jurídica (f/j)? ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda Anual: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (c == 'f')
                {
                    Console.Write("Despesas Médicas: ");
                    double dm = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    pessoa.Add(new PessoaFisica(dm, nome, rendaAnual));
                }
                else
                {
                    Console.Write("Número de funcionários: ");
                    int num = int.Parse(Console.ReadLine());
                    pessoa.Add(new PessoaJuridica(num, nome, rendaAnual));
                }
                
            }

            Console.WriteLine("\nIMPOSTOS PAGOS:");
            double soma=0;
            foreach (Pessoa p in pessoa)
            {
                soma += p.CalcularImposto();
                Console.WriteLine($"Nome: {p.Nome} - R$ {p.CalcularImposto()}");
            }
            Console.WriteLine($"Total de impostos: {soma}");
        }
    }
}
