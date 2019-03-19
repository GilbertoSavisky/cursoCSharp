using System;
using System.Globalization;

namespace ExercicioAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.WriteLine("Entre com os dados do aluno: ");
            Console.Write("Nome: ");
            aluno.Nome = Console.ReadLine();

            Console.Write("Nota 1: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Nota 2: ");
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Nota 3: ");
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            aluno.Situacao();
        }
    }
}
