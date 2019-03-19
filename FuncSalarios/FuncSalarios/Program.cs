using System;
using System.Collections.Generic;
using System.Globalization;

namespace FuncionariosSalarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos empregados quer registrar? ");
            int qtde = int.Parse(Console.ReadLine());
            List<Funcionario> func = new List<Funcionario>();
            Console.WriteLine("_______________________________________");
            for(int i=0; i < qtde; i++)
            {
                Console.WriteLine("\nFuncionário #"+(i+1)+":");
                
                Console.Write("Id: ");
                int id2 = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                func.Add(new Funcionario { Id = id2, Nome = nome, Salario= salario});

            }
            Console.WriteLine("_______________________________________\n");
            foreach (Funcionario f in func)
                Console.WriteLine(f);


            Console.Write("\nEntre com o id do funcionário que você quer aumentar: ");
            int id = int.Parse(Console.ReadLine());
            Funcionario func2 = func.Find(x => x.Id == id);

            if(func2 != null)
            {
                Console.Write("\nEntre com a porcentagem: ");
                int porcentagem = int.Parse(Console.ReadLine());
                func2.IncrementarSalario(func2, porcentagem);
            }
            else
                Console.WriteLine("Este Id não existe!");
            Console.WriteLine("_______________________________________\n");
            foreach (Funcionario f in func)
                Console.WriteLine(f);
        }
        
    }
}
