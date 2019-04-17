using System;
using System.Collections.Generic;


namespace Contratos.Domain
{
    class Contrato
    {
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public double TotalValor { get; set; }
        public List<Parcela> Parcelas { get; set; }

        public Contrato(int numero, DateTime data, double totalValor)
        {
            Numero = numero;
            Data = data;
            TotalValor = totalValor;
            Parcelas = new List<Parcela>();
        }

        public void AddParcelas(Parcela parcela)
        {
            Parcelas.Add(parcela);
        }
    }
}
