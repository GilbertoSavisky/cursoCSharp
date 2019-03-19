using System;
using System.Globalization;

namespace ExercicioRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();
            Console.WriteLine("Entre com a largura e altura do retângulo:");
            Console.Write("Largura: ");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Altura: ");
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine($"Área do retângulo: {ret.Area()}");

            Console.WriteLine();
            Console.WriteLine($"Perímetro do retângulo: {ret.Perimetro()}");

            Console.WriteLine();
            Console.WriteLine($"Diagonal do retângulo: {ret.Diagonal()}");
        }
    }
}
