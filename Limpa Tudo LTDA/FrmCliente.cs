using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Limpa_Tudo_LTDA.Camadas;

namespace Limpa_Tudo_LTDA
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void lblidCliente_Click(object sender, EventArgs e)
        {

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();
            dgvClientes.DataSource = bllCliente.Select();
            HabDesab(false);


        }

        private void HabDesab(bool status)
        {
            txtNome.Enabled = status;
            txtEndereco.Enabled = status;
            txtCidade.Enabled = status;
            txtEstado.Enabled = status;
            txtTelefone.Enabled = status;

            dgvClientes.Enabled = !status;

            btnAdicionar.Enabled = !status;
            btnEditar.Enabled = !status;
            btnRemover.Enabled = !status;
            btnGravar.Enabled = status;
            btnCancelar.Enabled = status;
        }

        private void LimparDados()
        {
            lblid.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            txtTelefone.Text = "";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            LimparDados();
            lblid.Text = "-1";
            HabDesab(true);
            txtNome.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lblid.Text != string.Empty)
            {
                HabDesab(true);
                txtNome.Focus();
            }
            else
            {
                string msg = "Não há cliente para edição";
                MessageBox.Show(msg, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();
            Camadas.Model.Cliente cliente = new Camadas.Model.Cliente();
            int id = Convert.ToInt32(lblid.Text);
            string msg = "";
            if (id == -1)
                msg = "Deseja cadastrar cliente?";
            else msg = "Deseja atualizar os dados do cliente?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resp == DialogResult.Yes)
            {
                cliente.id = id;
                cliente.nome = txtNome.Text;
                cliente.endereco = txtEndereco.Text;
                cliente.cidade = txtCidade.Text;
                cliente.estado = txtEstado.Text.ToUpper();
                cliente.telefone = txtTelefone.Text;

                if (id == -1)
                    bllCliente.Insert(cliente);
                else bllCliente.Update(cliente);
            }
            dgvClientes.DataSource = "";
            dgvClientes.DataSource = bllCliente.Select();
            LimparDados();
            HabDesab(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparDados();
            HabDesab(false);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string msg;
            if (lblid.Text != string.Empty)
            {
                msg = "Tem certeza que deseja remover o cliente " + txtNome.Text + "?";
                DialogResult resp;
                resp = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(lblid.Text);
                    Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();
                    Camadas.Model.Cliente cliente = new Camadas.Model.Cliente();
                    cliente.id = id;
                    bllCliente.Delete(cliente);

                    dgvClientes.DataSource = "";
                    dgvClientes.DataSource = bllCliente.Select();
                }
            }
            else
            {
                msg = "Não foi selecionado nenhum cliente para remoção";
                MessageBox.Show(msg, "Remover", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            LimparDados();
            HabDesab(false);
        }

        private void dgvClientes_DoubleClick(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                lblid.Text = dgvClientes.SelectedRows[0].Cells["id"].Value.ToString();
                txtNome.Text = dgvClientes.SelectedRows[0].Cells["nome"].Value.ToString();
                txtEndereco.Text = dgvClientes.SelectedRows[0].Cells["endereco"].Value.ToString();
                txtCidade.Text = dgvClientes.SelectedRows[0].Cells["cidade"].Value.ToString();
                txtEstado.Text = dgvClientes.SelectedRows[0].Cells["estado"].Value.ToString();
                txtTelefone.Text = dgvClientes.SelectedRows[0].Cells["telefone"].Value.ToString();
            }
        }

        private void txtEstado_Leave(object sender, EventArgs e)
        {
            txtEstado.Text = txtEstado.Text.ToUpper();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtPesquisa.Text != string.Empty)
            {
                Camadas.BLL.Cliente bllCli = new Camadas.BLL.Cliente();
                List<Camadas.Model.Cliente> lstCliente = new List<Camadas.Model.Cliente>();

                if (rdbId.Checked)
                    lstCliente = bllCli.SelectById(Convert.ToInt32(txtPesquisa.Text));
                else if (rdbNome.Checked)
                    lstCliente = bllCli.SelectByNome(txtPesquisa.Text);

                dgvClientes.DataSource = "";
                dgvClientes.DataSource = lstCliente;
            }
            else
            {
                string msg = "O campos pesquisa está vazio";
                MessageBox.Show(msg, "Pesquisar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Visible = false;
            txtPesquisa.Visible = false;
            btnPesquisar.Visible = false;
            Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();
            dgvClientes.DataSource = "";
            dgvClientes.DataSource = bllCliente.Select();
        }

        private void rdbId_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Text = "Informe o ID: ";
            lblPesquisa.Visible = true;
            txtPesquisa.Text = "";
            txtPesquisa.Visible = true;
            btnPesquisar.Visible = true;
            txtPesquisa.Focus();
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            lblPesquisa.Text = "Informe o Nome: ";
            lblPesquisa.Visible = true;
            txtPesquisa.Text = "";
            txtPesquisa.Visible = true;
            btnPesquisar.Visible = true;
            txtPesquisa.Focus();
        }
    }
}
