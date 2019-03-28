﻿namespace Tetris
{
    partial class frmTetris
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picPainel = new System.Windows.Forms.PictureBox();
            this.lblPontuacao = new System.Windows.Forms.Label();
            this.txtPontuacao = new System.Windows.Forms.TextBox();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.lblNivel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPainel)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.jogoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(567, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // jogoToolStripMenuItem
            // 
            this.jogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.pausaToolStripMenuItem});
            this.jogoToolStripMenuItem.Name = "jogoToolStripMenuItem";
            this.jogoToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.jogoToolStripMenuItem.Text = "Jogo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // pausaToolStripMenuItem
            // 
            this.pausaToolStripMenuItem.Name = "pausaToolStripMenuItem";
            this.pausaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pausaToolStripMenuItem.Text = "Pausa";
            // 
            // picPainel
            // 
            this.picPainel.Location = new System.Drawing.Point(222, 48);
            this.picPainel.Margin = new System.Windows.Forms.Padding(4);
            this.picPainel.Name = "picPainel";
            this.picPainel.Size = new System.Drawing.Size(250, 500);
            this.picPainel.TabIndex = 1;
            this.picPainel.TabStop = false;
            // 
            // lblPontuacao
            // 
            this.lblPontuacao.AutoSize = true;
            this.lblPontuacao.Location = new System.Drawing.Point(13, 28);
            this.lblPontuacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPontuacao.Name = "lblPontuacao";
            this.lblPontuacao.Size = new System.Drawing.Size(86, 16);
            this.lblPontuacao.TabIndex = 2;
            this.lblPontuacao.Text = "Pontuação:";
            // 
            // txtPontuacao
            // 
            this.txtPontuacao.Enabled = false;
            this.txtPontuacao.Location = new System.Drawing.Point(17, 48);
            this.txtPontuacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtPontuacao.Name = "txtPontuacao";
            this.txtPontuacao.Size = new System.Drawing.Size(82, 22);
            this.txtPontuacao.TabIndex = 3;
            this.txtPontuacao.Text = "0";
            this.txtPontuacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNivel
            // 
            this.txtNivel.Enabled = false;
            this.txtNivel.Location = new System.Drawing.Point(17, 118);
            this.txtNivel.Margin = new System.Windows.Forms.Padding(4);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(82, 22);
            this.txtNivel.TabIndex = 5;
            this.txtNivel.Text = "0";
            this.txtNivel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(13, 98);
            this.lblNivel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(48, 16);
            this.lblNivel.TabIndex = 4;
            this.lblNivel.Text = "Nível:";
            // 
            // frmTetris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 558);
            this.Controls.Add(this.txtNivel);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.txtPontuacao);
            this.Controls.Add(this.lblPontuacao);
            this.Controls.Add(this.picPainel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "frmTetris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tetris";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTetris_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPainel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.PictureBox picPainel;
        private System.Windows.Forms.Label lblPontuacao;
        private System.Windows.Forms.TextBox txtPontuacao;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.ToolStripMenuItem pausaToolStripMenuItem;
    }
}

