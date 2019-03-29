using System.Drawing;

namespace Tetris
{
    class Painel
    {
        public Tile[,] Corpo { get; set; }

        public Painel()
        {
            int i, j;
            Corpo = new Tile[20, 10];
            for (i = 0; i < 20; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    Corpo[i, j] = new Tile();
                }
            }
        }
        public void Desenhar(Graphics g)
        {
            int i, j;
            for (i = 0; i < 20; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    if (Corpo[i, j].Cor == Color.Transparent)
                    {
                        Corpo[i, j].Desenhar(g, i, j, Color.Black);
                    }
                    else
                    {
                        Corpo[i, j].Desenhar(g, i, j);
                    }
                }
            }
        }
        public void FixarPeca(Peca peca)
        {
            int i, j;
            for (i = 0; i < peca.Altura; i++)
                for (j = 0; j < peca.Largura; j++)
                    if (peca.Corpo[i, j].Cor != Color.Transparent)
                        Corpo[peca.Linha + i, peca.Coluna + j].Cor = peca.Corpo[i, j].Cor;
        }

        public bool LinhaCheia(int linha)
        {
            bool cheia = true;
            int j;
            for (j = 0; j < 10 && cheia; j++)
                if (Corpo[linha, j].Cor == Color.Transparent)
                    cheia = false;
            return cheia;
        }

        public void RemoverLinha(int linha)
        {
            int i, j;
            for (i = linha; i > 0; i--)
                for (j = 0; j < 10; j++)
                    Corpo[i, j].Cor = Color.Transparent;
            for (j = 0; j < 10; j++)
                Corpo[0, j].Cor = Color.Transparent;
        }
    }
}
