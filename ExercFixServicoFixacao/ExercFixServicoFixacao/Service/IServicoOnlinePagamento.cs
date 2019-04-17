namespace Contratos.Service
{
    interface IServicoOnlinePagamento
    {
        double TaxaPagamento(double valor);
        double Interesse(double valor, int meses);
    }
}
