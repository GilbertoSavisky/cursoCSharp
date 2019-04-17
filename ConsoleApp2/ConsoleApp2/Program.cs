using System;
namespace AvaliacaoDiscursiva1
{
    class Program
    {
        static void Main(string[] args)
        {
            string porte;
            double idade;
            Console.Write("Informe o porte do cachorro: ");
            porte = Console.ReadLine();
            Console.Write("Informe a idade: ");
            idade = double.Parse(Console.ReadLine());

            idade = CalcularIdade(idade, porte);
            Console.WriteLine($"A idade real do cachorro de porte {porte} é: {idade}");
        }

        public static double CalcularIdade(double idade, string porte)
        {
            if (porte.Equals("pequeno"))
                return idade * 12.5;
            else if (porte.Equals("medio"))
                return idade * 10.5;
            else
                return idade * 9;
        }
    }
}
