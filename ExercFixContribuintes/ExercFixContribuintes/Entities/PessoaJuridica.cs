using System;
using System.Collections.Generic;
using System.Text;

namespace ExercFixContribuintes.Entities
{
    class PessoaJuridica : Pessoa
    {
        public int NumFunc { get; set; }

        public PessoaJuridica(int numFunc, string nome, double rendaAnual) : base(nome, rendaAnual)
        {
            NumFunc = numFunc;
        }

        public override double CalcularImposto()
        {
            if(NumFunc < 10)
            {
                return RendaAnual * 0.16;
            }
            else
            {
                return RendaAnual * 0.14;
            }
        }
    }
}
