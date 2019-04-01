using System;
using Account_ExcFixacao.Entities.Exceptions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_ExcFixacao
{
    class Account
    {
        public int Number { get; set; }
        public string Nome { get; set; }
        public double Balanco { get; set; }
        public double LimiteSaque { get; set; }

        public Account()
        {
        }

        public Account(int number, string nome, double balanco, double limiteSaque)
        {
            Number = number;
            Nome = nome;
            Balanco = balanco;
            LimiteSaque = limiteSaque;
        }

        public void Deposito(double valor)
        {
            Balanco += valor;
        }

        public void Saque(double valor)
        {
            if(valor > LimiteSaque)
            {
                throw new DominioException("O valor excede o limite de saque!");
            }
            if(valor > Balanco)
            {
                throw new DominioException("Saldo insuficiente!");
            }
            Balanco -= valor;
        }

    }
}
