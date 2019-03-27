using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaFaelAplicacaoComercial
{
    abstract class Veiculo
    {
        #region Prorpiedades
        static int MaxId { get; set; } = 0;
        public int Id { get; set; }
        public string Marca { get; set; }
        #endregion

        #region Construtores
        public Veiculo(int id, string marca)
        {
            Id = id;
            Marca = marca;
        }

        public Veiculo(string marca)
        {
            Id = 0;
            Marca = marca;
        }

        public Veiculo()
        {
            Id = 0;
            Marca = "";
        }
        #endregion

        #region Acesso a dados
        public virtual void Incluir()
        {
            MaxId++;
            Id = MaxId;
        }
        public void Consultar()
        {
        }
        public virtual void Alterar() { }
        public static void Excluir(List <Carro> carros,int id)
        {
            int i;
            i = carros.FindIndex(c => c.Id == id);
            carros.Remove(carros[i]);

        }
        #endregion

    }
}
