using System;
using System.Collections.Generic;

namespace ExercicioConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            HashSet<int> codA, codB, codC, total;
            codA = new HashSet<int>();
            codB = new HashSet<int>();
            codC = new HashSet<int>();
            total = new HashSet<int>();

            Console.WriteLine("O curso A possui quantos alunos? ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A:");
            for(int i = 0; i < A; i++)
            {
                codA.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("O curso B possui quantos alunos? ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso B:");
            for (int i = 0; i < B; i++)
            {
                codB.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("O curso C possui quantos alunos? ");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso C:");
            for (int i = 0; i < C; i++)
            {
                codC.Add(int.Parse(Console.ReadLine()));
            }

            codA.UnionWith(codB);
            codA.UnionWith(codC);

            foreach (int t in codA)
            {
                Console.WriteLine("Total : "+t);
            }
            Console.WriteLine("Total de alunos: "+codA.Count);

        }
    }
}
