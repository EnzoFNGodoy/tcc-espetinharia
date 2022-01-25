namespace Espetinho_TCC.Apresentação.Fornecedor
{
    partial class frmGerenciarPedidosForn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarPedidosForn));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gvExibirEntradas = new System.Windows.Forms.DataGridView();
            this.btnOKPesquisa = new System.Windows.Forms.Button();
            this.lblAte = new System.Windows.Forms.Label();
            this.dtpPesqTermino = new System.Windows.Forms.DateTimePicker();
            this.pbPesquisarPorPeriodo = new System.Windows.Forms.PictureBox();
            this.lblPesquisarPorPeriodo = new System.Windows.Forms.Label();
            this.dtpPesqInicio = new System.Windows.Forms.DateTimePicker();
            this.btnExcluirPedido = new System.Windows.Forms.Button();
            this.btnRemoverProdLista = new System.Windows.Forms.Button();
            this.pnlDireita = new System.Windows.Forms.Panel();
            this.gvExibirProdutos = new System.Windows.Forms.DataGridView();
            this.clnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnIdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnProdutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPrecoUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPrecoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlRodapé = new System.Windows.Forms.Panel();
            this.btnAddProdutos = new System.Windows.Forms.Button();
            this.pnlEsquerda = new System.Windows.Forms.Panel();
            this.mskHora = new System.Windows.Forms.MaskedTextBox();
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbUsuarioAtivo = new System.Windows.Forms.PictureBox();
            this.lblNomeUsuAtivo = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pbValor = new System.Windows.Forms.PictureBox();
            this.pbProduto = new System.Windows.Forms.PictureBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.pbHora = new System.Windows.Forms.PictureBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnAlterarPedido = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.pbData = new System.Windows.Forms.PictureBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.pbID = new System.Windows.Forms.PictureBox();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.btnNovoPedido = new System.Windows.Forms.Button();
            this.btnCadastrarPedido = new System.Windows.Forms.Button();
            this.pbForn = new System.Windows.Forms.PictureBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.btnSelecionarForn = new System.Windows.Forms.Button();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPesquisarPorPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirProdutos)).BeginInit();
            this.pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarioAtivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForn)).BeginInit();
            this.SuspendLayout();
            // 
            // gvExibirEntradas
            // 
            this.gvExibirEntradas.AllowUserToAddRows = false;
            this.gvExibirEntradas.AllowUserToDeleteRows = false;
            this.gvExibirEntradas.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.gvExibirEntradas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gvExibirEntradas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvExibirEntradas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gvExibirEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvExibirEntradas.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvExibirEntradas.DefaultCellStyle = dataGridViewCellStyle8;
            this.gvExibirEntradas.Location = new System.Drawing.Point(746, 151);
            this.gvExibirEntradas.MultiSelect = false;
            this.gvExibirEntradas.Name = "gvExibirEntradas";
            this.gvExibirEntradas.ReadOnly = true;
            this.gvExibirEntradas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gvExibirEntradas.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.gvExibirEntradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvExibirEntradas.Size = new System.Drawing.Size(691, 452);
            this.gvExibirEntradas.TabIndex = 391;
            this.gvExibirEntradas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvExibirEntradas_CellDoubleClick);
            // 
            // btnOKPesquisa
            // 
            this.btnOKPesquisa.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOKPesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOKPesquisa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOKPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOKPesquisa.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.btnOKPesquisa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOKPesquisa.Location = new System.Drawing.Point(1379, 103);
            this.btnOKPesquisa.Name = "btnOKPesquisa";
            this.btnOKPesquisa.Size = new System.Drawing.Size(58, 39);
            this.btnOKPesquisa.TabIndex = 390;
            this.btnOKPesquisa.Text = "OK";
            this.btnOKPesquisa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOKPesquisa.UseVisualStyleBackColor = false;
            // 
            // lblAte
            // 
            this.lblAte.AutoSize = true;
            this.lblAte.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAte.Location = new System.Drawing.Point(1030, 108);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(48, 32);
            this.lblAte.TabIndex = 389;
            this.lblAte.Text = "até";
            // 
            // dtpPesqTermino
            // 
            this.dtpPesqTermino.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.dtpPesqTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPesqTermino.Location = new System.Drawing.Point(1084, 103);
            this.dtpPesqTermino.Name = "dtpPesqTermino";
            this.dtpPesqTermino.Size = new System.Drawing.Size(278, 39);
            this.dtpPesqTermino.TabIndex = 388;
            // 
            // pbPesquisarPorPeriodo
            // 
            this.pbPesquisarPorPeriodo.Image = ((System.Drawing.Image)(resources.GetObject("pbPesquisarPorPeriodo.Image")));
            this.pbPesquisarPorPeriodo.Location = new System.Drawing.Point(745, 65);
            this.pbPesquisarPorPeriodo.Name = "pbPesquisarPorPeriodo";
            this.pbPesquisarPorPeriodo.Size = new System.Drawing.Size(56, 37);
            this.pbPesquisarPorPeriodo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPesquisarPorPeriodo.TabIndex = 386;
            this.pbPesquisarPorPeriodo.TabStop = false;
            // 
            // lblPesquisarPorPeriodo
            // 
            this.lblPesquisarPorPeriodo.AutoSize = true;
            this.lblPesquisarPorPeriodo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisarPorPeriodo.Location = new System.Drawing.Point(804, 70);
            this.lblPesquisarPorPeriodo.Name = "lblPesquisarPorPeriodo";
            this.lblPesquisarPorPeriodo.Size = new System.Drawing.Size(250, 32);
            this.lblPesquisarPorPeriodo.TabIndex = 385;
            this.lblPesquisarPorPeriodo.Text = "Pesquisar por Periodo:";
            // 
            // dtpPesqInicio
            // 
            this.dtpPesqInicio.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.dtpPesqInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPesqInicio.Location = new System.Drawing.Point(746, 105);
            this.dtpPesqInicio.Name = "dtpPesqInicio";
            this.dtpPesqInicio.Size = new System.Drawing.Size(278, 39);
            this.dtpPesqInicio.TabIndex = 387;
            // 
            // btnExcluirPedido
            // 
            this.btnExcluirPedido.BackColor = System.Drawing.Color.Tomato;
            this.btnExcluirPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirPedido.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExcluirPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirPedido.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirPedido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExcluirPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirPedido.Image")));
            this.btnExcluirPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirPedido.Location = new System.Drawing.Point(449, 512);
            this.btnExcluirPedido.Name = "btnExcluirPedido";
            this.btnExcluirPedido.Size = new System.Drawing.Size(281, 90);
            this.btnExcluirPedido.TabIndex = 384;
            this.btnExcluirPedido.Text = "         EXCLUIR ITEM";
            this.btnExcluirPedido.UseVisualStyleBackColor = false;
            this.btnExcluirPedido.Click += new System.EventHandler(this.btnExcluirPedido_Click);
            // 
            // btnRemoverProdLista
            // 
            this.btnRemoverProdLista.BackColor = System.Drawing.Color.Crimson;
            this.btnRemoverProdLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoverProdLista.Enabled = false;
            this.btnRemoverProdLista.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRemoverProdLista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoverProdLista.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverProdLista.Image")));
            this.btnRemoverProdLista.Location = new System.Drawing.Point(245, 151);
            this.btnRemoverProdLista.Name = "btnRemoverProdLista";
            this.btnRemoverProdLista.Size = new System.Drawing.Size(56, 40);
            this.btnRemoverProdLista.TabIndex = 383;
            this.btnRemoverProdLista.UseVisualStyleBackColor = false;
            this.btnRemoverProdLista.Visible = false;
            this.btnRemoverProdLista.Click += new System.EventHandler(this.btnRemoverProdLista_Click);
            // 
            // pnlDireita
            // 
            this.pnlDireita.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlDireita.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDireita.Location = new System.Drawing.Point(1445, 45);
            this.pnlDireita.Name = "pnlDireita";
            this.pnlDireita.Size = new System.Drawing.Size(5, 572);
            this.pnlDireita.TabIndex = 359;
            // 
            // gvExibirProdutos
            // 
            this.gvExibirProdutos.AllowUserToAddRows = false;
            this.gvExibirProdutos.AllowUserToDeleteRows = false;
            this.gvExibirProdutos.AllowUserToResizeColumns = false;
            this.gvExibirProdutos.AllowUserToResizeRows = false;
            this.gvExibirProdutos.BackgroundColor = System.Drawing.Color.MintCream;
            this.gvExibirProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gvExibirProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvExibirProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gvExibirProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvExibirProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCodigo,
            this.clnIdProduto,
            this.clnProdutos,
            this.clnPrecoUnit,
            this.clnPrecoTotal,
            this.clnQtd});
            this.gvExibirProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvExibirProdutos.DefaultCellStyle = dataGridViewCellStyle11;
            this.gvExibirProdutos.Location = new System.Drawing.Point(12, 197);
            this.gvExibirProdutos.MultiSelect = false;
            this.gvExibirProdutos.Name = "gvExibirProdutos";
            this.gvExibirProdutos.ReadOnly = true;
            this.gvExibirProdutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gvExibirProdutos.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.gvExibirProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvExibirProdutos.Size = new System.Drawing.Size(430, 311);
            this.gvExibirProdutos.TabIndex = 382;
            this.gvExibirProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvExibirProdutos_CellClick);
            this.gvExibirProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvExibirProdutos_CellContentClick);
            // 
            // clnCodigo
            // 
            this.clnCodigo.HeaderText = "Codigo";
            this.clnCodigo.Name = "clnCodigo";
            this.clnCodigo.ReadOnly = true;
            this.clnCodigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnCodigo.Visible = false;
            // 
            // clnIdProduto
            // 
            this.clnIdProduto.HeaderText = "Codigo Produto";
            this.clnIdProduto.Name = "clnIdProduto";
            this.clnIdProduto.ReadOnly = true;
            this.clnIdProduto.Visible = false;
            // 
            // clnProdutos
            // 
            this.clnProdutos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnProdutos.HeaderText = "Produto";
            this.clnProdutos.Name = "clnProdutos";
            this.clnProdutos.ReadOnly = true;
            this.clnProdutos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clnPrecoUnit
            // 
            this.clnPrecoUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnPrecoUnit.HeaderText = "Preço Unit.";
            this.clnPrecoUnit.Name = "clnPrecoUnit";
            this.clnPrecoUnit.ReadOnly = true;
            this.clnPrecoUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clnPrecoTotal
            // 
            this.clnPrecoTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnPrecoTotal.HeaderText = "Preço Total";
            this.clnPrecoTotal.Name = "clnPrecoTotal";
            this.clnPrecoTotal.ReadOnly = true;
            this.clnPrecoTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clnQtd
            // 
            this.clnQtd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnQtd.HeaderText = "Qtd.";
            this.clnQtd.Name = "clnQtd";
            this.clnQtd.ReadOnly = true;
            this.clnQtd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pnlRodapé
            // 
            this.pnlRodapé.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlRodapé.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodapé.Location = new System.Drawing.Point(5, 617);
            this.pnlRodapé.Name = "pnlRodapé";
            this.pnlRodapé.Size = new System.Drawing.Size(1445, 5);
            this.pnlRodapé.TabIndex = 358;
            // 
            // btnAddProdutos
            // 
            this.btnAddProdutos.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProdutos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddProdutos.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProdutos.Image")));
            this.btnAddProdutos.Location = new System.Drawing.Point(183, 151);
            this.btnAddProdutos.Name = "btnAddProdutos";
            this.btnAddProdutos.Size = new System.Drawing.Size(56, 40);
            this.btnAddProdutos.TabIndex = 381;
            this.btnAddProdutos.UseVisualStyleBackColor = false;
            this.btnAddProdutos.Click += new System.EventHandler(this.btnAddProdutos_Click);
            // 
            // pnlEsquerda
            // 
            this.pnlEsquerda.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlEsquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEsquerda.Location = new System.Drawing.Point(0, 45);
            this.pnlEsquerda.Name = "pnlEsquerda";
            this.pnlEsquerda.Size = new System.Drawing.Size(5, 577);
            this.pnlEsquerda.TabIndex = 357;
            // 
            // mskHora
            // 
            this.mskHora.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.mskHora.Location = new System.Drawing.Point(449, 106);
            this.mskHora.Mask = "90:00";
            this.mskHora.Name = "mskHora";
            this.mskHora.Size = new System.Drawing.Size(280, 39);
            this.mskHora.TabIndex = 380;
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlCabecalho.Controls.Add(this.lblTitulo);
            this.pnlCabecalho.Controls.Add(this.pbUsuarioAtivo);
            this.pnlCabecalho.Controls.Add(this.lblNomeUsuAtivo);
            this.pnlCabecalho.Controls.Add(this.btnMenu);
            this.pnlCabecalho.Controls.Add(this.btnFechar);
            this.pnlCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new System.Drawing.Size(1450, 45);
            this.pnlCabecalho.TabIndex = 356;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(442, 2);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(551, 41);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "GERENCIAR PEDIDOS DO FORNECEDOR";
            // 
            // pbUsuarioAtivo
            // 
            this.pbUsuarioAtivo.Image = ((System.Drawing.Image)(resources.GetObject("pbUsuarioAtivo.Image")));
            this.pbUsuarioAtivo.Location = new System.Drawing.Point(1188, 2);
            this.pbUsuarioAtivo.Name = "pbUsuarioAtivo";
            this.pbUsuarioAtivo.Size = new System.Drawing.Size(42, 40);
            this.pbUsuarioAtivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbUsuarioAtivo.TabIndex = 14;
            this.pbUsuarioAtivo.TabStop = false;
            this.pbUsuarioAtivo.Visible = false;
            // 
            // lblNomeUsuAtivo
            // 
            this.lblNomeUsuAtivo.AutoSize = true;
            this.lblNomeUsuAtivo.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuAtivo.ForeColor = System.Drawing.Color.White;
            this.lblNomeUsuAtivo.Image = ((System.Drawing.Image)(resources.GetObject("lblNomeUsuAtivo.Image")));
            this.lblNomeUsuAtivo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNomeUsuAtivo.Location = new System.Drawing.Point(1236, 7);
            this.lblNomeUsuAtivo.Name = "lblNomeUsuAtivo";
            this.lblNomeUsuAtivo.Size = new System.Drawing.Size(0, 30);
            this.lblNomeUsuAtivo.TabIndex = 13;
            this.lblNomeUsuAtivo.Visible = false;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(1, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(47, 45);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.UseVisualStyleBackColor = false;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(1403, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(47, 46);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pbValor
            // 
            this.pbValor.Image = ((System.Drawing.Image)(resources.GetObject("pbValor.Image")));
            this.pbValor.Location = new System.Drawing.Point(448, 151);
            this.pbValor.Name = "pbValor";
            this.pbValor.Size = new System.Drawing.Size(56, 37);
            this.pbValor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbValor.TabIndex = 376;
            this.pbValor.TabStop = false;
            // 
            // pbProduto
            // 
            this.pbProduto.Image = ((System.Drawing.Image)(resources.GetObject("pbProduto.Image")));
            this.pbProduto.Location = new System.Drawing.Point(12, 151);
            this.pbProduto.Name = "pbProduto";
            this.pbProduto.Size = new System.Drawing.Size(56, 37);
            this.pbProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProduto.TabIndex = 361;
            this.pbProduto.TabStop = false;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtValor.Location = new System.Drawing.Point(448, 194);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(281, 39);
            this.txtValor.TabIndex = 375;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(507, 153);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(131, 32);
            this.lblValor.TabIndex = 374;
            this.lblValor.Text = "Valor Total:";
            // 
            // pbHora
            // 
            this.pbHora.Image = ((System.Drawing.Image)(resources.GetObject("pbHora.Image")));
            this.pbHora.Location = new System.Drawing.Point(448, 66);
            this.pbHora.Name = "pbHora";
            this.pbHora.Size = new System.Drawing.Size(56, 37);
            this.pbHora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHora.TabIndex = 373;
            this.pbHora.TabStop = false;
            // 
            // dtpData
            // 
            this.dtpData.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(184, 106);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(258, 39);
            this.dtpData.TabIndex = 379;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(507, 71);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(71, 32);
            this.lblHora.TabIndex = 372;
            this.lblHora.Text = "Hora:";
            // 
            // btnAlterarPedido
            // 
            this.btnAlterarPedido.BackColor = System.Drawing.Color.Yellow;
            this.btnAlterarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarPedido.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnAlterarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarPedido.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F);
            this.btnAlterarPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarPedido.Image")));
            this.btnAlterarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarPedido.Location = new System.Drawing.Point(448, 418);
            this.btnAlterarPedido.Name = "btnAlterarPedido";
            this.btnAlterarPedido.Size = new System.Drawing.Size(281, 90);
            this.btnAlterarPedido.TabIndex = 370;
            this.btnAlterarPedido.Text = " ALTERAR";
            this.btnAlterarPedido.UseVisualStyleBackColor = false;
            this.btnAlterarPedido.Click += new System.EventHandler(this.btnAlterarPedido_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(68, 71);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(43, 32);
            this.lblID.TabIndex = 362;
            this.lblID.Text = "ID:";
            // 
            // pbData
            // 
            this.pbData.Image = ((System.Drawing.Image)(resources.GetObject("pbData.Image")));
            this.pbData.Location = new System.Drawing.Point(183, 66);
            this.pbData.Name = "pbData";
            this.pbData.Size = new System.Drawing.Size(56, 37);
            this.pbData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbData.TabIndex = 369;
            this.pbData.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtID.Location = new System.Drawing.Point(12, 106);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(165, 39);
            this.txtID.TabIndex = 363;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(242, 71);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(69, 32);
            this.lblData.TabIndex = 368;
            this.lblData.Text = "Data:";
            // 
            // pbID
            // 
            this.pbID.Image = ((System.Drawing.Image)(resources.GetObject("pbID.Image")));
            this.pbID.Location = new System.Drawing.Point(12, 66);
            this.pbID.Name = "pbID";
            this.pbID.Size = new System.Drawing.Size(56, 37);
            this.pbID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbID.TabIndex = 364;
            this.pbID.TabStop = false;
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutos.Location = new System.Drawing.Point(69, 156);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(115, 32);
            this.lblProdutos.TabIndex = 360;
            this.lblProdutos.Text = "Produtos:";
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.BackColor = System.Drawing.Color.Tomato;
            this.btnCancelarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarPedido.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCancelarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarPedido.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.btnCancelarPedido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelarPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarPedido.Image")));
            this.btnCancelarPedido.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelarPedido.Location = new System.Drawing.Point(449, 418);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(281, 185);
            this.btnCancelarPedido.TabIndex = 378;
            this.btnCancelarPedido.Text = "CANCELAR";
            this.btnCancelarPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarPedido.UseVisualStyleBackColor = false;
            this.btnCancelarPedido.Visible = false;
            this.btnCancelarPedido.Click += new System.EventHandler(this.btnCancelarPedido_Click);
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNovoPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoPedido.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnNovoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoPedido.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.btnNovoPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoPedido.Image")));
            this.btnNovoPedido.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovoPedido.Location = new System.Drawing.Point(448, 239);
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.Size = new System.Drawing.Size(281, 167);
            this.btnNovoPedido.TabIndex = 377;
            this.btnNovoPedido.Text = "NOVO";
            this.btnNovoPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovoPedido.UseVisualStyleBackColor = false;
            this.btnNovoPedido.Click += new System.EventHandler(this.btnNovoPedido_Click);
            // 
            // btnCadastrarPedido
            // 
            this.btnCadastrarPedido.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCadastrarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarPedido.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnCadastrarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarPedido.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.btnCadastrarPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarPedido.Image")));
            this.btnCadastrarPedido.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrarPedido.Location = new System.Drawing.Point(448, 239);
            this.btnCadastrarPedido.Name = "btnCadastrarPedido";
            this.btnCadastrarPedido.Size = new System.Drawing.Size(281, 166);
            this.btnCadastrarPedido.TabIndex = 371;
            this.btnCadastrarPedido.Text = "CADASTRAR";
            this.btnCadastrarPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrarPedido.UseVisualStyleBackColor = false;
            this.btnCadastrarPedido.Click += new System.EventHandler(this.btnCadastrarPedido_Click);
            // 
            // pbForn
            // 
            this.pbForn.Image = ((System.Drawing.Image)(resources.GetObject("pbForn.Image")));
            this.pbForn.Location = new System.Drawing.Point(12, 518);
            this.pbForn.Name = "pbForn";
            this.pbForn.Size = new System.Drawing.Size(48, 37);
            this.pbForn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbForn.TabIndex = 394;
            this.pbForn.TabStop = false;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.Location = new System.Drawing.Point(60, 521);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(141, 32);
            this.lblFornecedor.TabIndex = 392;
            this.lblFornecedor.Text = "Fornecedor:";
            // 
            // btnSelecionarForn
            // 
            this.btnSelecionarForn.BackColor = System.Drawing.Color.LightBlue;
            this.btnSelecionarForn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionarForn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSelecionarForn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelecionarForn.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarForn.Image")));
            this.btnSelecionarForn.Location = new System.Drawing.Point(385, 559);
            this.btnSelecionarForn.Name = "btnSelecionarForn";
            this.btnSelecionarForn.Size = new System.Drawing.Size(57, 39);
            this.btnSelecionarForn.TabIndex = 395;
            this.btnSelecionarForn.UseVisualStyleBackColor = false;
            this.btnSelecionarForn.Click += new System.EventHandler(this.btnSelecionarForn_Click);
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Enabled = false;
            this.txtFornecedor.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtFornecedor.Location = new System.Drawing.Point(12, 559);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.ReadOnly = true;
            this.txtFornecedor.Size = new System.Drawing.Size(374, 39);
            this.txtFornecedor.TabIndex = 393;
            // 
            // frmGerenciarPedidosForn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1450, 622);
            this.Controls.Add(this.pbForn);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.btnSelecionarForn);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.gvExibirEntradas);
            this.Controls.Add(this.btnOKPesquisa);
            this.Controls.Add(this.lblAte);
            this.Controls.Add(this.dtpPesqTermino);
            this.Controls.Add(this.pbPesquisarPorPeriodo);
            this.Controls.Add(this.lblPesquisarPorPeriodo);
            this.Controls.Add(this.dtpPesqInicio);
            this.Controls.Add(this.btnRemoverProdLista);
            this.Controls.Add(this.pnlDireita);
            this.Controls.Add(this.gvExibirProdutos);
            this.Controls.Add(this.pnlRodapé);
            this.Controls.Add(this.btnAddProdutos);
            this.Controls.Add(this.pnlEsquerda);
            this.Controls.Add(this.mskHora);
            this.Controls.Add(this.pnlCabecalho);
            this.Controls.Add(this.pbValor);
            this.Controls.Add(this.pbProduto);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.pbHora);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btnAlterarPedido);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.pbData);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.pbID);
            this.Controls.Add(this.lblProdutos);
            this.Controls.Add(this.btnExcluirPedido);
            this.Controls.Add(this.btnCancelarPedido);
            this.Controls.Add(this.btnNovoPedido);
            this.Controls.Add(this.btnCadastrarPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmGerenciarPedidosForn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGerenciarPedidosForn";
            this.Load += new System.EventHandler(this.frmGerenciarPedidosForn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPesquisarPorPeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirProdutos)).EndInit();
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarioAtivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView gvExibirEntradas;
        private System.Windows.Forms.Button btnOKPesquisa;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.DateTimePicker dtpPesqTermino;
        private System.Windows.Forms.PictureBox pbPesquisarPorPeriodo;
        private System.Windows.Forms.Label lblPesquisarPorPeriodo;
        private System.Windows.Forms.DateTimePicker dtpPesqInicio;
        private System.Windows.Forms.Button btnExcluirPedido;
        private System.Windows.Forms.Button btnRemoverProdLista;
        private System.Windows.Forms.Panel pnlDireita;
        public System.Windows.Forms.DataGridView gvExibirProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPrecoUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPrecoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnQtd;
        private System.Windows.Forms.Panel pnlRodapé;
        private System.Windows.Forms.Button btnAddProdutos;
        private System.Windows.Forms.Panel pnlEsquerda;
        private System.Windows.Forms.MaskedTextBox mskHora;
        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbUsuarioAtivo;
        private System.Windows.Forms.Label lblNomeUsuAtivo;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox pbValor;
        private System.Windows.Forms.PictureBox pbProduto;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.PictureBox pbHora;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnAlterarPedido;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.PictureBox pbData;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.PictureBox pbID;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.Button btnNovoPedido;
        private System.Windows.Forms.Button btnCadastrarPedido;
        private System.Windows.Forms.PictureBox pbForn;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Button btnSelecionarForn;
        private System.Windows.Forms.TextBox txtFornecedor;
    }
}