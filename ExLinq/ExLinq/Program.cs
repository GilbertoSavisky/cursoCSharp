using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;

namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o caminho do arquivo :");
            string path = Console.ReadLine();
            List<Funcionario> func = new List<Funcionario>();

            using (StreamReader sr = File.OpenText(path))
            {
                while(!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string nome = fields[0];
                    string email = fields[1];
                    double salario = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    func.Add(new Funcionario(nome, email,salario));
                }
            }

            Console.Write("Entre com um salario: ");
            double sal = double.Parse(Console.ReadLine());

            var emails = func.Where(f => f.Salario > sal).OrderBy(f => f.Email).Select(f => f.Email);
            Console.WriteLine("Email da pessoa onde o salario é maior que = " + sal);

            foreach (string email in emails)
                Console.WriteLine(email);


            var sum = func.Where(f => f.Nome[0] == 'M').Sum(f => f.Salario);
            Console.WriteLine("Soma dos salarios das pessoas que comecam com a letra M = " + sum.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
