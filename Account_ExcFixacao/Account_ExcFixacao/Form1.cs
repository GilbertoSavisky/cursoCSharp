using System;
using Account_ExcFixacao.Entities;
using System.Globalization;
using Account_ExcFixacao.Entities.Exceptions;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_ExcFixacao
{
    public partial class FrmConta : Form
    {
        Account account;
        private bool btDepositarHabilitar, btSacarHabilitar;
        public FrmConta()
        {
            InitializeComponent();
            
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                account = new Account(int.Parse(txtNumero.Text),
                    txtNome.Text,
                    double.Parse(txtSaldo.Text, CultureInfo.InvariantCulture),
                    double.Parse(txtLimSaque.Text, CultureInfo.InvariantCulture));
                label4.Enabled = true;
                label5.Enabled = true;
                txtDeposito.Enabled = true;
                txtSaque.Enabled = true;
                btDepositar.Enabled = !btDepositar.Enabled;
                btSacar.Enabled = !btSacar.Enabled;
            }
            catch (FormatException erro)
            {
                MessageBox.Show("Formato errado!" + erro.Message, "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

        }

        private void btDepositar_Click(object sender, EventArgs e)
        {
            try
            {
                account.Deposito(double.Parse(txtDeposito.Text));
                txtSaldo.Text = account.Balanco.ToString("F2", CultureInfo.InvariantCulture);
                txtDeposito.Text = "";
                btDepositar.Enabled = !btDepositar.Enabled;
            }
            catch(FormatException erro)
            {
                MessageBox.Show("Formato errado!" + erro.Message, "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

        }



        private void btSacar_Click(object sender, EventArgs e)
        {
            try
            {
                account.Saque(double.Parse(txtSaque.Text));
                txtSaldo.Text = account.Balanco.ToString("F2", CultureInfo.InvariantCulture);
                txtSaque.Text = "";
                btSacar.Enabled = !btSacar.Enabled;
            }
            catch (DominioException erro)
            {
                MessageBox.Show("Erro: "+erro.Message, "Aviso", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            catch(FormatException erro)
            {
                MessageBox.Show("Formato errado!"+erro.Message, "Aviso", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
        }       
    }
}
