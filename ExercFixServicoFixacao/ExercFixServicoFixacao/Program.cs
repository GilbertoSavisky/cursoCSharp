using System;
using System.Globalization;
using Contratos.Domain;
using Contratos.Service;
using System.Threading.Tasks;

namespace ExercFixContratos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a data:");
            Console.Write("Numero: ");
            int contratoNumber = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/MM/yyyy): ");
            DateTime dataContrato = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor do Contrato: ");
            double valorContrato = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre numero de parcelas: ");
            int meses = int.Parse(Console.ReadLine());

            Contrato meuContrato = new Contrato(contratoNumber, dataContrato, valorContrato);

            ContratoServico contratoServico = new ContratoServico(new ServicoDePagamento());
            contratoServico.ProcessoContrato(meuContrato, meses);

            Console.WriteLine("Parcelas:");
            foreach(Parcela p in meuContrato.Parcelas)
            {
                Console.WriteLine(p);
            }
        }
    }
}
