namespace Espetinho_TCC.Apresentação.Fornecedor
{
    partial class frmControleDeFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControleDeFornecedor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gvExibirForn = new System.Windows.Forms.DataGridView();
            this.btnFecharGvVerPedidos = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblCPFCNPJ = new System.Windows.Forms.Label();
            this.txtCpfCnpj = new System.Windows.Forms.TextBox();
            this.btnPesquisarPorID = new System.Windows.Forms.Button();
            this.btnPesqCnpjCpf = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnPesqNome = new System.Windows.Forms.Button();
            this.pbID = new System.Windows.Forms.PictureBox();
            this.pbProduto = new System.Windows.Forms.PictureBox();
            this.pbEstoque = new System.Windows.Forms.PictureBox();
            this.grpPesquisarProd = new System.Windows.Forms.GroupBox();
            this.txtPesqNome = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pbUsuarioAtivo = new System.Windows.Forms.PictureBox();
            this.lblNomeUsuAtivo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnPedidosForn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirForn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstoque)).BeginInit();
            this.grpPesquisarProd.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarioAtivo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.BackColor = System.Drawing.Color.Turquoise;
            this.btnMostrarTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTodos.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnMostrarTodos.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarTodos.Image")));
            this.btnMostrarTodos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMostrarTodos.Location = new System.Drawing.Point(417, 66);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(337, 111);
            this.btnMostrarTodos.TabIndex = 208;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMostrarTodos.UseVisualStyleBackColor = false;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Tomato;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(797, 66);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(337, 111);
            this.btnLimpar.TabIndex = 209;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // gvExibirForn
            // 
            this.gvExibirForn.AllowUserToAddRows = false;
            this.gvExibirForn.AllowUserToDeleteRows = false;
            this.gvExibirForn.AllowUserToOrderColumns = true;
            this.gvExibirForn.AllowUserToResizeColumns = false;
            this.gvExibirForn.AllowUserToResizeRows = false;
            this.gvExibirForn.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.gvExibirForn.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gvExibirForn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvExibirForn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gvExibirForn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvExibirForn.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvExibirForn.DefaultCellStyle = dataGridViewCellStyle11;
            this.gvExibirForn.Location = new System.Drawing.Point(16, 305);
            this.gvExibirForn.MultiSelect = false;
            this.gvExibirForn.Name = "gvExibirForn";
            this.gvExibirForn.ReadOnly = true;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gvExibirForn.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.gvExibirForn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvExibirForn.Size = new System.Drawing.Size(1147, 366);
            this.gvExibirForn.TabIndex = 207;
            this.gvExibirForn.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvExibirForn_CellDoubleClick);
            // 
            // btnFecharGvVerPedidos
            // 
            this.btnFecharGvVerPedidos.BackColor = System.Drawing.Color.White;
            this.btnFecharGvVerPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFecharGvVerPedidos.FlatAppearance.BorderSize = 0;
            this.btnFecharGvVerPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharGvVerPedidos.Image = ((System.Drawing.Image)(resources.GetObject("btnFecharGvVerPedidos.Image")));
            this.btnFecharGvVerPedidos.Location = new System.Drawing.Point(1140, 305);
            this.btnFecharGvVerPedidos.Name = "btnFecharGvVerPedidos";
            this.btnFecharGvVerPedidos.Size = new System.Drawing.Size(20, 20);
            this.btnFecharGvVerPedidos.TabIndex = 212;
            this.btnFecharGvVerPedidos.UseVisualStyleBackColor = false;
            this.btnFecharGvVerPedidos.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(87, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(43, 32);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(29, 66);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(142, 39);
            this.txtID.TabIndex = 1;
            // 
            // lblCPFCNPJ
            // 
            this.lblCPFCNPJ.AutoSize = true;
            this.lblCPFCNPJ.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFCNPJ.Location = new System.Drawing.Point(294, 23);
            this.lblCPFCNPJ.Name = "lblCPFCNPJ";
            this.lblCPFCNPJ.Size = new System.Drawing.Size(161, 32);
            this.lblCPFCNPJ.TabIndex = 2;
            this.lblCPFCNPJ.Text = "CPF OU CNPJ:";
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfCnpj.Location = new System.Drawing.Point(237, 66);
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.Size = new System.Drawing.Size(487, 39);
            this.txtCpfCnpj.TabIndex = 3;
            // 
            // btnPesquisarPorID
            // 
            this.btnPesquisarPorID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarPorID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarPorID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnPesquisarPorID.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarPorID.Image")));
            this.btnPesquisarPorID.Location = new System.Drawing.Point(171, 66);
            this.btnPesquisarPorID.Name = "btnPesquisarPorID";
            this.btnPesquisarPorID.Size = new System.Drawing.Size(54, 39);
            this.btnPesquisarPorID.TabIndex = 4;
            this.btnPesquisarPorID.UseVisualStyleBackColor = false;
            this.btnPesquisarPorID.Click += new System.EventHandler(this.btnPesquisarPorID_Click);
            // 
            // btnPesqCnpjCpf
            // 
            this.btnPesqCnpjCpf.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPesqCnpjCpf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesqCnpjCpf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqCnpjCpf.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnPesqCnpjCpf.Image = ((System.Drawing.Image)(resources.GetObject("btnPesqCnpjCpf.Image")));
            this.btnPesqCnpjCpf.Location = new System.Drawing.Point(724, 66);
            this.btnPesqCnpjCpf.Name = "btnPesqCnpjCpf";
            this.btnPesqCnpjCpf.Size = new System.Drawing.Size(54, 39);
            this.btnPesqCnpjCpf.TabIndex = 5;
            this.btnPesqCnpjCpf.UseVisualStyleBackColor = false;
            this.btnPesqCnpjCpf.Click += new System.EventHandler(this.btnPesqCnpjCpf_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(846, 23);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(90, 32);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "NOME:";
            // 
            // btnPesqNome
            // 
            this.btnPesqNome.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPesqNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesqNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqNome.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnPesqNome.Image = ((System.Drawing.Image)(resources.GetObject("btnPesqNome.Image")));
            this.btnPesqNome.Location = new System.Drawing.Point(1045, 66);
            this.btnPesqNome.Name = "btnPesqNome";
            this.btnPesqNome.Size = new System.Drawing.Size(54, 39);
            this.btnPesqNome.TabIndex = 8;
            this.btnPesqNome.UseVisualStyleBackColor = false;
            this.btnPesqNome.Click += new System.EventHandler(this.btnPesqNome_Click);
            // 
            // pbID
            // 
            this.pbID.Image = ((System.Drawing.Image)(resources.GetObject("pbID.Image")));
            this.pbID.Location = new System.Drawing.Point(29, 20);
            this.pbID.Name = "pbID";
            this.pbID.Size = new System.Drawing.Size(56, 37);
            this.pbID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbID.TabIndex = 230;
            this.pbID.TabStop = false;
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
            // pbEstoque
            // 
            this.pbEstoque.Image = ((System.Drawing.Image)(resources.GetObject("pbEstoque.Image")));
            this.pbEstoque.Location = new System.Drawing.Point(784, 18);
            this.pbEstoque.Name = "pbEstoque";
            this.pbEstoque.Size = new System.Drawing.Size(56, 37);
            this.pbEstoque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEstoque.TabIndex = 232;
            this.pbEstoque.TabStop = false;
            // 
            // grpPesquisarProd
            // 
            this.grpPesquisarProd.Controls.Add(this.txtPesqNome);
            this.grpPesquisarProd.Controls.Add(this.pbEstoque);
            this.grpPesquisarProd.Controls.Add(this.pbProduto);
            this.grpPesquisarProd.Controls.Add(this.pbID);
            this.grpPesquisarProd.Controls.Add(this.btnPesqNome);
            this.grpPesquisarProd.Controls.Add(this.lblNome);
            this.grpPesquisarProd.Controls.Add(this.btnPesqCnpjCpf);
            this.grpPesquisarProd.Controls.Add(this.btnPesquisarPorID);
            this.grpPesquisarProd.Controls.Add(this.txtCpfCnpj);
            this.grpPesquisarProd.Controls.Add(this.lblCPFCNPJ);
            this.grpPesquisarProd.Controls.Add(this.txtID);
            this.grpPesquisarProd.Controls.Add(this.lblID);
            this.grpPesquisarProd.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPesquisarProd.Location = new System.Drawing.Point(16, 183);
            this.grpPesquisarProd.Name = "grpPesquisarProd";
            this.grpPesquisarProd.Size = new System.Drawing.Size(1144, 116);
            this.grpPesquisarProd.TabIndex = 211;
            this.grpPesquisarProd.TabStop = false;
            // 
            // txtPesqNome
            // 
            this.txtPesqNome.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtPesqNome.Location = new System.Drawing.Point(784, 66);
            this.txtPesqNome.Name = "txtPesqNome";
            this.txtPesqNome.Size = new System.Drawing.Size(261, 39);
            this.txtPesqNome.TabIndex = 233;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 647);
            this.panel1.TabIndex = 213;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 687);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1177, 10);
            this.panel2.TabIndex = 214;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1177, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 637);
            this.panel3.TabIndex = 215;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Controls.Add(this.pbUsuarioAtivo);
            this.panel4.Controls.Add(this.lblNomeUsuAtivo);
            this.panel4.Controls.Add(this.lblTitulo);
            this.panel4.Controls.Add(this.btnFechar);
            this.panel4.Controls.Add(this.btnMenu);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1187, 50);
            this.panel4.TabIndex = 216;
            // 
            // pbUsuarioAtivo
            // 
            this.pbUsuarioAtivo.Image = ((System.Drawing.Image)(resources.GetObject("pbUsuarioAtivo.Image")));
            this.pbUsuarioAtivo.Location = new System.Drawing.Point(984, 7);
            this.pbUsuarioAtivo.Name = "pbUsuarioAtivo";
            this.pbUsuarioAtivo.Size = new System.Drawing.Size(42, 40);
            this.pbUsuarioAtivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbUsuarioAtivo.TabIndex = 208;
            this.pbUsuarioAtivo.TabStop = false;
            // 
            // lblNomeUsuAtivo
            // 
            this.lblNomeUsuAtivo.AutoSize = true;
            this.lblNomeUsuAtivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNomeUsuAtivo.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblNomeUsuAtivo.ForeColor = System.Drawing.Color.White;
            this.lblNomeUsuAtivo.Image = ((System.Drawing.Image)(resources.GetObject("lblNomeUsuAtivo.Image")));
            this.lblNomeUsuAtivo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNomeUsuAtivo.Location = new System.Drawing.Point(1062, 11);
            this.lblNomeUsuAtivo.Name = "lblNomeUsuAtivo";
            this.lblNomeUsuAtivo.Size = new System.Drawing.Size(0, 30);
            this.lblNomeUsuAtivo.TabIndex = 207;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(346, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(428, 45);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "GERENCIAR FORNECEDORES";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(1140, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(47, 50);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(10, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(47, 50);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.UseVisualStyleBackColor = false;
            // 
            // btnPedidosForn
            // 
            this.btnPedidosForn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnPedidosForn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedidosForn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidosForn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnPedidosForn.Image = ((System.Drawing.Image)(resources.GetObject("btnPedidosForn.Image")));
            this.btnPedidosForn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPedidosForn.Location = new System.Drawing.Point(34, 66);
            this.btnPedidosForn.Name = "btnPedidosForn";
            this.btnPedidosForn.Size = new System.Drawing.Size(337, 111);
            this.btnPedidosForn.TabIndex = 217;
            this.btnPedidosForn.Text = "Pedidos Fornecedor";
            this.btnPedidosForn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPedidosForn.UseVisualStyleBackColor = false;
            this.btnPedidosForn.Click += new System.EventHandler(this.btnPedidosForn_Click);
            // 
            // frmControleDeFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1187, 697);
            this.Controls.Add(this.btnPedidosForn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFecharGvVerPedidos);
            this.Controls.Add(this.gvExibirForn);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.grpPesquisarProd);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmControleDeFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmControleDeFornecedor";
            this.Load += new System.EventHandler(this.frmControleDeFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirForn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstoque)).EndInit();
            this.grpPesquisarProd.ResumeLayout(false);
            this.grpPesquisarProd.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarioAtivo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnLimpar;
        public System.Windows.Forms.DataGridView gvExibirForn;
        private System.Windows.Forms.Button btnFecharGvVerPedidos;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblCPFCNPJ;
        private System.Windows.Forms.TextBox txtCpfCnpj;
        private System.Windows.Forms.Button btnPesquisarPorID;
        private System.Windows.Forms.Button btnPesqCnpjCpf;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnPesqNome;
        private System.Windows.Forms.PictureBox pbID;
        private System.Windows.Forms.PictureBox pbProduto;
        private System.Windows.Forms.PictureBox pbEstoque;
        private System.Windows.Forms.GroupBox grpPesquisarProd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtPesqNome;
        private System.Windows.Forms.PictureBox pbUsuarioAtivo;
        private System.Windows.Forms.Label lblNomeUsuAtivo;
        private System.Windows.Forms.Button btnPedidosForn;
    }
}