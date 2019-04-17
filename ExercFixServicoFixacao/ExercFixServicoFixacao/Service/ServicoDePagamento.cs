namespace Contratos.Service
{
    class ServicoDePagamento : IServicoOnlinePagamento
    {
        private const double taxaPagamento = 0.02;
        private const double MonthlyInterest = 0.01;

        public double Interesse(double valor, int meses)
        {
            return valor * MonthlyInterest * meses;
        }

        public double TaxaPagamento(double valor)
        {
            return valor * taxaPagamento;
        }
    }
}
