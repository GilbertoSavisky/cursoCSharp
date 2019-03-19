using System;

namespace PensaoEstudantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a quantidade de quartos para alugar: ");
            int n = int.Parse(Console.ReadLine());

            Estudantes[] estudantes = new Estudantes[10];

            for (int i=0; i < n; i++)
            {
                
                Console.Write($"{i+1}° Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.Write($"{i+1}° Nome: ");
                string nome = Console.ReadLine();
                Console.Write($"{i+1}° eMAIL: ");
                string email = Console.ReadLine();
                Console.WriteLine();
                estudantes[quarto] = new Estudantes { Nome = nome, Email = email };
            }

            Console.WriteLine("Relatório de quartos alugados:");
            for(int i = 0; i < 10; i++)
            {
                if(estudantes[i] != null)
                    Console.WriteLine($"{i}: {estudantes[i]}");
            }
        }
    }
}
