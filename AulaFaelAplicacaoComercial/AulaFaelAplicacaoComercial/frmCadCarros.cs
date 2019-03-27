using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace AulaFaelAplicacaoComercial
{

    public partial class frmCadCarros : Form
    {
        Carro carro = new Carro();
        public frmCadCarros()
        {
            InitializeComponent();
        }

        private void frmCadCarros_Load(object sender, EventArgs e)
        {

            cboCor.DataSource = Enum.GetNames(typeof(Carro.Cores));
            dgvCarros.DataSource = carro.Consultar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Length == 0)
            {
                carro = new Carro(
                    int.Parse(txtAno.Text),
                    (Carro.Cores)cboCor.SelectedIndex,
                    txtModelo.Text,
                    txtMarca.Text,
                    int.Parse(txtPortas.Text));
                carro.Incluir();
                MessageBox.Show("Dados cadastrados com sucesso!",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                carro = new Carro(
                   int.Parse(txtId.Text),
                   int.Parse(txtAno.Text),
                   (Carro.Cores)cboCor.SelectedIndex,
                   txtModelo.Text,
                   txtMarca.Text,
                   int.Parse(txtPortas.Text));
                carro.Alterar();

                MessageBox.Show("Dados alterados com sucesso!",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            PreencherGrid(carro.Consultar());
            LimparCampos();
        }
        private void LimparCampos()
        {
            txtId.Text = "";
            txtAno.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtPortas.Text = "";
            cboCor.SelectedIndex = 0;
        }

        private void btFiltrar_Click(object sender, EventArgs e)
        {
            PreencherGrid(carro.Consultar(txtMarca.Text));
        }

        private void dgvCarros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            id = (int)dgvCarros["Id", e.RowIndex].Value;
            Carro c = new Carro(id);
            txtId.Text = c.Id.ToString();
            txtMarca.Text = c.Marca.ToString();
            txtModelo.Text = c.Modelo.ToString();
            txtAno.Text = c.Ano.ToString();
            txtPortas.Text = c.Portas.ToString();
            cboCor.SelectedIndex = (int)c.Cor;
        }

        private void PreencherGrid(List<Carro> lista)
        {
            dgvCarros.DataSource = new BindingList<Carro>(lista);
        }

        private void btPreencher_Click(object sender, EventArgs e)
        {
            Carro.Preencher();
            PreencherGrid(carro.Consultar());
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Length != 0)
            {
                Carro.Excluir(carro.Consultar(), int.Parse(txtId.Text));
                MessageBox.Show("Registro excluidos com sucesso!",
                   "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                PreencherGrid(carro.Consultar());
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Selecione um registro para excluir!",
                  "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
