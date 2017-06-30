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
    public partial class FrmPedido : Form
    {
        Camadas.Model.Produto produto = new Camadas.Model.Produto();
        public FrmPedido()
        {
            InitializeComponent();
        }


        private void HabDesabPedidos(bool status)
        {
            dtpData.Enabled = status;
            txtCliente.Enabled = status;
            cmbCliente.Enabled = status;

            dgvPedido.Enabled = !status;

            btnAdicionar.Enabled = !status;
            btnEditar.Enabled = !status;
            btnRemover.Enabled = !status;
            btnGravar.Enabled = status;
            btnCancelar.Enabled = status;
        }

        private void LimparDadosPedido()
        {
            lblIdPed.Text = "";
            txtCliente.Text = "";
            dtpData.Value = DateTime.Now.Date;
        }

        private void HabDesabItemPedido(bool status)
        {
            txtProduto.Enabled = status;
            cmbProduto.Enabled = status;

            dgvItemPedido.Enabled = !status;

            btnAdicionarPed.Enabled = !status;
            btnEditarPed.Enabled = !status;
            btnRemoverPed.Enabled = !status;
            btnGravarPed.Enabled = status;
            btnCancelarPed.Enabled = status;
        }

        private void LimparDadosItemPedido()
        {
            lblItmPedID.Text = "";
            txtProduto.Text = "";
            lblEntrega.Text = "";
            lblDias.Text = "";
            txtValor.Text = "";
            lblTotal.Text = "";
            lblStatus.Text = "";
        }

        private void RecuperarDadosProduto()
        {
            Camadas.BLL.Produto bllProduto = new Camadas.BLL.Produto();
            List<Camadas.Model.Produto> lstProd = new List<Camadas.Model.Produto>();
            lstProd = bllProduto.SelectById(Convert.ToInt32(txtProduto.Text));
            if (lstProd != null)
                produto = lstProd[0];
            else MessageBox.Show("Produto não encontrado");
            if (produto.status != 'V')
            {
                MessageBox.Show("Produto não pode ser comprado: " + produto.status);
                cmbProduto.Focus();
            }
            else
            {
                lblStatus.Text = produto.status.ToString();
                txtValor.Text = produto.valor.ToString();
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalPed_Click(object sender, EventArgs e)
        {

        }

        private void lblStatusPed_Click(object sender, EventArgs e)
        {

        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            HabDesabPedidos(false);
            HabDesabItemPedido(false);
            LimparDadosPedido();
            LimparDadosItemPedido();
            Camadas.BLL.Pedido bllPedido = new Camadas.BLL.Pedido();
            Camadas.BLL.ItemPedido bllItemPedido = new Camadas.BLL.ItemPedido();

            dgvPedido.DataSource = bllPedido.Select();
            dgvItemPedido.DataSource = bllItemPedido.Select();


            Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();
            cmbCliente.DisplayMember = "nome";
            cmbCliente.ValueMember = "id";
            cmbCliente.DataSource = bllCliente.Select();

            Camadas.BLL.Produto bllProduto = new Camadas.BLL.Produto();
            cmbProduto.DisplayMember = "descricao";
            cmbProduto.ValueMember = "id";
            cmbProduto.DataSource = bllProduto.Select();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            LimparDadosPedido();
            lblIdPed.Text = "-1";
            HabDesabPedidos(true);
            dtpData.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lblIdPed.Text != string.Empty)
            {
                HabDesabPedidos(true);
                dtpData.Focus();
            }
            else
            {
                string msg = "Não há pedido selecionado para edição";
                MessageBox.Show(msg, "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Pedido bllPedido = new Camadas.BLL.Pedido();
            Camadas.Model.Pedido pedido = new Camadas.Model.Pedido();
            int id = Convert.ToInt32(lblIdPed.Text);

            string msg = "";
            if (id == -1)
                msg = "Deseja efetuar o pedido?";
            else msg = "Tem certeza que deseja editar o pedido?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Salvar Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resp == DialogResult.Yes)
            {
                pedido.id = id;
                pedido.data = dtpData.Value;
                pedido.cliente = Convert.ToInt32(txtCliente.Text);
                if (id == -1) 
                    bllPedido.Insert(pedido);
                else bllPedido.Update(pedido);
            }
            dgvPedido.DataSource = "";
            dgvPedido.DataSource = bllPedido.Select(); 
            LimparDadosPedido(); 
            HabDesabPedidos(false);  
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparDadosPedido();
            HabDesabPedidos(false);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string msg;
            if (lblIdPed.Text != string.Empty)
            {
                msg = "Confirma remoção do pedido: " + lblIdPed.Text + "?";
                DialogResult resp;
                resp = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(lblIdPed.Text);
                    Camadas.BLL.Pedido bllPedido = new Camadas.BLL.Pedido();
                    Camadas.Model.Pedido pedido = new Camadas.Model.Pedido();
                    pedido.id = id;
                    bllPedido.Delete(pedido);
                    dgvPedido.DataSource = "";
                    dgvPedido.DataSource = bllPedido.Select();
                }
            }
            else
            {
                msg = "Não há pedido selecionado para remoção";
                MessageBox.Show(msg, "Locação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LimparDadosPedido();
            HabDesabPedidos(false);
        }

        private void dgvPedido_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPedido.SelectedRows.Count > 0)
            {
                lblIdPed.Text = dgvPedido.SelectedRows[0].Cells["id"].Value.ToString();
                txtCliente.Text = dgvPedido.SelectedRows[0].Cells["cliente"].Value.ToString();
                cmbCliente.SelectedValue = Convert.ToInt32(txtCliente.Text);
                dtpData.Value = Convert.ToDateTime(dgvPedido.SelectedRows[0].Cells["data"].Value.ToString());

                Camadas.BLL.ItemPedido bllItemPedido = new Camadas.BLL.ItemPedido();
                int pedido = Convert.ToInt32(lblIdPed.Text);
                dgvItemPedido.DataSource = "";
                dgvItemPedido.DataSource = bllItemPedido.SelectByPedido(pedido);

            }
        }

        private void dgvItemPedido_DoubleClick(object sender, EventArgs e)
        {
            if (dgvItemPedido.SelectedRows.Count > 0)
            {
                lblItmPedID.Text = dgvItemPedido.SelectedRows[0].Cells["id"].Value.ToString();
                txtProduto.Text = dgvItemPedido.SelectedRows[0].Cells["produto"].Value.ToString();
                lblEntrega.Text = dgvItemPedido.SelectedRows[0].Cells["entrega"].Value.ToString();
                txtValor.Text = dgvItemPedido.SelectedRows[0].Cells["valor"].Value.ToString();
                lblDias.Text = dgvItemPedido.SelectedRows[0].Cells["dias"].Value.ToString();
                if (Convert.ToInt32(lblDias.Text) == 0)
                {
                    lblStatus.Text = "E";
                    btnBaixaPed.Enabled = true;
                }
                else
                {
                    lblStatus.Text = "L";
                    btnBaixaPed.Enabled = false;
                }
                float total = Convert.ToInt32(lblDias.Text) * Convert.ToSingle(txtValor.Text);
                lblTotal.Text = total.ToString();
            }
        }

        private void btnAdicionarPed_Click(object sender, EventArgs e)
        {
            if (lblIdPed.Text != "" && lblIdPed.Text != "-1")
            {
                LimparDadosItemPedido();
                lblItmPedID.Text = "-1";
                HabDesabItemPedido(true);
                lblEntrega.Text = dtpData.Value.AddDays(1).ToString();
                lblDias.Text = "0";
                lblTotal.Text = "0";
                btnBaixaPed.Enabled = false;
                cmbProduto.Focus();
            }
            else
            {
                string msg = "Não há pedido selecionado";
                MessageBox.Show(msg, "Itens do Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditarPed_Click(object sender, EventArgs e)
        {
            if (lblItmPedID.Text != string.Empty)
            {
                HabDesabItemPedido(true);
                txtProduto.Focus();
            }
            else
            {
                string msg = "Não há itens do pedido para edição";
                MessageBox.Show(msg, "Itens Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGravarPed_Click(object sender, EventArgs e)
        {
            Camadas.BLL.ItemPedido bllItemPedido = new Camadas.BLL.ItemPedido();
            Camadas.Model.ItemPedido itemPedido = new Camadas.Model.ItemPedido();
            int id = Convert.ToInt32(lblItmPedID.Text);

            string msg = "";
            if (id == -1)
                msg = "Deseja cadastrar o produto no pedido?";
            else msg = "Tem certeza que deseja editar?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Gravar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resp == DialogResult.Yes)
            {
                itemPedido.id = id;
                itemPedido.pedido = Convert.ToInt32(lblIdPed.Text);
                itemPedido.produto = Convert.ToInt32(txtProduto.Text);
                itemPedido.entrega = Convert.ToDateTime(lblEntrega.Text);
                itemPedido.valor = Convert.ToSingle(txtValor.Text);
                itemPedido.dias = Convert.ToInt32(lblDias.Text);

                if (id == -1)
                    bllItemPedido.Insert(itemPedido);
                else bllItemPedido.Update(itemPedido);
            }
            dgvItemPedido.DataSource = "";
            dgvItemPedido.DataSource = bllItemPedido.SelectByPedido(Convert.ToInt32(lblIdPed.Text));
            LimparDadosItemPedido();
            HabDesabItemPedido(false); 
        }

        private void btnCancelarPed_Click(object sender, EventArgs e)
        {
            LimparDadosItemPedido();
            HabDesabItemPedido(false);
            Camadas.BLL.ItemPedido bllItemPedido = new Camadas.BLL.ItemPedido();
            dgvItemPedido.DataSource = bllItemPedido.SelectByPedido(Convert.ToInt32(lblIdPed.Text));
        }

        private void btnRemoverPed_Click(object sender, EventArgs e)
        {
            string msg;
            if (lblItmPedID.Text != string.Empty)
            {
                msg = "Confirma Remoção de Itens do Pedido " + lblItmPedID.Text + "?";
                DialogResult resp;
                resp = MessageBox.Show(msg, "Remover Item Pedido", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(lblItmPedID.Text);
                    Camadas.BLL.ItemPedido bllItemPedido = new Camadas.BLL.ItemPedido();
                    Camadas.Model.ItemPedido itemPedido = new Camadas.Model.ItemPedido();
                    itemPedido.id = id;
                    bllItemPedido.Delete(itemPedido);
                    dgvItemPedido.DataSource = "";
                    dgvItemPedido.DataSource = bllItemPedido.Select();
                }
            }
            else
            {
                msg = "Não há Item Pedido para remoção";
                MessageBox.Show(msg, "Item Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LimparDadosPedido();
            HabDesabPedidos(false);
        }

        private void btnBaixaPed_Click(object sender, EventArgs e)
        {
            Camadas.BLL.ItemPedido bllItemPedido = new Camadas.BLL.ItemPedido();
            Camadas.Model.ItemPedido itemPedido = new Camadas.Model.ItemPedido();
            int id = Convert.ToInt32(lblItmPedID.Text);

            string msg = "";
            if (id != -1)
                msg = "Confirma Baixa de Item de Pedido?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Baixa Item de Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resp == DialogResult.Yes)
            {
                itemPedido.id = id;
                itemPedido.pedido = Convert.ToInt32(lblIdPed.Text);
                itemPedido.produto = Convert.ToInt32(txtProduto.Text);
                itemPedido.entrega = DateTime.Now;
                itemPedido.valor = Convert.ToSingle(txtValor.Text);
                TimeSpan date = DateTime.Now - dtpData.Value;
                int totalDias = date.Days;

                itemPedido.dias = totalDias;

                bllItemPedido.Baixa(itemPedido);
            }
            dgvItemPedido.DataSource = "";
            dgvItemPedido.DataSource = bllItemPedido.SelectByPedido(Convert.ToInt32(lblIdPed.Text));
            LimparDadosItemPedido(); 
            HabDesabItemPedido(false);
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCliente.Text = cmbCliente.SelectedValue.ToString();
        }

        private void cmbCliente_Leave(object sender, EventArgs e)
        {
           
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtProduto.Text = cmbProduto.SelectedValue.ToString();
            RecuperarDadosProduto();
        }

        private void cmbProduto_Leave(object sender, EventArgs e)
        {
            RecuperarDadosProduto();
        }

        private void txtProduto_Leave(object sender, EventArgs e)
        {
            try
            {
                cmbProduto.SelectedValue = Convert.ToInt32(txtProduto.Text);
                RecuperarDadosProduto();
                txtValor.Focus();
            }
            catch
            {
                string msg = "Não existe ID do produto selecionado";
                MessageBox.Show(msg, "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProduto.Text = "";
                txtProduto.Focus();
            }
        }

        private void txtCliente_Leave(object sender, EventArgs e)
        {
            try
            {
                cmbCliente.SelectedValue = Convert.ToInt32(txtCliente.Text);
            }
            catch
            {
                string msg = "ID Cliente inválido";
                MessageBox.Show(msg, "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCliente.Text = "";
                txtCliente.Focus();
            }
        }
    }
}
