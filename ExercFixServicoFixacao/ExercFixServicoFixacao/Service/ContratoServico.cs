using System;
using Contratos.Domain;

namespace Contratos.Service
{
    class ContratoServico
    {
        private IServicoOnlinePagamento servicoOnlinePagamento;

        public ContratoServico(IServicoOnlinePagamento servicoOnlinePagamento)
        {
            this.servicoOnlinePagamento = servicoOnlinePagamento;
        }

        public void ProcessoContrato(Contrato contrato, int meses)
        {
            double quotaBasica = contrato.TotalValor / meses;
            for(int i = 1; i <= meses; i++)
            {
                DateTime data = contrato.Data.AddMonths(i);
                double updateQuota = quotaBasica + servicoOnlinePagamento.Interesse(quotaBasica, i);
                double fullQuota = updateQuota + servicoOnlinePagamento.TaxaPagamento(updateQuota);
                contrato.AddParcelas(new Parcela(data, fullQuota));
            }
        }
    }
}
