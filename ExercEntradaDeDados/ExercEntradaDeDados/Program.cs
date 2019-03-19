using System;
using System.Globalization;

namespace Exercicios2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com seu último nome, idade e altura (tudo na mesma linha):");
            string[] v = Console.ReadLine().Split(' ');
            string sobrenome = v[0];
            int idade = int.Parse(v[1]);
            float altura = float.Parse(v[2]);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("f2"), CultureInfo.CurrentCulture);
            Console.WriteLine(v[0]);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("f2"), CultureInfo.CurrentCulture);
        }
    }
}
