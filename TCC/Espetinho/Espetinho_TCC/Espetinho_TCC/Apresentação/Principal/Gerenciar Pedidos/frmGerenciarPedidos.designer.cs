namespace Espetinho_TCC.Apresentação.Principal
{
    partial class frmGerenciarPedidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarPedidos));
            this.gvExibirPedidos = new System.Windows.Forms.DataGridView();
            this.btnOKPesquisa = new System.Windows.Forms.Button();
            this.lblAte = new System.Windows.Forms.Label();
            this.dtpPesqTermino = new System.Windows.Forms.DateTimePicker();
            this.lblPesquisarPorPeriodo = new System.Windows.Forms.Label();
            this.dtpPesqInicio = new System.Windows.Forms.DateTimePicker();
            this.pnlDireita = new System.Windows.Forms.Panel();
            this.gvExibirProdutos = new System.Windows.Forms.DataGridView();
            this.clnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnIdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnProdutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPrecoUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPrecoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlRodapé = new System.Windows.Forms.Panel();
            this.pnlEsquerda = new System.Windows.Forms.Panel();
            this.mskHora = new System.Windows.Forms.MaskedTextBox();
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAtualizarHora = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPagto = new System.Windows.Forms.TextBox();
            this.txtCli = new System.Windows.Forms.TextBox();
            this.txtFunc = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBuscarPagto = new System.Windows.Forms.Button();
            this.btnBuscarFunc = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.pbPesquisarPorPeriodo = new System.Windows.Forms.PictureBox();
            this.btnExcluirPedidos = new System.Windows.Forms.Button();
            this.btnRemoverProdLista = new System.Windows.Forms.Button();
            this.btnAddProdutos = new System.Windows.Forms.Button();
            this.pbValor = new System.Windows.Forms.PictureBox();
            this.pbProduto = new System.Windows.Forms.PictureBox();
            this.pbHora = new System.Windows.Forms.PictureBox();
            this.btnAlterarPedidos = new System.Windows.Forms.Button();
            this.pbData = new System.Windows.Forms.PictureBox();
            this.pbID = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirProdutos)).BeginInit();
            this.pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPesquisarPorPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbID)).BeginInit();
            this.SuspendLayout();
            // 
            // gvExibirPedidos
            // 
            this.gvExibirPedidos.AllowUserToAddRows = false;
            this.gvExibirPedidos.AllowUserToDeleteRows = false;
            this.gvExibirPedidos.AllowUserToResizeColumns = false;
            this.gvExibirPedidos.AllowUserToResizeRows = false;
            this.gvExibirPedidos.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.gvExibirPedidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gvExibirPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvExibirPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvExibirPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvExibirPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvExibirPedidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvExibirPedidos.Location = new System.Drawing.Point(746, 151);
            this.gvExibirPedidos.MultiSelect = false;
            this.gvExibirPedidos.Name = "gvExibirPedidos";
            this.gvExibirPedidos.ReadOnly = true;
            this.gvExibirPedidos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gvExibirPedidos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gvExibirPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvExibirPedidos.Size = new System.Drawing.Size(691, 491);
            this.gvExibirPedidos.TabIndex = 391;
            this.gvExibirPedidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvExibirPedidos_CellDoubleClick);
            // 
            // btnOKPesquisa
            // 
            this.btnOKPesquisa.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOKPesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOKPesquisa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOKPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOKPesquisa.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.btnOKPesquisa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOKPesquisa.Location = new System.Drawing.Point(1379, 102);
            this.btnOKPesquisa.Name = "btnOKPesquisa";
            this.btnOKPesquisa.Size = new System.Drawing.Size(58, 39);
            this.btnOKPesquisa.TabIndex = 390;
            this.btnOKPesquisa.Text = "OK";
            this.btnOKPesquisa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOKPesquisa.UseVisualStyleBackColor = false;
            this.btnOKPesquisa.Click += new System.EventHandler(this.btnOKPesquisa_Click);
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
            // pnlDireita
            // 
            this.pnlDireita.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlDireita.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDireita.Location = new System.Drawing.Point(1444, 45);
            this.pnlDireita.Name = "pnlDireita";
            this.pnlDireita.Size = new System.Drawing.Size(5, 600);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvExibirProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvExibirProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvExibirProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCodigo,
            this.clnIdProduto,
            this.clnProdutos,
            this.clnPrecoUnit,
            this.clnPrecoTotal,
            this.clnQtd});
            this.gvExibirProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvExibirProdutos.DefaultCellStyle = dataGridViewCellStyle5;
            this.gvExibirProdutos.Location = new System.Drawing.Point(12, 306);
            this.gvExibirProdutos.MultiSelect = false;
            this.gvExibirProdutos.Name = "gvExibirProdutos";
            this.gvExibirProdutos.ReadOnly = true;
            this.gvExibirProdutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gvExibirProdutos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gvExibirProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvExibirProdutos.Size = new System.Drawing.Size(430, 332);
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
            this.pnlRodapé.Location = new System.Drawing.Point(5, 645);
            this.pnlRodapé.Name = "pnlRodapé";
            this.pnlRodapé.Size = new System.Drawing.Size(1444, 5);
            this.pnlRodapé.TabIndex = 358;
            // 
            // pnlEsquerda
            // 
            this.pnlEsquerda.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlEsquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEsquerda.Location = new System.Drawing.Point(0, 45);
            this.pnlEsquerda.Name = "pnlEsquerda";
            this.pnlEsquerda.Size = new System.Drawing.Size(5, 605);
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
            this.mskHora.TextChanged += new System.EventHandler(this.mskHora_TextChanged);
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlCabecalho.Controls.Add(this.lblTitulo);
            this.pnlCabecalho.Controls.Add(this.btnMenu);
            this.pnlCabecalho.Controls.Add(this.btnFechar);
            this.pnlCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new System.Drawing.Size(1449, 45);
            this.pnlCabecalho.TabIndex = 356;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(549, 2);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(302, 41);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "GERENCIAR PEDIDOS";
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(3, 0);
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
            this.btnFechar.Location = new System.Drawing.Point(1402, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(47, 46);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtValor.Location = new System.Drawing.Point(448, 302);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(281, 39);
            this.txtValor.TabIndex = 375;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(507, 261);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(131, 32);
            this.lblValor.TabIndex = 374;
            this.lblValor.Text = "Valor Total:";
            // 
            // dtpData
            // 
            this.dtpData.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(184, 106);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(258, 39);
            this.dtpData.TabIndex = 379;
            this.dtpData.ValueChanged += new System.EventHandler(this.dtpData_ValueChanged);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(510, 71);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(71, 32);
            this.lblHora.TabIndex = 372;
            this.lblHora.Text = "Hora:";
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
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtID.Location = new System.Drawing.Point(12, 106);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(165, 39);
            this.txtID.TabIndex = 363;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
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
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutos.Location = new System.Drawing.Point(69, 265);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(115, 32);
            this.lblProdutos.TabIndex = 360;
            this.lblProdutos.Text = "Produtos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 396;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(549, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 32);
            this.label2.TabIndex = 398;
            this.label2.Text = "Funcionário";
            // 
            // btnAtualizarHora
            // 
            this.btnAtualizarHora.BackColor = System.Drawing.Color.Aqua;
            this.btnAtualizarHora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizarHora.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAtualizarHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarHora.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarHora.Location = new System.Drawing.Point(587, 66);
            this.btnAtualizarHora.Name = "btnAtualizarHora";
            this.btnAtualizarHora.Size = new System.Drawing.Size(142, 37);
            this.btnAtualizarHora.TabIndex = 400;
            this.btnAtualizarHora.Text = "Atualizar Hora";
            this.btnAtualizarHora.UseVisualStyleBackColor = false;
            this.btnAtualizarHora.Click += new System.EventHandler(this.btnAtualizarHora_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 32);
            this.label3.TabIndex = 403;
            this.label3.Text = "Pagamento";
            // 
            // txtPagto
            // 
            this.txtPagto.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtPagto.Location = new System.Drawing.Point(12, 194);
            this.txtPagto.Name = "txtPagto";
            this.txtPagto.ReadOnly = true;
            this.txtPagto.Size = new System.Drawing.Size(166, 39);
            this.txtPagto.TabIndex = 410;
            this.txtPagto.TextChanged += new System.EventHandler(this.txtPagto_TextChanged);
            // 
            // txtCli
            // 
            this.txtCli.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtCli.Location = new System.Drawing.Point(248, 194);
            this.txtCli.Name = "txtCli";
            this.txtCli.ReadOnly = true;
            this.txtCli.Size = new System.Drawing.Size(167, 39);
            this.txtCli.TabIndex = 411;
            this.txtCli.TextChanged += new System.EventHandler(this.txtCli_TextChanged);
            // 
            // txtFunc
            // 
            this.txtFunc.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtFunc.Location = new System.Drawing.Point(493, 195);
            this.txtFunc.Name = "txtFunc";
            this.txtFunc.ReadOnly = true;
            this.txtFunc.Size = new System.Drawing.Size(169, 39);
            this.txtFunc.TabIndex = 412;
            this.txtFunc.TextChanged += new System.EventHandler(this.txtFunc_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 151);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 409;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(248, 151);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 408;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(493, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 407;
            this.pictureBox1.TabStop = false;
            // 
            // btnBuscarPagto
            // 
            this.btnBuscarPagto.BackColor = System.Drawing.Color.Cyan;
            this.btnBuscarPagto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarPagto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarPagto.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPagto.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnBuscarPagto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarPagto.Image")));
            this.btnBuscarPagto.Location = new System.Drawing.Point(178, 194);
            this.btnBuscarPagto.Name = "btnBuscarPagto";
            this.btnBuscarPagto.Size = new System.Drawing.Size(50, 39);
            this.btnBuscarPagto.TabIndex = 402;
            this.btnBuscarPagto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarPagto.UseVisualStyleBackColor = false;
            this.btnBuscarPagto.Click += new System.EventHandler(this.btnBuscarPagto_Click);
            // 
            // btnBuscarFunc
            // 
            this.btnBuscarFunc.BackColor = System.Drawing.Color.Cyan;
            this.btnBuscarFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarFunc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarFunc.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFunc.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnBuscarFunc.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarFunc.Image")));
            this.btnBuscarFunc.Location = new System.Drawing.Point(662, 195);
            this.btnBuscarFunc.Name = "btnBuscarFunc";
            this.btnBuscarFunc.Size = new System.Drawing.Size(50, 39);
            this.btnBuscarFunc.TabIndex = 395;
            this.btnBuscarFunc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarFunc.UseVisualStyleBackColor = false;
            this.btnBuscarFunc.Click += new System.EventHandler(this.btnBuscarFunc_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.Cyan;
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
            this.btnBuscarCliente.Location = new System.Drawing.Point(415, 194);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(50, 39);
            this.btnBuscarCliente.TabIndex = 393;
            this.btnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
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
            // btnExcluirPedidos
            // 
            this.btnExcluirPedidos.BackColor = System.Drawing.Color.Tomato;
            this.btnExcluirPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirPedidos.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExcluirPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirPedidos.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirPedidos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExcluirPedidos.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirPedidos.Image")));
            this.btnExcluirPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirPedidos.Location = new System.Drawing.Point(448, 501);
            this.btnExcluirPedidos.Name = "btnExcluirPedidos";
            this.btnExcluirPedidos.Size = new System.Drawing.Size(281, 137);
            this.btnExcluirPedidos.TabIndex = 384;
            this.btnExcluirPedidos.Text = "         EXCLUIR ITEM";
            this.btnExcluirPedidos.UseVisualStyleBackColor = false;
            this.btnExcluirPedidos.Click += new System.EventHandler(this.btnExcluirPedidos_Click);
            // 
            // btnRemoverProdLista
            // 
            this.btnRemoverProdLista.BackColor = System.Drawing.Color.Crimson;
            this.btnRemoverProdLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoverProdLista.Enabled = false;
            this.btnRemoverProdLista.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRemoverProdLista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoverProdLista.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverProdLista.Image")));
            this.btnRemoverProdLista.Location = new System.Drawing.Point(245, 260);
            this.btnRemoverProdLista.Name = "btnRemoverProdLista";
            this.btnRemoverProdLista.Size = new System.Drawing.Size(56, 40);
            this.btnRemoverProdLista.TabIndex = 383;
            this.btnRemoverProdLista.UseVisualStyleBackColor = false;
            this.btnRemoverProdLista.Visible = false;
            this.btnRemoverProdLista.Click += new System.EventHandler(this.btnRemoverProdLista_Click);
            // 
            // btnAddProdutos
            // 
            this.btnAddProdutos.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProdutos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddProdutos.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProdutos.Image")));
            this.btnAddProdutos.Location = new System.Drawing.Point(183, 260);
            this.btnAddProdutos.Name = "btnAddProdutos";
            this.btnAddProdutos.Size = new System.Drawing.Size(56, 40);
            this.btnAddProdutos.TabIndex = 381;
            this.btnAddProdutos.UseVisualStyleBackColor = false;
            // 
            // pbValor
            // 
            this.pbValor.Image = ((System.Drawing.Image)(resources.GetObject("pbValor.Image")));
            this.pbValor.Location = new System.Drawing.Point(448, 259);
            this.pbValor.Name = "pbValor";
            this.pbValor.Size = new System.Drawing.Size(56, 37);
            this.pbValor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbValor.TabIndex = 376;
            this.pbValor.TabStop = false;
            // 
            // pbProduto
            // 
            this.pbProduto.Image = ((System.Drawing.Image)(resources.GetObject("pbProduto.Image")));
            this.pbProduto.Location = new System.Drawing.Point(12, 260);
            this.pbProduto.Name = "pbProduto";
            this.pbProduto.Size = new System.Drawing.Size(56, 37);
            this.pbProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProduto.TabIndex = 361;
            this.pbProduto.TabStop = false;
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
            // btnAlterarPedidos
            // 
            this.btnAlterarPedidos.BackColor = System.Drawing.Color.Yellow;
            this.btnAlterarPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarPedidos.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnAlterarPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarPedidos.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F);
            this.btnAlterarPedidos.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarPedidos.Image")));
            this.btnAlterarPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarPedidos.Location = new System.Drawing.Point(448, 361);
            this.btnAlterarPedidos.Name = "btnAlterarPedidos";
            this.btnAlterarPedidos.Size = new System.Drawing.Size(281, 137);
            this.btnAlterarPedidos.TabIndex = 370;
            this.btnAlterarPedidos.Text = " ALTERAR";
            this.btnAlterarPedidos.UseVisualStyleBackColor = false;
            this.btnAlterarPedidos.Click += new System.EventHandler(this.btnAlterarEntradaEstoque_Click);
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
            // frmGerenciarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1449, 650);
            this.Controls.Add(this.txtFunc);
            this.Controls.Add(this.txtCli);
            this.Controls.Add(this.txtPagto);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscarPagto);
            this.Controls.Add(this.btnAtualizarHora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarFunc);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.gvExibirPedidos);
            this.Controls.Add(this.btnOKPesquisa);
            this.Controls.Add(this.lblAte);
            this.Controls.Add(this.dtpPesqTermino);
            this.Controls.Add(this.pbPesquisarPorPeriodo);
            this.Controls.Add(this.lblPesquisarPorPeriodo);
            this.Controls.Add(this.dtpPesqInicio);
            this.Controls.Add(this.btnExcluirPedidos);
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
            this.Controls.Add(this.btnAlterarPedidos);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.pbData);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.pbID);
            this.Controls.Add(this.lblProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGerenciarPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGerenciarPedidos";
            this.Load += new System.EventHandler(this.frmGerenciarPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirProdutos)).EndInit();
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPesquisarPorPeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView gvExibirPedidos;
        private System.Windows.Forms.Button btnOKPesquisa;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.DateTimePicker dtpPesqTermino;
        private System.Windows.Forms.PictureBox pbPesquisarPorPeriodo;
        private System.Windows.Forms.Label lblPesquisarPorPeriodo;
        private System.Windows.Forms.DateTimePicker dtpPesqInicio;
        private System.Windows.Forms.Button btnExcluirPedidos;
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
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox pbValor;
        private System.Windows.Forms.PictureBox pbProduto;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.PictureBox pbHora;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnAlterarPedidos;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.PictureBox pbData;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.PictureBox pbID;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnBuscarFunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAtualizarHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarPagto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtPagto;
        private System.Windows.Forms.TextBox txtCli;
        private System.Windows.Forms.TextBox txtFunc;
    }
}