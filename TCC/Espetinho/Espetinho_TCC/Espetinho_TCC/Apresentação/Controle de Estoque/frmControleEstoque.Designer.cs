namespace Espetinho_TCC.Apresentação
{
    partial class frmControleEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControleEstoque));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlDireita = new System.Windows.Forms.Panel();
            this.pnlRodapé = new System.Windows.Forms.Panel();
            this.pnlEsquerda = new System.Windows.Forms.Panel();
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.pbUsuarioAtivo = new System.Windows.Forms.PictureBox();
            this.lblNomeUsuAtivo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.gvExibirProdutos = new System.Windows.Forms.DataGridView();
            this.grpPesquisarProd = new System.Windows.Forms.GroupBox();
            this.pbEstoque = new System.Windows.Forms.PictureBox();
            this.pbProduto = new System.Windows.Forms.PictureBox();
            this.pbID = new System.Windows.Forms.PictureBox();
            this.cmbPesqPorEstoque = new System.Windows.Forms.ComboBox();
            this.btnPesqEstoque = new System.Windows.Forms.Button();
            this.lblQtdEstoque = new System.Windows.Forms.Label();
            this.btnPesquisarPorNome = new System.Windows.Forms.Button();
            this.btnPesquisarPorID = new System.Windows.Forms.Button();
            this.txtNomeProd = new System.Windows.Forms.TextBox();
            this.lblNomeProd = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnEntradas = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnSaidas = new System.Windows.Forms.Button();
            this.pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarioAtivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirProdutos)).BeginInit();
            this.grpPesquisarProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbID)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDireita
            // 
            this.pnlDireita.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlDireita.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDireita.Location = new System.Drawing.Point(1194, 50);
            this.pnlDireita.Name = "pnlDireita";
            this.pnlDireita.Size = new System.Drawing.Size(10, 766);
            this.pnlDireita.TabIndex = 196;
            // 
            // pnlRodapé
            // 
            this.pnlRodapé.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlRodapé.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodapé.Location = new System.Drawing.Point(10, 816);
            this.pnlRodapé.Name = "pnlRodapé";
            this.pnlRodapé.Size = new System.Drawing.Size(1194, 10);
            this.pnlRodapé.TabIndex = 195;
            // 
            // pnlEsquerda
            // 
            this.pnlEsquerda.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlEsquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEsquerda.Location = new System.Drawing.Point(0, 50);
            this.pnlEsquerda.Name = "pnlEsquerda";
            this.pnlEsquerda.Size = new System.Drawing.Size(10, 776);
            this.pnlEsquerda.TabIndex = 194;
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlCabecalho.Controls.Add(this.pbUsuarioAtivo);
            this.pnlCabecalho.Controls.Add(this.lblNomeUsuAtivo);
            this.pnlCabecalho.Controls.Add(this.lblTitulo);
            this.pnlCabecalho.Controls.Add(this.btnMenu);
            this.pnlCabecalho.Controls.Add(this.btnFechar);
            this.pnlCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new System.Drawing.Size(1204, 50);
            this.pnlCabecalho.TabIndex = 193;
            // 
            // pbUsuarioAtivo
            // 
            this.pbUsuarioAtivo.Image = ((System.Drawing.Image)(resources.GetObject("pbUsuarioAtivo.Image")));
            this.pbUsuarioAtivo.Location = new System.Drawing.Point(1013, 5);
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
            this.lblNomeUsuAtivo.Location = new System.Drawing.Point(1061, 10);
            this.lblNomeUsuAtivo.Name = "lblNomeUsuAtivo";
            this.lblNomeUsuAtivo.Size = new System.Drawing.Size(0, 30);
            this.lblNomeUsuAtivo.TabIndex = 13;
            this.lblNomeUsuAtivo.Visible = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(376, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(369, 45);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "CONTROLE DE ESTOQUE";
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
            this.btnMenu.Size = new System.Drawing.Size(47, 50);
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
            this.btnFechar.Location = new System.Drawing.Point(1157, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(47, 50);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // gvExibirProdutos
            // 
            this.gvExibirProdutos.AllowUserToAddRows = false;
            this.gvExibirProdutos.AllowUserToDeleteRows = false;
            this.gvExibirProdutos.AllowUserToOrderColumns = true;
            this.gvExibirProdutos.AllowUserToResizeColumns = false;
            this.gvExibirProdutos.AllowUserToResizeRows = false;
            this.gvExibirProdutos.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.gvExibirProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gvExibirProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvExibirProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvExibirProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvExibirProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvExibirProdutos.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvExibirProdutos.Location = new System.Drawing.Point(16, 290);
            this.gvExibirProdutos.MultiSelect = false;
            this.gvExibirProdutos.Name = "gvExibirProdutos";
            this.gvExibirProdutos.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gvExibirProdutos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gvExibirProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvExibirProdutos.Size = new System.Drawing.Size(1165, 520);
            this.gvExibirProdutos.TabIndex = 197;
            this.gvExibirProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvExibirProdutos_CellDoubleClick);
            this.gvExibirProdutos.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvExibirProdutos_ColumnHeaderMouseClick);
            // 
            // grpPesquisarProd
            // 
            this.grpPesquisarProd.Controls.Add(this.pbEstoque);
            this.grpPesquisarProd.Controls.Add(this.pbProduto);
            this.grpPesquisarProd.Controls.Add(this.pbID);
            this.grpPesquisarProd.Controls.Add(this.cmbPesqPorEstoque);
            this.grpPesquisarProd.Controls.Add(this.btnPesqEstoque);
            this.grpPesquisarProd.Controls.Add(this.lblQtdEstoque);
            this.grpPesquisarProd.Controls.Add(this.btnPesquisarPorNome);
            this.grpPesquisarProd.Controls.Add(this.btnPesquisarPorID);
            this.grpPesquisarProd.Controls.Add(this.txtNomeProd);
            this.grpPesquisarProd.Controls.Add(this.lblNomeProd);
            this.grpPesquisarProd.Controls.Add(this.txtID);
            this.grpPesquisarProd.Controls.Add(this.lblID);
            this.grpPesquisarProd.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPesquisarProd.Location = new System.Drawing.Point(16, 168);
            this.grpPesquisarProd.Name = "grpPesquisarProd";
            this.grpPesquisarProd.Size = new System.Drawing.Size(1165, 116);
            this.grpPesquisarProd.TabIndex = 202;
            this.grpPesquisarProd.TabStop = false;
            // 
            // pbEstoque
            // 
            this.pbEstoque.Image = ((System.Drawing.Image)(resources.GetObject("pbEstoque.Image")));
            this.pbEstoque.Location = new System.Drawing.Point(784, 17);
            this.pbEstoque.Name = "pbEstoque";
            this.pbEstoque.Size = new System.Drawing.Size(56, 37);
            this.pbEstoque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEstoque.TabIndex = 232;
            this.pbEstoque.TabStop = false;
            // 
            // pbProduto
            // 
            this.pbProduto.Image = ((System.Drawing.Image)(resources.GetObject("pbProduto.Image")));
            this.pbProduto.Location = new System.Drawing.Point(237, 18);
            this.pbProduto.Name = "pbProduto";
            this.pbProduto.Size = new System.Drawing.Size(56, 37);
            this.pbProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProduto.TabIndex = 231;
            this.pbProduto.TabStop = false;
            // 
            // pbID
            // 
            this.pbID.Image = ((System.Drawing.Image)(resources.GetObject("pbID.Image")));
            this.pbID.Location = new System.Drawing.Point(6, 20);
            this.pbID.Name = "pbID";
            this.pbID.Size = new System.Drawing.Size(56, 37);
            this.pbID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbID.TabIndex = 230;
            this.pbID.TabStop = false;
            // 
            // cmbPesqPorEstoque
            // 
            this.cmbPesqPorEstoque.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPesqPorEstoque.FormattingEnabled = true;
            this.cmbPesqPorEstoque.Items.AddRange(new object[] {
            "10 OU MENOS",
            "ENTRE 10 E 50",
            "ENTRE 50 E 100",
            "100 OU MAIS"});
            this.cmbPesqPorEstoque.Location = new System.Drawing.Point(784, 60);
            this.cmbPesqPorEstoque.Name = "cmbPesqPorEstoque";
            this.cmbPesqPorEstoque.Size = new System.Drawing.Size(321, 38);
            this.cmbPesqPorEstoque.TabIndex = 204;
            this.cmbPesqPorEstoque.SelectedIndexChanged += new System.EventHandler(this.cmbPesqPorEstoque_SelectedIndexChanged);
            // 
            // btnPesqEstoque
            // 
            this.btnPesqEstoque.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPesqEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesqEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqEstoque.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnPesqEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnPesqEstoque.Image")));
            this.btnPesqEstoque.Location = new System.Drawing.Point(1105, 60);
            this.btnPesqEstoque.Name = "btnPesqEstoque";
            this.btnPesqEstoque.Size = new System.Drawing.Size(54, 38);
            this.btnPesqEstoque.TabIndex = 8;
            this.btnPesqEstoque.UseVisualStyleBackColor = false;
            this.btnPesqEstoque.Click += new System.EventHandler(this.btnPesqEstoque_Click);
            // 
            // lblQtdEstoque
            // 
            this.lblQtdEstoque.AutoSize = true;
            this.lblQtdEstoque.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdEstoque.Location = new System.Drawing.Point(846, 23);
            this.lblQtdEstoque.Name = "lblQtdEstoque";
            this.lblQtdEstoque.Size = new System.Drawing.Size(105, 32);
            this.lblQtdEstoque.TabIndex = 6;
            this.lblQtdEstoque.Text = "Estoque:";
            // 
            // btnPesquisarPorNome
            // 
            this.btnPesquisarPorNome.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPesquisarPorNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarPorNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarPorNome.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnPesquisarPorNome.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarPorNome.Image")));
            this.btnPesquisarPorNome.Location = new System.Drawing.Point(724, 60);
            this.btnPesquisarPorNome.Name = "btnPesquisarPorNome";
            this.btnPesquisarPorNome.Size = new System.Drawing.Size(54, 39);
            this.btnPesquisarPorNome.TabIndex = 5;
            this.btnPesquisarPorNome.UseVisualStyleBackColor = false;
            this.btnPesquisarPorNome.Click += new System.EventHandler(this.btnPesquisarPorNome_Click);
            // 
            // btnPesquisarPorID
            // 
            this.btnPesquisarPorID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarPorID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarPorID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnPesquisarPorID.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarPorID.Image")));
            this.btnPesquisarPorID.Location = new System.Drawing.Point(177, 60);
            this.btnPesquisarPorID.Name = "btnPesquisarPorID";
            this.btnPesquisarPorID.Size = new System.Drawing.Size(54, 39);
            this.btnPesquisarPorID.TabIndex = 4;
            this.btnPesquisarPorID.UseVisualStyleBackColor = false;
            this.btnPesquisarPorID.Click += new System.EventHandler(this.btnPesquisarPorID_Click);
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProd.Location = new System.Drawing.Point(237, 60);
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.Size = new System.Drawing.Size(487, 39);
            this.txtNomeProd.TabIndex = 3;
            this.txtNomeProd.TextChanged += new System.EventHandler(this.txtNomeProd_TextChanged);
            // 
            // lblNomeProd
            // 
            this.lblNomeProd.AutoSize = true;
            this.lblNomeProd.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProd.Location = new System.Drawing.Point(294, 23);
            this.lblNomeProd.Name = "lblNomeProd";
            this.lblNomeProd.Size = new System.Drawing.Size(105, 32);
            this.lblNomeProd.TabIndex = 2;
            this.lblNomeProd.Text = "Produto:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(6, 60);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(171, 39);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(62, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(43, 32);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // btnEntradas
            // 
            this.btnEntradas.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnEntradas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntradas.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntradas.Image = ((System.Drawing.Image)(resources.GetObject("btnEntradas.Image")));
            this.btnEntradas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEntradas.Location = new System.Drawing.Point(16, 56);
            this.btnEntradas.Name = "btnEntradas";
            this.btnEntradas.Size = new System.Drawing.Size(265, 111);
            this.btnEntradas.TabIndex = 201;
            this.btnEntradas.Text = "Entradas";
            this.btnEntradas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEntradas.UseVisualStyleBackColor = false;
            this.btnEntradas.Click += new System.EventHandler(this.btnEntradas_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Tomato;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(916, 56);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(265, 111);
            this.btnLimpar.TabIndex = 200;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.BackColor = System.Drawing.Color.Turquoise;
            this.btnMostrarTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTodos.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnMostrarTodos.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarTodos.Image")));
            this.btnMostrarTodos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMostrarTodos.Location = new System.Drawing.Point(616, 56);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(265, 111);
            this.btnMostrarTodos.TabIndex = 198;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMostrarTodos.UseVisualStyleBackColor = false;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnSaidas
            // 
            this.btnSaidas.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnSaidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaidas.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaidas.Image = ((System.Drawing.Image)(resources.GetObject("btnSaidas.Image")));
            this.btnSaidas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaidas.Location = new System.Drawing.Point(316, 56);
            this.btnSaidas.Name = "btnSaidas";
            this.btnSaidas.Size = new System.Drawing.Size(265, 111);
            this.btnSaidas.TabIndex = 206;
            this.btnSaidas.Text = "Saídas";
            this.btnSaidas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaidas.UseVisualStyleBackColor = false;
            this.btnSaidas.Click += new System.EventHandler(this.btnSaidas_Click);
            // 
            // frmControleEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1204, 826);
            this.Controls.Add(this.btnSaidas);
            this.Controls.Add(this.btnEntradas);
            this.Controls.Add(this.gvExibirProdutos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.pnlDireita);
            this.Controls.Add(this.pnlRodapé);
            this.Controls.Add(this.pnlEsquerda);
            this.Controls.Add(this.pnlCabecalho);
            this.Controls.Add(this.grpPesquisarProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmControleEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmControleEstoque";
            this.Load += new System.EventHandler(this.frmControleEstoque_Load);
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarioAtivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirProdutos)).EndInit();
            this.grpPesquisarProd.ResumeLayout(false);
            this.grpPesquisarProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDireita;
        private System.Windows.Forms.Panel pnlRodapé;
        private System.Windows.Forms.Panel pnlEsquerda;
        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnEntradas;
        private System.Windows.Forms.GroupBox grpPesquisarProd;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtNomeProd;
        private System.Windows.Forms.Label lblNomeProd;
        private System.Windows.Forms.Button btnPesquisarPorID;
        private System.Windows.Forms.Button btnPesquisarPorNome;
        private System.Windows.Forms.Label lblQtdEstoque;
        private System.Windows.Forms.Button btnPesqEstoque;
        private System.Windows.Forms.ComboBox cmbPesqPorEstoque;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNomeUsuAtivo;
        private System.Windows.Forms.Button btnSaidas;
        private System.Windows.Forms.PictureBox pbUsuarioAtivo;
        private System.Windows.Forms.PictureBox pbID;
        private System.Windows.Forms.PictureBox pbProduto;
        private System.Windows.Forms.PictureBox pbEstoque;
        public System.Windows.Forms.DataGridView gvExibirProdutos;
    }
}