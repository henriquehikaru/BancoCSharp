using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class frmCaixaEletronico : Form
    {
        Conta conta = new Conta();
        public frmCaixaEletronico()
        {
            InitializeComponent();
            conta.Saldo = 5000;
            lblSaldo.Text = conta.Saldo.ToString("C");
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            conta.Sacar(numValorSaque.Value);
            lblSaldo.Text = conta.Saldo.ToString("C");
            MessageBox.Show("Saque Realizado com sucesso!");    
        }
    }
}
