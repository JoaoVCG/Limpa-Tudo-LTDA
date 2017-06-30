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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
            Camadas.Model.Produto produto = new Camadas.Model.Produto();
            int id = Convert.ToInt32(lblId.Text);

            string msg = "";
            if (id == -1)
                msg = "Deseja cadastrar produto?";
            else msg = "Deseja atualizar o produto?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Gravar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resp == DialogResult.Yes)
            {
                produto.id = id;
                produto.descricao = txtDescricao.Text;
                produto.valor = Convert.ToSingle(txtValor.Text);
                produto.status = Convert.ToChar(txtStatus.Text);
                if (id == -1) 
                    bllProd.Insert(produto);
                else bllProd.Update(produto);
            }
            dgvProdutos.DataSource = "";
            dgvProdutos.DataSource = bllProd.Select(); 
            LimparDados(); 
            HabDesab(false); 
        }

        private void Produto_Load(object sender, EventArgs e)
        {
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
            dgvProdutos.DataSource = bllProd.Select();
            HabDesab(false);
        }

        private void HabDesab(bool status)
        {
            txtDescricao.Enabled = status;
            txtValor.Enabled = status;
            txtStatus.Enabled = status;

            dgvProdutos.Enabled = !status;

            btnAdicionar.Enabled = !status;
            btnEditar.Enabled = !status;
            btnRemover.Enabled = !status;
            btnGravar.Enabled = status;
            btnCancelar.Enabled = status;
        }

        private void LimparDados()
        {
            lblId.Text = "";
            txtDescricao.Text = "";
            txtValor.Text = "";
            txtStatus.Text = "";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            LimparDados();
            lblId.Text = "-1";
            HabDesab(true);
            txtDescricao.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lblId.Text != string.Empty)
            {
                HabDesab(true);
                txtDescricao.Focus();
            }
            else
            {
                string msg = "Não há produto selecionado para edição";
                MessageBox.Show(msg, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparDados();
            HabDesab(false);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string msg;
            if (lblId.Text != string.Empty)
            {
                msg = "Tem certeza que deseja remover o Produto" + txtDescricao.Text + "?";
                DialogResult resp;
                resp = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(lblId.Text);
                    Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
                    Camadas.Model.Produto produto = new Camadas.Model.Produto();
                    produto.id = id;
                    bllProd.Delete(produto);
                    dgvProdutos.DataSource = "";
                    dgvProdutos.DataSource = bllProd.Select();
                }
            }
            else
            {
                msg = "Não há registro para remoção...";
                MessageBox.Show(msg, "Remover", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LimparDados();
            HabDesab(false);
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvProdutos_DoubleClick(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                lblId.Text = dgvProdutos.SelectedRows[0].Cells["id"].Value.ToString();
                txtDescricao.Text = dgvProdutos.SelectedRows[0].Cells["descricao"].Value.ToString();
                txtValor.Text = dgvProdutos.SelectedRows[0].Cells["valor"].Value.ToString();
                txtStatus.Text = dgvProdutos.SelectedRows[0].Cells["status"].Value.ToString();
            }
        }
    }
}
