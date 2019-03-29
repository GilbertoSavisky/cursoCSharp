using System.Drawing;
using System;
using System.Linq;

namespace Tetris
{
    class Peca
    {
        public enum Formato { Vazia, L, J, O, S, Z, T, I };
        public enum Direcoes { Esquerda, Direita, Baixo };

        public Formato Formatos { get; set; }
        public Tile[,] Corpo { get; set; }
        public int Altura { get; set; }
        public int Largura { get; set; }
        public int Linha { get; set; }
        public int Coluna { get; set; }
        public int Valor { get; set; }

        public Peca()
        {
            Formatos = Formato.Vazia;
            Linha = 0;
            Coluna = 0;
            Valor = 0;
            CriarCorpo();
            DefinirCorpo();
        }

        public Peca(Formato formato)
        {
            Formatos = formato;
            Linha = 0;
            Coluna = 4;
            Valor = 22;
            CriarCorpo();
            DefinirCorpo();
        }

        public void CriarCorpo()
        {
            int i, j;
            Corpo = new Tile[4, 4];
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Corpo[i, j] = new Tile();
                }
            }
        }

        public void DefinirCorpo()
        {
            int i, j;
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Corpo[i, j].Cor = Color.Transparent;
                }
            }
            switch (Formatos)
            {
                case Formato.Vazia:
                    Altura = 4;
                    Largura = 4;
                    break;
                case Formato.L:
                    Altura = 3;
                    Largura = 2;
                    Corpo[0, 0].Cor = Color.Yellow;
                    Corpo[1, 0].Cor = Color.Yellow;
                    Corpo[2, 0].Cor = Color.Yellow;
                    Corpo[2, 1].Cor = Color.Yellow;
                    break;
                case Formato.J:
                    Altura = 3;
                    Largura = 2;
                    Corpo[0, 1].Cor = Color.RoyalBlue;
                    Corpo[1, 1].Cor = Color.RoyalBlue;
                    Corpo[2, 1].Cor = Color.RoyalBlue;
                    Corpo[2, 0].Cor = Color.RoyalBlue;
                    break;
                case Formato.O:
                    Altura = 2;
                    Largura = 2;
                    Corpo[0, 0].Cor = Color.Coral;
                    Corpo[0, 1].Cor = Color.Coral;
                    Corpo[1, 0].Cor = Color.Coral;
                    Corpo[1, 1].Cor = Color.Coral;
                    break;
                case Formato.S:
                    Altura = 2;
                    Largura = 3;
                    Corpo[0, 1].Cor = Color.DarkCyan;
                    Corpo[0, 2].Cor = Color.DarkCyan;
                    Corpo[1, 0].Cor = Color.DarkCyan;
                    Corpo[1, 1].Cor = Color.DarkCyan;
                    break;
                case Formato.Z:
                    Altura = 2;
                    Largura = 3;
                    Corpo[0, 0].Cor = Color.Blue;
                    Corpo[0, 1].Cor = Color.Blue;
                    Corpo[1, 1].Cor = Color.Blue;
                    Corpo[1, 2].Cor = Color.Blue;
                    break;
                case Formato.T:
                    Altura = 2;
                    Largura = 3;
                    Corpo[0, 1].Cor = Color.Peru;
                    Corpo[1, 0].Cor = Color.Peru;
                    Corpo[1, 1].Cor = Color.Peru;
                    Corpo[1, 2].Cor = Color.Peru;
                    break;
                case Formato.I:
                    Altura = 4;
                    Largura = 1;
                    Corpo[0, 0].Cor = Color.Red;
                    Corpo[1, 0].Cor = Color.Red;
                    Corpo[2, 0].Cor = Color.Red;
                    Corpo[3, 0].Cor = Color.Red;
                    break;
            }
        }

        public void Mover(Direcoes direcoes)
        {
            switch (direcoes)
            {
                case Direcoes.Esquerda: Coluna--; break;
                case Direcoes.Direita: Coluna++; break;
                case Direcoes.Baixo: Linha++; break;
            }
        }

        public void Desenhar(Graphics graphics)
        {
            int i, j;
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    if (Corpo[i, j].Cor != Color.Transparent)
                    {
                        Corpo[i, j].Desenhar(graphics, Linha + i, Coluna + j);
                    }
                }
            }
        }
        
        public bool PodeEncaixar(Painel painel)
        {
            // Testa os limites do painel
            bool ok = true, tile_peca, tile_painel;
            int i, j;
            if (Coluna < 0
                || Coluna + Largura > 10
                || Linha + Altura > 20)
                ok = false;

            // Testa em relação às outras peças
            if(ok)
            {
                for (i = 0; i < Altura && ok; i++)
                {
                    for (j = 0; j < Largura && ok; j++)
                    {
                        tile_peca = (Corpo[i, j].Cor != Color.Transparent);
                        tile_painel = (painel.Corpo[i + Linha, j + Coluna].Cor != Color.Transparent);
                        if (tile_peca && tile_painel)
                            ok = false;
                    }
                }
            }
            return ok;
        }

        public Peca Clonar()
        {
            Peca peca = new Peca();
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    peca.Corpo[i, j].Cor = Corpo[i, j].Cor;
            peca.Formatos = Formatos;
            peca.Altura = Altura;
            peca.Largura = Largura;
            peca.Linha = Linha;
            peca.Coluna = Coluna;
            return peca;
        }

        public bool PodeMover(Painel painel, Direcoes direcoes)
        {
            Peca peca = Clonar();
            peca.Mover(direcoes);
            return peca.PodeEncaixar(painel);
        }

        public static Formato Sortear()
        {
            return (Formato)Program.random.Next(1, 
                (int)Enum.GetValues(typeof(Formato)).Cast<Formato>().Last()+1);

        }

        public void Girar()
        {
            Tile[,] corpo = new Tile[4, 4];
            bool vazia;
            int largura=0, altura=0, i, j, k;
            //Rotacionar matriz para direita
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                    corpo[3 - j, i] = new Tile(Corpo[i, j].Cor);
            }
            largura = Altura;
            altura = Largura;
            // Alinha ao topo
            for (i = 0; i < 4; i++)
            {
                vazia = true;
                for (j = 0; j < 4 && vazia; j++)
                    vazia = corpo[i, j].Cor == Color.Transparent;
                if (vazia)
                {
                    for (k = i; k < 3; k++)
                        for (j = 0; j < 4; j++)
                            corpo[k, j].Cor = corpo[k + 1, j].Cor;
                    for (j = 0; j < 4; j++)
                        corpo[k, j].Cor = Color.Transparent;
                }
               
            }

            // Alinha ao esquerda
            for (j = 0; j < 4; j++)
            {
                vazia = true;
                for (i = 0; i < 4 && vazia; i++)
                    vazia = corpo[i, j].Cor == Color.Transparent;
                if (vazia)
                {
                    for (k = j; k < 3; k++)
                        for (i = 0; i < 4; i++)
                            corpo[i, k].Cor = corpo[i, k+1].Cor;
                    for (i = 0; i < 4; i++)
                        corpo[i, k].Cor = Color.Transparent;
                }
            }

            // Atribui o corpo transposto e espelhado
            for (i = 0; i < 4; i++)
                for (j = 0; j < 4; j++)
                    Corpo[i, j].Cor = corpo[i,j].Cor;
            Altura = altura;
            Largura = largura;
        }

        public bool PodeGirar(Painel painel)
        {
            Peca peca = Clonar();
            return peca.PodeEncaixar(painel);
        }
    }
}
