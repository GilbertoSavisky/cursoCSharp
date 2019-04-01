namespace Account_ExcFixacao
{
    partial class FrmConta
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLimSaque = new System.Windows.Forms.TextBox();
            this.lblSaque = new System.Windows.Forms.Label();
            this.txtSaque = new System.Windows.Forms.TextBox();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btDepositar = new System.Windows.Forms.Button();
            this.btSacar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(47, 61);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(5);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(87, 30);
            this.txtNumero.TabIndex = 0;
            this.txtNumero.Text = "8021";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(43, 33);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(71, 23);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Número:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(84, 109);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(56, 23);
            this.lblSaldo.TabIndex = 3;
            this.lblSaldo.Text = "Saldo:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(88, 137);
            this.txtSaldo.Margin = new System.Windows.Forms.Padding(5);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(164, 30);
            this.txtSaldo.TabIndex = 2;
            this.txtSaldo.Text = "500";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(140, 33);
            this.lblNome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 23);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(144, 61);
            this.txtNome.Margin = new System.Windows.Forms.Padding(5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(335, 30);
            this.txtNome.TabIndex = 1;
            this.txtNome.Text = "Alex Brown";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Limite de Saque:";
            // 
            // txtLimSaque
            // 
            this.txtLimSaque.Location = new System.Drawing.Point(305, 137);
            this.txtLimSaque.Margin = new System.Windows.Forms.Padding(5);
            this.txtLimSaque.Name = "txtLimSaque";
            this.txtLimSaque.Size = new System.Drawing.Size(164, 30);
            this.txtLimSaque.TabIndex = 3;
            this.txtLimSaque.Text = "300";
            // 
            // lblSaque
            // 
            this.lblSaque.AutoSize = true;
            this.lblSaque.Enabled = false;
            this.lblSaque.Location = new System.Drawing.Point(301, 232);
            this.lblSaque.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSaque.Name = "lblSaque";
            this.lblSaque.Size = new System.Drawing.Size(58, 23);
            this.lblSaque.TabIndex = 8;
            this.lblSaque.Text = "Saque:";
            // 
            // txtSaque
            // 
            this.txtSaque.Enabled = false;
            this.txtSaque.Location = new System.Drawing.Point(305, 260);
            this.txtSaque.Margin = new System.Windows.Forms.Padding(5);
            this.txtSaque.Name = "txtSaque";
            this.txtSaque.Size = new System.Drawing.Size(164, 30);
            this.txtSaque.TabIndex = 5;
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Enabled = false;
            this.lblDeposito.Location = new System.Drawing.Point(84, 232);
            this.lblDeposito.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(79, 23);
            this.lblDeposito.TabIndex = 7;
            this.lblDeposito.Text = "Depósito:";
            // 
            // txtDeposito
            // 
            this.txtDeposito.Enabled = false;
            this.txtDeposito.Location = new System.Drawing.Point(88, 260);
            this.txtDeposito.Margin = new System.Windows.Forms.Padding(5);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(164, 30);
            this.txtDeposito.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "R$:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "R$:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(260, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "R$:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(43, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "R$:";
            // 
            // btDepositar
            // 
            this.btDepositar.Enabled = false;
            this.btDepositar.Location = new System.Drawing.Point(144, 298);
            this.btDepositar.Name = "btDepositar";
            this.btDepositar.Size = new System.Drawing.Size(108, 33);
            this.btDepositar.TabIndex = 13;
            this.btDepositar.Text = "Depositar";
            this.btDepositar.UseVisualStyleBackColor = true;
            this.btDepositar.Click += new System.EventHandler(this.btDepositar_Click);
            // 
            // btSacar
            // 
            this.btSacar.Enabled = false;
            this.btSacar.Location = new System.Drawing.Point(361, 298);
            this.btSacar.Name = "btSacar";
            this.btSacar.Size = new System.Drawing.Size(108, 33);
            this.btSacar.TabIndex = 14;
            this.btSacar.Text = "Sacar";
            this.btSacar.UseVisualStyleBackColor = true;
            this.btSacar.Click += new System.EventHandler(this.btSacar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(361, 196);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(108, 33);
            this.btSalvar.TabIndex = 15;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // FrmConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 410);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btSacar);
            this.Controls.Add(this.btDepositar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSaque);
            this.Controls.Add(this.txtSaque);
            this.Controls.Add(this.lblDeposito);
            this.Controls.Add(this.txtDeposito);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLimSaque);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txtNumero);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conta Bancária";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLimSaque;
        private System.Windows.Forms.Label lblSaque;
        private System.Windows.Forms.TextBox txtSaque;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btDepositar;
        private System.Windows.Forms.Button btSacar;
        private System.Windows.Forms.Button btSalvar;
    }
}

