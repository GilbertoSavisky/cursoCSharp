using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tetris
{
    public partial class frmTetris : Form
    {
        private Graphics graphics;
        private Painel painel;
        private Peca peca;
        private Timer timer;
        private int pontuacao;

        public frmTetris()
        {
            InitializeComponent();
            Tile.Tamanho = picPainel.Width / 10;
            graphics = picPainel.CreateGraphics();
            painel = new Painel();
            timer = new Timer();
            timer.Enabled = false;
            timer.Tick += new EventHandler(EventoTimer);

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            painel.Desenhar(graphics);
            peca = new Peca(Peca.Formato.T);
            peca.Desenhar(graphics);
            //timer.Enabled = true;
            //timer.Interval = 1000;
            //timer.Start();
            pontuacao = 0;
        }

        private void frmTetris_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (peca.PodeMover(painel, Peca.Direcoes.Esquerda))
                        peca.Mover(Peca.Direcoes.Esquerda);
                    break;
                case Keys.Right:
                    if (peca.PodeMover(painel, Peca.Direcoes.Direita))
                        peca.Mover(Peca.Direcoes.Direita);
                    break;
                case Keys.Down:
                    if (peca.PodeMover(painel, Peca.Direcoes.Baixo))
                        peca.Mover(Peca.Direcoes.Baixo);
                    else
                    {
                        painel.FixarPeca(peca);
                        peca = new Peca(Peca.Formato.T);
                    }
                    break;
                case Keys.Up:
                    if(peca.PodeGirar(painel))
                        peca.Girar();
                    break;
                case Keys.Enter:
                    while (peca.PodeMover(painel, Peca.Direcoes.Baixo))
                        peca.Mover(Peca.Direcoes.Baixo);
                    break;

            }
            painel.Desenhar(graphics);
            peca.Desenhar(graphics);
        }

        public void EventoTimer(object sender, EventArgs e)
        {
            Atualizar();
        }

        public void Atualizar()
        {
            if (peca.PodeMover(painel, Peca.Direcoes.Baixo))
            {
                peca.Mover(Peca.Direcoes.Baixo);
                peca.Valor--;
            }
            else
            {
                painel.FixarPeca(peca);
                pontuacao += peca.Valor;
                int total_linhas = 0;
                for (int i = 0; i < 20; i++)
                {
                    if (painel.LinhaCheia(i))
                    {
                        painel.RemoverLinha(i);
                        total_linhas++;
                    }
                }
                if (total_linhas > 0)
                    pontuacao += peca.Valor * Fatorial(total_linhas);
                peca = new Peca(Peca.Sortear());
            }
            painel.Desenhar(graphics);
            peca.Desenhar(graphics);
            txtPontuacao.Text = pontuacao.ToString();
        }

        private static int Fatorial(int n)
        {
            if (n == 1)
                return 1;
            else
                return n * Fatorial(n - 1);
        }
    }
}
