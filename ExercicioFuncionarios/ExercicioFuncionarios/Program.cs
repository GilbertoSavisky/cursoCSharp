using System;
using System.Globalization;

namespace ExercicioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();
            Console.WriteLine("Entre com os dados do funcionário:");
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Funcionário: {func}");

            Console.Write("\n\nDigite a porcentagem para aumentar o salário: ");
            Console.Write("Porcentagem?: ");
            func.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine($"\n\nDados atualizados: {func}");

        }
    }
}
