using System.Collections.Generic;

namespace AulaFaelAplicacaoComercial
{
    class Carro : Veiculo
    {
        public enum Cores { Branca, Preta, Vermelha, Azul }

        public int Ano { get; set; }
        public string Modelo { get; set; }
        public Cores Cor { get; set; }
        public int Portas { get; set; }
        static List<Carro> Carros = new List<Carro>();

        public Carro(int id, int ano, Cores cor,string modelo, string marca, int portas)
            : base(id, marca)
        {
            
            Ano = ano;
            Cor = cor;
            Modelo = modelo;
            Portas = portas;
        }

        public Carro(int ano, Cores cor, string modelo, string marca, int portas)
            : base(marca)
        {
            
            Ano = ano;
            Cor = cor;
            Modelo = modelo;
            Portas = portas;
        }

        public Carro()
        {
            Cor = Cores.Branca;
            Ano = 0;
            Modelo = "";
        }

       
        public override void Alterar()
        {
            int i;
            i = Carros.FindIndex(c => c.Id == Id);
            Carros[i].Marca = Marca;
            Carros[i].Modelo = Modelo;
            Carros[i].Ano = Ano;
            Carros[i].Cor = Cor;
            Carros[i].Portas = Portas;
        }

        public override void Incluir()
        {
            base.Incluir();
            Carros.Add(this);
        }

        public new List<Carro> Consultar()
        {
            return Carros;
        }

        public List<Carro> Consultar(string marca)
        {
            return Carros.FindAll(c => c.Marca.Contains(marca.ToUpper()) 
                || c.Marca.Contains(marca.ToLower())
                || c.Marca.Contains(marca));
        }

        public Carro(int id)
        {
            Carro tc = Carros.Find(c => c.Id == id);
            Id = tc.Id;
            Marca = tc.Marca;
            Modelo = tc.Modelo;
            Ano = tc.Ano;
            Cor = tc.Cor;
            Portas = tc.Portas;
        }

        public static void Preencher()
        {
            Carro c;
            c = new Carro(1976, Cores.Azul, "Fusca", "Volks", 2);
            c.Incluir();
            c = new Carro(2015, Cores.Vermelha, "Prisma", "Chevrolet", 4);
            c.Incluir();
            c = new Carro(1985, Cores.Preta, "Gol", "Volks", 2);
            c.Incluir();
            c = new Carro(2019, Cores.Branca, "Fusion", "Ford", 4);
            c.Incluir();
            c = new Carro(2017, Cores.Azul, "Toro", "Fiat", 2);
            c.Incluir();
        }
    }
}
