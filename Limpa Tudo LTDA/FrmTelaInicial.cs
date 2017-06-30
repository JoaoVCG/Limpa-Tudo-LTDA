using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Limpa_Tudo_LTDA
{
    public partial class LimpaTudoLTDA : Form
    {
        public LimpaTudoLTDA()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frmCli = new FrmCliente();
           
            frmCli.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProduto frmProd = new FrmProduto();
            frmProd.Show();
        }

        private void pedidosDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPedido frmPed = new FrmPedido();
            frmPed.Show();
        }

        private void encomendasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg;
            msg = "Você tem certeza que deseja sair?";
            DialogResult resp;
            resp = MessageBox.Show(msg, "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resp == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {

            }
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Relatorio.RelatorioCliente.RelatorioClientes();

        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Relatorio.RelatorioProduto.relatorioProdutos();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorio.RelatorioPedidos.relatorioPedidos();
        }
    }
}
