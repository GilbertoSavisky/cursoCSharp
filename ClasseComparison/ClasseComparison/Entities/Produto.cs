using System.Globalization;

namespace System
{
    class Produto : IComparable<Produto>
    {
        public string  Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return Nome + ", " + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(Produto other)
        {
            return Nome.ToUpper().CompareTo(other.Nome.ToUpper());
        }
    }
}