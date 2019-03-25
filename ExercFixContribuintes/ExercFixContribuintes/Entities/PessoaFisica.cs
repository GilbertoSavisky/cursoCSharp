namespace ExercFixContribuintes.Entities
{
    class PessoaFisica : Pessoa
    {
        public double GastosSaude { get; set; }

        public PessoaFisica(double gastosSaude, string nome, double rendaAnual) : base(nome, rendaAnual)
        {
            GastosSaude = gastosSaude;
        }

        public override double CalcularImposto()
        {
            double imposto = 0;
            if (GastosSaude > 0)
            {
                imposto = GastosSaude * 0.5;
            }
            if (RendaAnual < 20000)
            {
                return RendaAnual * 0.15 - imposto;
            }
            else
            {
                return RendaAnual * 0.25 - imposto;
            }
        }
    }
}
