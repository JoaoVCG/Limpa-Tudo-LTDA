namespace Limpa_Tudo_LTDA
{
    partial class FrmPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbPedidos = new System.Windows.Forms.GroupBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblIdPed = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblIdPedido = new System.Windows.Forms.Label();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.gpbItemPedido = new System.Windows.Forms.GroupBox();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEntrega = new System.Windows.Forms.Label();
            this.lblItmPedID = new System.Windows.Forms.Label();
            this.lblStatusPed = new System.Windows.Forms.Label();
            this.lblTotalPed = new System.Windows.Forms.Label();
            this.lblDiasPed = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblEntregaPed = new System.Windows.Forms.Label();
            this.lblIdItemPedido = new System.Windows.Forms.Label();
            this.btnBaixaPed = new System.Windows.Forms.Button();
            this.btnEditarPed = new System.Windows.Forms.Button();
            this.btnGravarPed = new System.Windows.Forms.Button();
            this.btnCancelarPed = new System.Windows.Forms.Button();
            this.btnRemoverPed = new System.Windows.Forms.Button();
            this.btnAdicionarPed = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dgvItemPedido = new System.Windows.Forms.DataGridView();
            this.gpbPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.gpbItemPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbPedidos
            // 
            this.gpbPedidos.Controls.Add(this.cmbCliente);
            this.gpbPedidos.Controls.Add(this.txtCliente);
            this.gpbPedidos.Controls.Add(this.dtpData);
            this.gpbPedidos.Controls.Add(this.lblIdPed);
            this.gpbPedidos.Controls.Add(this.lblCliente);
            this.gpbPedidos.Controls.Add(this.lblData);
            this.gpbPedidos.Controls.Add(this.lblIdPedido);
            this.gpbPedidos.Location = new System.Drawing.Point(13, 13);
            this.gpbPedidos.Name = "gpbPedidos";
            this.gpbPedidos.Size = new System.Drawing.Size(595, 106);
            this.gpbPedidos.TabIndex = 0;
            this.gpbPedidos.TabStop = false;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(193, 81);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(245, 21);
            this.cmbCliente.TabIndex = 6;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            this.cmbCliente.Leave += new System.EventHandler(this.cmbCliente_Leave);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(134, 81);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(53, 20);
            this.txtCliente.TabIndex = 5;
            this.txtCliente.Leave += new System.EventHandler(this.txtCliente_Leave);
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(134, 52);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(226, 20);
            this.dtpData.TabIndex = 4;
            // 
            // lblIdPed
            // 
            this.lblIdPed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdPed.Location = new System.Drawing.Point(134, 18);
            this.lblIdPed.Name = "lblIdPed";
            this.lblIdPed.Size = new System.Drawing.Size(53, 23);
            this.lblIdPed.TabIndex = 3;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(69, 81);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(59, 18);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente:";
            this.lblCliente.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(37, 49);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(91, 18);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Data Pedido:";
            // 
            // lblIdPedido
            // 
            this.lblIdPedido.AutoSize = true;
            this.lblIdPedido.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPedido.Location = new System.Drawing.Point(55, 16);
            this.lblIdPedido.Name = "lblIdPedido";
            this.lblIdPedido.Size = new System.Drawing.Size(73, 18);
            this.lblIdPedido.TabIndex = 0;
            this.lblIdPedido.Text = "ID Pedido:";
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(15, 180);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.Size = new System.Drawing.Size(595, 107);
            this.dgvPedido.TabIndex = 6;
            this.dgvPedido.DoubleClick += new System.EventHandler(this.dgvPedido_DoubleClick);
            // 
            // gpbItemPedido
            // 
            this.gpbItemPedido.Controls.Add(this.cmbProduto);
            this.gpbItemPedido.Controls.Add(this.txtProduto);
            this.gpbItemPedido.Controls.Add(this.txtValor);
            this.gpbItemPedido.Controls.Add(this.lblDias);
            this.gpbItemPedido.Controls.Add(this.lblTotal);
            this.gpbItemPedido.Controls.Add(this.lblStatus);
            this.gpbItemPedido.Controls.Add(this.lblEntrega);
            this.gpbItemPedido.Controls.Add(this.lblItmPedID);
            this.gpbItemPedido.Controls.Add(this.lblStatusPed);
            this.gpbItemPedido.Controls.Add(this.lblTotalPed);
            this.gpbItemPedido.Controls.Add(this.lblDiasPed);
            this.gpbItemPedido.Controls.Add(this.lblValor);
            this.gpbItemPedido.Controls.Add(this.lblProduto);
            this.gpbItemPedido.Controls.Add(this.lblEntregaPed);
            this.gpbItemPedido.Controls.Add(this.lblIdItemPedido);
            this.gpbItemPedido.Location = new System.Drawing.Point(13, 293);
            this.gpbItemPedido.Name = "gpbItemPedido";
            this.gpbItemPedido.Size = new System.Drawing.Size(597, 196);
            this.gpbItemPedido.TabIndex = 7;
            this.gpbItemPedido.TabStop = false;
            // 
            // cmbProduto
            // 
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(194, 45);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(217, 21);
            this.cmbProduto.TabIndex = 21;
            this.cmbProduto.SelectedIndexChanged += new System.EventHandler(this.cmbProduto_SelectedIndexChanged);
            this.cmbProduto.Leave += new System.EventHandler(this.cmbProduto_Leave);
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(135, 45);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(53, 20);
            this.txtProduto.TabIndex = 20;
            this.txtProduto.Leave += new System.EventHandler(this.txtProduto_Leave);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(135, 107);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(71, 20);
            this.txtValor.TabIndex = 19;
            // 
            // lblDias
            // 
            this.lblDias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDias.Location = new System.Drawing.Point(135, 133);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(53, 23);
            this.lblDias.TabIndex = 18;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(134, 167);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(72, 23);
            this.lblTotal.TabIndex = 17;
            // 
            // lblStatus
            // 
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatus.Location = new System.Drawing.Point(486, 47);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 23);
            this.lblStatus.TabIndex = 16;
            // 
            // lblEntrega
            // 
            this.lblEntrega.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEntrega.Location = new System.Drawing.Point(135, 73);
            this.lblEntrega.Name = "lblEntrega";
            this.lblEntrega.Size = new System.Drawing.Size(153, 23);
            this.lblEntrega.TabIndex = 15;
            // 
            // lblItmPedID
            // 
            this.lblItmPedID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblItmPedID.Location = new System.Drawing.Point(135, 11);
            this.lblItmPedID.Name = "lblItmPedID";
            this.lblItmPedID.Size = new System.Drawing.Size(53, 23);
            this.lblItmPedID.TabIndex = 14;
            // 
            // lblStatusPed
            // 
            this.lblStatusPed.AutoSize = true;
            this.lblStatusPed.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusPed.Location = new System.Drawing.Point(425, 48);
            this.lblStatusPed.Name = "lblStatusPed";
            this.lblStatusPed.Size = new System.Drawing.Size(55, 18);
            this.lblStatusPed.TabIndex = 13;
            this.lblStatusPed.Text = "Status:";
            this.lblStatusPed.Click += new System.EventHandler(this.lblStatusPed_Click);
            // 
            // lblTotalPed
            // 
            this.lblTotalPed.AutoSize = true;
            this.lblTotalPed.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPed.Location = new System.Drawing.Point(82, 167);
            this.lblTotalPed.Name = "lblTotalPed";
            this.lblTotalPed.Size = new System.Drawing.Size(46, 18);
            this.lblTotalPed.TabIndex = 12;
            this.lblTotalPed.Text = "Total:";
            this.lblTotalPed.Click += new System.EventHandler(this.lblTotalPed_Click);
            // 
            // lblDiasPed
            // 
            this.lblDiasPed.AutoSize = true;
            this.lblDiasPed.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasPed.Location = new System.Drawing.Point(5, 133);
            this.lblDiasPed.Name = "lblDiasPed";
            this.lblDiasPed.Size = new System.Drawing.Size(123, 18);
            this.lblDiasPed.TabIndex = 11;
            this.lblDiasPed.Text = "Prazo de Entrega:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(82, 107);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(47, 18);
            this.lblValor.TabIndex = 10;
            this.lblValor.Text = "Valor:";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(65, 45);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(64, 18);
            this.lblProduto.TabIndex = 9;
            this.lblProduto.Text = "Produto:";
            // 
            // lblEntregaPed
            // 
            this.lblEntregaPed.AutoSize = true;
            this.lblEntregaPed.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntregaPed.Location = new System.Drawing.Point(10, 73);
            this.lblEntregaPed.Name = "lblEntregaPed";
            this.lblEntregaPed.Size = new System.Drawing.Size(118, 18);
            this.lblEntregaPed.TabIndex = 8;
            this.lblEntregaPed.Text = "Data de Entrega:";
            // 
            // lblIdItemPedido
            // 
            this.lblIdItemPedido.AutoSize = true;
            this.lblIdItemPedido.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdItemPedido.Location = new System.Drawing.Point(56, 14);
            this.lblIdItemPedido.Name = "lblIdItemPedido";
            this.lblIdItemPedido.Size = new System.Drawing.Size(73, 18);
            this.lblIdItemPedido.TabIndex = 7;
            this.lblIdItemPedido.Text = "ID Pedido:";
            // 
            // btnBaixaPed
            // 
            this.btnBaixaPed.Image = global::Limpa_Tudo_LTDA.Properties.Resources._1498788059_arrow_down;
            this.btnBaixaPed.Location = new System.Drawing.Point(509, 495);
            this.btnBaixaPed.Name = "btnBaixaPed";
            this.btnBaixaPed.Size = new System.Drawing.Size(75, 49);
            this.btnBaixaPed.TabIndex = 13;
            this.btnBaixaPed.UseVisualStyleBackColor = true;
            this.btnBaixaPed.Click += new System.EventHandler(this.btnBaixaPed_Click);
            // 
            // btnEditarPed
            // 
            this.btnEditarPed.Image = global::Limpa_Tudo_LTDA.Properties.Resources._1497748564_Compose;
            this.btnEditarPed.Location = new System.Drawing.Point(130, 495);
            this.btnEditarPed.Name = "btnEditarPed";
            this.btnEditarPed.Size = new System.Drawing.Size(75, 49);
            this.btnEditarPed.TabIndex = 12;
            this.btnEditarPed.UseVisualStyleBackColor = true;
            this.btnEditarPed.Click += new System.EventHandler(this.btnEditarPed_Click);
            // 
            // btnGravarPed
            // 
            this.btnGravarPed.Image = global::Limpa_Tudo_LTDA.Properties.Resources._1497748554_Checkmark;
            this.btnGravarPed.Location = new System.Drawing.Point(226, 495);
            this.btnGravarPed.Name = "btnGravarPed";
            this.btnGravarPed.Size = new System.Drawing.Size(75, 49);
            this.btnGravarPed.TabIndex = 11;
            this.btnGravarPed.UseVisualStyleBackColor = true;
            this.btnGravarPed.Click += new System.EventHandler(this.btnGravarPed_Click);
            // 
            // btnCancelarPed
            // 
            this.btnCancelarPed.Image = global::Limpa_Tudo_LTDA.Properties.Resources._1497748539_Close;
            this.btnCancelarPed.Location = new System.Drawing.Point(322, 495);
            this.btnCancelarPed.Name = "btnCancelarPed";
            this.btnCancelarPed.Size = new System.Drawing.Size(75, 49);
            this.btnCancelarPed.TabIndex = 10;
            this.btnCancelarPed.UseVisualStyleBackColor = true;
            this.btnCancelarPed.Click += new System.EventHandler(this.btnCancelarPed_Click);
            // 
            // btnRemoverPed
            // 
            this.btnRemoverPed.Image = global::Limpa_Tudo_LTDA.Properties.Resources._1497748521_Delete_dustbin_empty_recycle_recycling_remove_trash;
            this.btnRemoverPed.Location = new System.Drawing.Point(418, 495);
            this.btnRemoverPed.Name = "btnRemoverPed";
            this.btnRemoverPed.Size = new System.Drawing.Size(75, 49);
            this.btnRemoverPed.TabIndex = 9;
            this.btnRemoverPed.UseVisualStyleBackColor = true;
            this.btnRemoverPed.Click += new System.EventHandler(this.btnRemoverPed_Click);
            // 
            // btnAdicionarPed
            // 
            this.btnAdicionarPed.Image = global::Limpa_Tudo_LTDA.Properties.Resources._1497748483_Plus_green;
            this.btnAdicionarPed.Location = new System.Drawing.Point(34, 495);
            this.btnAdicionarPed.Name = "btnAdicionarPed";
            this.btnAdicionarPed.Size = new System.Drawing.Size(75, 49);
            this.btnAdicionarPed.TabIndex = 8;
            this.btnAdicionarPed.UseVisualStyleBackColor = true;
            this.btnAdicionarPed.Click += new System.EventHandler(this.btnAdicionarPed_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::Limpa_Tudo_LTDA.Properties.Resources._1497748564_Compose;
            this.btnEditar.Location = new System.Drawing.Point(177, 125);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 49);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Image = global::Limpa_Tudo_LTDA.Properties.Resources._1497748554_Checkmark;
            this.btnGravar.Location = new System.Drawing.Point(273, 125);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 49);
            this.btnGravar.TabIndex = 4;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Limpa_Tudo_LTDA.Properties.Resources._1497748539_Close;
            this.btnCancelar.Location = new System.Drawing.Point(369, 125);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 49);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Image = global::Limpa_Tudo_LTDA.Properties.Resources._1497748521_Delete_dustbin_empty_recycle_recycling_remove_trash;
            this.btnRemover.Location = new System.Drawing.Point(465, 125);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 49);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Image = global::Limpa_Tudo_LTDA.Properties.Resources._1497748483_Plus_green;
            this.btnAdicionar.Location = new System.Drawing.Point(81, 125);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 49);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dgvItemPedido
            // 
            this.dgvItemPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemPedido.Location = new System.Drawing.Point(5, 550);
            this.dgvItemPedido.Name = "dgvItemPedido";
            this.dgvItemPedido.Size = new System.Drawing.Size(605, 129);
            this.dgvItemPedido.TabIndex = 14;
            this.dgvItemPedido.DoubleClick += new System.EventHandler(this.dgvItemPedido_DoubleClick);
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 688);
            this.Controls.Add(this.dgvItemPedido);
            this.Controls.Add(this.btnBaixaPed);
            this.Controls.Add(this.btnEditarPed);
            this.Controls.Add(this.btnGravarPed);
            this.Controls.Add(this.btnCancelarPed);
            this.Controls.Add(this.btnRemoverPed);
            this.Controls.Add(this.btnAdicionarPed);
            this.Controls.Add(this.gpbItemPedido);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.gpbPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPedido";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido de Encomendas";
            this.Load += new System.EventHandler(this.FrmPedido_Load);
            this.gpbPedidos.ResumeLayout(false);
            this.gpbPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.gpbItemPedido.ResumeLayout(false);
            this.gpbItemPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPedidos;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblIdPedido;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblIdPed;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.GroupBox gpbItemPedido;
        private System.Windows.Forms.Label lblStatusPed;
        private System.Windows.Forms.Label lblTotalPed;
        private System.Windows.Forms.Label lblDiasPed;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblEntregaPed;
        private System.Windows.Forms.Label lblIdItemPedido;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEntrega;
        private System.Windows.Forms.Label lblItmPedID;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Button btnEditarPed;
        private System.Windows.Forms.Button btnGravarPed;
        private System.Windows.Forms.Button btnCancelarPed;
        private System.Windows.Forms.Button btnRemoverPed;
        private System.Windows.Forms.Button btnAdicionarPed;
        private System.Windows.Forms.Button btnBaixaPed;
        private System.Windows.Forms.DataGridView dgvItemPedido;
    }
}