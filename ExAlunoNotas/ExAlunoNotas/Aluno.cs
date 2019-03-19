using System;
using System.Globalization;

namespace ExercicioAluno
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal()
        {
            return (Nota1 + Nota2 + Nota3);
        }
        public void Situacao()
        {
            double x = 60.00;
            if (NotaFinal() < x)
            {
                Console.WriteLine($"\nNota Final: {NotaFinal()}");
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"Faltaram {x.ToString("F2")} pontos", CultureInfo.InvariantCulture);
            }
            else
            {
                Console.WriteLine($"Nota Final: {NotaFinal()}");
                Console.WriteLine("APROVADO");
            }
        }
    }
}
