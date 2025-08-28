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
    public partial class frmPix: Form
    {
        Conta conta = new Conta();
        List<Lancamento> historicoLancamentos = new List<Lancamento>();
        public frmPix()
        {
            InitializeComponent();
            conta.Saldo = 5000;
            conta.LimiteCredito = 1000;
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {

        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {

        }

        private void frmPix_Load(object sender, EventArgs e)
        {

        }
    }
}
