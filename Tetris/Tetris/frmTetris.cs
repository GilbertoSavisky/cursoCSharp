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
            peca = new Peca(Peca.Sortear());
            peca.Desenhar(graphics);
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Start();
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
                        peca = new Peca(Peca.Sortear());
                    }
                    break;
                case Keys.Up:
                    if(peca.PodeGirar(painel))
                        peca.Girar();
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
                peca.Mover(Peca.Direcoes.Baixo);
            else
            {
                painel.FixarPeca(peca);
                peca = new Peca(Peca.Sortear());
            }
            painel.Desenhar(graphics);
            peca.Desenhar(graphics);
            txtPontuacao.Text = pontuacao.ToString();
        }
    }
}
