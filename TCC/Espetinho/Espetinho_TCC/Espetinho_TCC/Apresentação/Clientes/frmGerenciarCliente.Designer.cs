namespace Espetinho_TCC.Apresentação.Clientes
{
    partial class frmGerenciarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarCliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.lblNomeProd = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.pbNome = new System.Windows.Forms.PictureBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.pbID = new System.Windows.Forms.PictureBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.pnlDireita = new System.Windows.Forms.Panel();
            this.pnlRodapé = new System.Windows.Forms.Panel();
            this.pnlEsquerda = new System.Windows.Forms.Panel();
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.pbUsuarioAtivo = new System.Windows.Forms.PictureBox();
            this.lblNomeUsuAtivo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pbEmail = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.gvExibirClientes = new System.Windows.Forms.DataGridView();
            this.pbPesquisaPorNome = new System.Windows.Forms.PictureBox();
            this.txtPesquisarPorNome = new System.Windows.Forms.TextBox();
            this.lblPesquisarPorNome = new System.Windows.Forms.Label();
            this.pbCPF = new System.Windows.Forms.PictureBox();
            this.pbCNPJ = new System.Windows.Forms.PictureBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.pbTelefone = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbID)).BeginInit();
            this.pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarioAtivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPesquisaPorNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCPF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCNPJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTelefone)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtCNPJ.Location = new System.Drawing.Point(10, 288);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(523, 39);
            this.txtCNPJ.TabIndex = 283;
            this.txtCNPJ.Enter += new System.EventHandler(this.txtCNPJ_Enter);
            // 
            // lblNomeProd
            // 
            this.lblNomeProd.AutoSize = true;
            this.lblNomeProd.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProd.Location = new System.Drawing.Point(67, 251);
            this.lblNomeProd.Name = "lblNomeProd";
            this.lblNomeProd.Size = new System.Drawing.Size(73, 32);
            this.lblNomeProd.TabIndex = 282;
            this.lblNomeProd.Text = "CNPJ:";
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtCPF.Location = new System.Drawing.Point(11, 185);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(522, 39);
            this.txtCPF.TabIndex = 280;
            this.txtCPF.Enter += new System.EventHandler(this.txtCPF_Enter);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(70, 150);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(60, 32);
            this.lblCPF.TabIndex = 279;
            this.lblCPF.Text = "CPF:";
            // 
            // pbNome
            // 
            this.pbNome.Image = ((System.Drawing.Image)(resources.GetObject("pbNome.Image")));
            this.pbNome.Location = new System.Drawing.Point(132, 51);
            this.pbNome.Name = "pbNome";
            this.pbNome.Size = new System.Drawing.Size(56, 37);
            this.pbNome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNome.TabIndex = 278;
            this.pbNome.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtNome.Location = new System.Drawing.Point(132, 91);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(401, 39);
            this.txtNome.TabIndex = 277;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(191, 56);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(86, 32);
            this.lblNome.TabIndex = 276;
            this.lblNome.Text = "Nome:";
            // 
            // pbID
            // 
            this.pbID.Image = ((System.Drawing.Image)(resources.GetObject("pbID.Image")));
            this.pbID.Location = new System.Drawing.Point(11, 51);
            this.pbID.Name = "pbID";
            this.pbID.Size = new System.Drawing.Size(56, 37);
            this.pbID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbID.TabIndex = 275;
            this.pbID.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtID.Location = new System.Drawing.Point(11, 91);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(115, 39);
            this.txtID.TabIndex = 274;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(67, 56);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(43, 32);
            this.lblID.TabIndex = 273;
            this.lblID.Text = "ID:";
            // 
            // pnlDireita
            // 
            this.pnlDireita.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlDireita.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDireita.Location = new System.Drawing.Point(1141, 45);
            this.pnlDireita.Name = "pnlDireita";
            this.pnlDireita.Size = new System.Drawing.Size(5, 670);
            this.pnlDireita.TabIndex = 288;
            // 
            // pnlRodapé
            // 
            this.pnlRodapé.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlRodapé.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodapé.Location = new System.Drawing.Point(5, 715);
            this.pnlRodapé.Name = "pnlRodapé";
            this.pnlRodapé.Size = new System.Drawing.Size(1141, 5);
            this.pnlRodapé.TabIndex = 287;
            // 
            // pnlEsquerda
            // 
            this.pnlEsquerda.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlEsquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEsquerda.Location = new System.Drawing.Point(0, 45);
            this.pnlEsquerda.Name = "pnlEsquerda";
            this.pnlEsquerda.Size = new System.Drawing.Size(5, 675);
            this.pnlEsquerda.TabIndex = 286;
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
            this.pnlCabecalho.Size = new System.Drawing.Size(1146, 45);
            this.pnlCabecalho.TabIndex = 285;
            // 
            // pbUsuarioAtivo
            // 
            this.pbUsuarioAtivo.Image = ((System.Drawing.Image)(resources.GetObject("pbUsuarioAtivo.Image")));
            this.pbUsuarioAtivo.Location = new System.Drawing.Point(1538, 2);
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
            this.lblNomeUsuAtivo.Location = new System.Drawing.Point(1586, 7);
            this.lblNomeUsuAtivo.Name = "lblNomeUsuAtivo";
            this.lblNomeUsuAtivo.Size = new System.Drawing.Size(0, 30);
            this.lblNomeUsuAtivo.TabIndex = 13;
            this.lblNomeUsuAtivo.Visible = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(409, -1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(312, 45);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "GERENCIAR CLIENTE";
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
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
            this.btnFechar.Location = new System.Drawing.Point(1099, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(47, 46);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pbEmail
            // 
            this.pbEmail.Image = ((System.Drawing.Image)(resources.GetObject("pbEmail.Image")));
            this.pbEmail.Location = new System.Drawing.Point(10, 352);
            this.pbEmail.Name = "pbEmail";
            this.pbEmail.Size = new System.Drawing.Size(56, 37);
            this.pbEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEmail.TabIndex = 291;
            this.pbEmail.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtEmail.Location = new System.Drawing.Point(10, 394);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(523, 39);
            this.txtEmail.TabIndex = 290;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(67, 357);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(77, 32);
            this.lblEmail.TabIndex = 289;
            this.lblEmail.Text = "Email:";
            // 
            // gvExibirClientes
            // 
            this.gvExibirClientes.AllowUserToAddRows = false;
            this.gvExibirClientes.AllowUserToDeleteRows = false;
            this.gvExibirClientes.AllowUserToOrderColumns = true;
            this.gvExibirClientes.AllowUserToResizeColumns = false;
            this.gvExibirClientes.AllowUserToResizeRows = false;
            this.gvExibirClientes.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.gvExibirClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gvExibirClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvExibirClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gvExibirClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvExibirClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvExibirClientes.DefaultCellStyle = dataGridViewCellStyle8;
            this.gvExibirClientes.Location = new System.Drawing.Point(539, 136);
            this.gvExibirClientes.MultiSelect = false;
            this.gvExibirClientes.Name = "gvExibirClientes";
            this.gvExibirClientes.ReadOnly = true;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gvExibirClientes.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.gvExibirClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvExibirClientes.Size = new System.Drawing.Size(596, 573);
            this.gvExibirClientes.TabIndex = 292;
            this.gvExibirClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvExibirClientes_CellClick);
            // 
            // pbPesquisaPorNome
            // 
            this.pbPesquisaPorNome.Image = ((System.Drawing.Image)(resources.GetObject("pbPesquisaPorNome.Image")));
            this.pbPesquisaPorNome.Location = new System.Drawing.Point(539, 51);
            this.pbPesquisaPorNome.Name = "pbPesquisaPorNome";
            this.pbPesquisaPorNome.Size = new System.Drawing.Size(56, 37);
            this.pbPesquisaPorNome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPesquisaPorNome.TabIndex = 295;
            this.pbPesquisaPorNome.TabStop = false;
            // 
            // txtPesquisarPorNome
            // 
            this.txtPesquisarPorNome.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtPesquisarPorNome.Location = new System.Drawing.Point(539, 91);
            this.txtPesquisarPorNome.Name = "txtPesquisarPorNome";
            this.txtPesquisarPorNome.Size = new System.Drawing.Size(595, 39);
            this.txtPesquisarPorNome.TabIndex = 294;
            this.txtPesquisarPorNome.TextChanged += new System.EventHandler(this.txtPesquisarPorNome_TextChanged);
            // 
            // lblPesquisarPorNome
            // 
            this.lblPesquisarPorNome.AutoSize = true;
            this.lblPesquisarPorNome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisarPorNome.Location = new System.Drawing.Point(598, 56);
            this.lblPesquisarPorNome.Name = "lblPesquisarPorNome";
            this.lblPesquisarPorNome.Size = new System.Drawing.Size(235, 32);
            this.lblPesquisarPorNome.TabIndex = 293;
            this.lblPesquisarPorNome.Text = "Pesquisar por Nome:";
            // 
            // pbCPF
            // 
            this.pbCPF.Image = ((System.Drawing.Image)(resources.GetObject("pbCPF.Image")));
            this.pbCPF.Location = new System.Drawing.Point(12, 145);
            this.pbCPF.Name = "pbCPF";
            this.pbCPF.Size = new System.Drawing.Size(56, 37);
            this.pbCPF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCPF.TabIndex = 296;
            this.pbCPF.TabStop = false;
            // 
            // pbCNPJ
            // 
            this.pbCNPJ.Image = ((System.Drawing.Image)(resources.GetObject("pbCNPJ.Image")));
            this.pbCNPJ.Location = new System.Drawing.Point(10, 245);
            this.pbCNPJ.Name = "pbCNPJ";
            this.pbCNPJ.Size = new System.Drawing.Size(56, 37);
            this.pbCNPJ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCNPJ.TabIndex = 303;
            this.pbCNPJ.TabStop = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Yellow;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F);
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(275, 543);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(258, 80);
            this.btnAlterar.TabIndex = 304;
            this.btnAlterar.Text = " ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Tomato;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(275, 630);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(258, 80);
            this.btnExcluir.TabIndex = 305;
            this.btnExcluir.Text = "         EXCLUIR ITEM";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Tomato;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(275, 543);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(258, 166);
            this.btnCancelar.TabIndex = 308;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNovoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoCliente.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnNovoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoCliente.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.btnNovoCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoCliente.Image")));
            this.btnNovoCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovoCliente.Location = new System.Drawing.Point(10, 543);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(258, 166);
            this.btnNovoCliente.TabIndex = 307;
            this.btnNovoCliente.Text = "NOVO";
            this.btnNovoCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovoCliente.UseVisualStyleBackColor = false;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrar.Location = new System.Drawing.Point(10, 543);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(258, 166);
            this.btnCadastrar.TabIndex = 306;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtTelefone.Location = new System.Drawing.Point(10, 498);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(523, 39);
            this.txtTelefone.TabIndex = 310;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(67, 463);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(112, 32);
            this.lblTel.TabIndex = 309;
            this.lblTel.Text = "Telefone:";
            // 
            // pbTelefone
            // 
            this.pbTelefone.Image = ((System.Drawing.Image)(resources.GetObject("pbTelefone.Image")));
            this.pbTelefone.Location = new System.Drawing.Point(10, 458);
            this.pbTelefone.Name = "pbTelefone";
            this.pbTelefone.Size = new System.Drawing.Size(56, 37);
            this.pbTelefone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTelefone.TabIndex = 312;
            this.pbTelefone.TabStop = false;
            // 
            // frmGerenciarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1146, 720);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pbCPF);
            this.Controls.Add(this.pbPesquisaPorNome);
            this.Controls.Add(this.txtPesquisarPorNome);
            this.Controls.Add(this.lblPesquisarPorNome);
            this.Controls.Add(this.gvExibirClientes);
            this.Controls.Add(this.pbEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.pnlDireita);
            this.Controls.Add(this.pnlRodapé);
            this.Controls.Add(this.pnlEsquerda);
            this.Controls.Add(this.pnlCabecalho);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.lblNomeProd);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.pbNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.pbID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.pbCNPJ);
            this.Controls.Add(this.btnNovoCliente);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.pbTelefone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGerenciarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGerenciarCliente";
            this.Load += new System.EventHandler(this.frmGerenciarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbID)).EndInit();
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarioAtivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPesquisaPorNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCPF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCNPJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTelefone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Label lblNomeProd;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.PictureBox pbNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox pbID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel pnlDireita;
        private System.Windows.Forms.Panel pnlRodapé;
        private System.Windows.Forms.Panel pnlEsquerda;
        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.PictureBox pbUsuarioAtivo;
        private System.Windows.Forms.Label lblNomeUsuAtivo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox pbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        public System.Windows.Forms.DataGridView gvExibirClientes;
        private System.Windows.Forms.PictureBox pbPesquisaPorNome;
        private System.Windows.Forms.TextBox txtPesquisarPorNome;
        private System.Windows.Forms.Label lblPesquisarPorNome;
        private System.Windows.Forms.PictureBox pbCPF;
        private System.Windows.Forms.PictureBox pbCNPJ;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.PictureBox pbTelefone;
    }
}