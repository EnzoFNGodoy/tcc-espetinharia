namespace Espetinho_TCC.Apresentação.Finanças
{
    partial class frmGerenciarSaidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarSaidas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbObs = new System.Windows.Forms.PictureBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.pbValor = new System.Windows.Forms.PictureBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.pbMes = new System.Windows.Forms.PictureBox();
            this.lblMes = new System.Windows.Forms.Label();
            this.pbAno = new System.Windows.Forms.PictureBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.cmbAno = new System.Windows.Forms.ComboBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gvExibirSaidas = new System.Windows.Forms.DataGridView();
            this.pnlDireita = new System.Windows.Forms.Panel();
            this.pnlRodapé = new System.Windows.Forms.Panel();
            this.pnlEsquerda = new System.Windows.Forms.Panel();
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.pbUsuarioAtivo = new System.Windows.Forms.PictureBox();
            this.lblNomeUsuAtivo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pbTipo = new System.Windows.Forms.PictureBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.pbID = new System.Windows.Forms.PictureBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.pbData = new System.Windows.Forms.PictureBox();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbObs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirSaidas)).BeginInit();
            this.pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarioAtivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbData)).BeginInit();
            this.SuspendLayout();
            // 
            // pbObs
            // 
            this.pbObs.Image = ((System.Drawing.Image)(resources.GetObject("pbObs.Image")));
            this.pbObs.Location = new System.Drawing.Point(13, 240);
            this.pbObs.Name = "pbObs";
            this.pbObs.Size = new System.Drawing.Size(56, 37);
            this.pbObs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbObs.TabIndex = 416;
            this.pbObs.TabStop = false;
            // 
            // txtObs
            // 
            this.txtObs.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtObs.Location = new System.Drawing.Point(13, 283);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(520, 185);
            this.txtObs.TabIndex = 415;
            this.txtObs.TextChanged += new System.EventHandler(this.txtObs_TextChanged);
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.Location = new System.Drawing.Point(70, 245);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(144, 32);
            this.lblObs.TabIndex = 414;
            this.lblObs.Text = "Observação:";
            // 
            // pbValor
            // 
            this.pbValor.Image = ((System.Drawing.Image)(resources.GetObject("pbValor.Image")));
            this.pbValor.Location = new System.Drawing.Point(275, 142);
            this.pbValor.Name = "pbValor";
            this.pbValor.Size = new System.Drawing.Size(56, 37);
            this.pbValor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbValor.TabIndex = 410;
            this.pbValor.TabStop = false;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtValor.Location = new System.Drawing.Point(275, 185);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(259, 39);
            this.txtValor.TabIndex = 409;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(334, 147);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(79, 32);
            this.lblValor.TabIndex = 408;
            this.lblValor.Text = "Preço:";
            // 
            // pbMes
            // 
            this.pbMes.Image = ((System.Drawing.Image)(resources.GetObject("pbMes.Image")));
            this.pbMes.Location = new System.Drawing.Point(806, 50);
            this.pbMes.Name = "pbMes";
            this.pbMes.Size = new System.Drawing.Size(56, 37);
            this.pbMes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMes.TabIndex = 405;
            this.pbMes.TabStop = false;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(863, 53);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(65, 32);
            this.lblMes.TabIndex = 404;
            this.lblMes.Text = "Mês:";
            // 
            // pbAno
            // 
            this.pbAno.Image = ((System.Drawing.Image)(resources.GetObject("pbAno.Image")));
            this.pbAno.Location = new System.Drawing.Point(539, 50);
            this.pbAno.Name = "pbAno";
            this.pbAno.Size = new System.Drawing.Size(56, 37);
            this.pbAno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAno.TabIndex = 403;
            this.pbAno.TabStop = false;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(596, 53);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(63, 32);
            this.lblAno.TabIndex = 402;
            this.lblAno.Text = "Ano:";
            // 
            // cmbMes
            // 
            this.cmbMes.Enabled = false;
            this.cmbMes.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cmbMes.Location = new System.Drawing.Point(806, 91);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(328, 40);
            this.cmbMes.TabIndex = 407;
            this.cmbMes.SelectedIndexChanged += new System.EventHandler(this.cmbMes_SelectedIndexChanged);
            // 
            // cmbAno
            // 
            this.cmbAno.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.cmbAno.FormattingEnabled = true;
            this.cmbAno.Location = new System.Drawing.Point(539, 91);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(261, 40);
            this.cmbAno.TabIndex = 406;
            this.cmbAno.SelectedIndexChanged += new System.EventHandler(this.cmbAno_SelectedIndexChanged);
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
            this.btnAlterar.Location = new System.Drawing.Point(275, 481);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(258, 80);
            this.btnAlterar.TabIndex = 396;
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
            this.btnExcluir.Location = new System.Drawing.Point(275, 568);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(258, 80);
            this.btnExcluir.TabIndex = 397;
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
            this.btnCancelar.Location = new System.Drawing.Point(275, 481);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(258, 166);
            this.btnCancelar.TabIndex = 400;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gvExibirSaidas
            // 
            this.gvExibirSaidas.AllowUserToAddRows = false;
            this.gvExibirSaidas.AllowUserToDeleteRows = false;
            this.gvExibirSaidas.AllowUserToOrderColumns = true;
            this.gvExibirSaidas.AllowUserToResizeColumns = false;
            this.gvExibirSaidas.AllowUserToResizeRows = false;
            this.gvExibirSaidas.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.gvExibirSaidas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gvExibirSaidas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvExibirSaidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvExibirSaidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvExibirSaidas.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvExibirSaidas.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvExibirSaidas.Location = new System.Drawing.Point(539, 137);
            this.gvExibirSaidas.MultiSelect = false;
            this.gvExibirSaidas.Name = "gvExibirSaidas";
            this.gvExibirSaidas.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gvExibirSaidas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gvExibirSaidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvExibirSaidas.Size = new System.Drawing.Size(596, 511);
            this.gvExibirSaidas.TabIndex = 395;
            this.gvExibirSaidas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvExibirSaidas_CellContentClick);
            this.gvExibirSaidas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvExibirSaidas_CellDoubleClick);
            this.gvExibirSaidas.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvExibirSaidas_ColumnHeaderMouseClick);
            this.gvExibirSaidas.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvExibirSaidas_ColumnHeaderMouseDoubleClick);
            // 
            // pnlDireita
            // 
            this.pnlDireita.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlDireita.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDireita.Location = new System.Drawing.Point(1141, 45);
            this.pnlDireita.Name = "pnlDireita";
            this.pnlDireita.Size = new System.Drawing.Size(5, 609);
            this.pnlDireita.TabIndex = 394;
            // 
            // pnlRodapé
            // 
            this.pnlRodapé.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlRodapé.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodapé.Location = new System.Drawing.Point(5, 654);
            this.pnlRodapé.Name = "pnlRodapé";
            this.pnlRodapé.Size = new System.Drawing.Size(1141, 5);
            this.pnlRodapé.TabIndex = 393;
            // 
            // pnlEsquerda
            // 
            this.pnlEsquerda.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlEsquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEsquerda.Location = new System.Drawing.Point(0, 45);
            this.pnlEsquerda.Name = "pnlEsquerda";
            this.pnlEsquerda.Size = new System.Drawing.Size(5, 614);
            this.pnlEsquerda.TabIndex = 392;
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
            this.pnlCabecalho.TabIndex = 391;
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
            this.lblTitulo.Size = new System.Drawing.Size(301, 45);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "GERENCIAR SAÍDAS";
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
            // pbTipo
            // 
            this.pbTipo.Image = ((System.Drawing.Image)(resources.GetObject("pbTipo.Image")));
            this.pbTipo.Location = new System.Drawing.Point(132, 51);
            this.pbTipo.Name = "pbTipo";
            this.pbTipo.Size = new System.Drawing.Size(56, 37);
            this.pbTipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTipo.TabIndex = 390;
            this.pbTipo.TabStop = false;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(191, 55);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(67, 32);
            this.lblTipo.TabIndex = 389;
            this.lblTipo.Text = "Tipo:";
            // 
            // pbID
            // 
            this.pbID.Image = ((System.Drawing.Image)(resources.GetObject("pbID.Image")));
            this.pbID.Location = new System.Drawing.Point(11, 51);
            this.pbID.Name = "pbID";
            this.pbID.Size = new System.Drawing.Size(56, 37);
            this.pbID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbID.TabIndex = 388;
            this.pbID.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtID.Location = new System.Drawing.Point(11, 91);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(115, 39);
            this.txtID.TabIndex = 387;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(67, 56);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(43, 32);
            this.lblID.TabIndex = 386;
            this.lblID.Text = "ID:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "SAIDA"});
            this.cmbTipo.Location = new System.Drawing.Point(132, 91);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(401, 40);
            this.cmbTipo.TabIndex = 401;
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
            this.btnCadastrar.Location = new System.Drawing.Point(10, 481);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(258, 166);
            this.btnCadastrar.TabIndex = 398;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dtpData
            // 
            this.dtpData.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(13, 185);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(258, 39);
            this.dtpData.TabIndex = 413;
            this.dtpData.ValueChanged += new System.EventHandler(this.dtpData_ValueChanged);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(71, 150);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(69, 32);
            this.lblData.TabIndex = 411;
            this.lblData.Text = "Data:";
            // 
            // pbData
            // 
            this.pbData.Image = ((System.Drawing.Image)(resources.GetObject("pbData.Image")));
            this.pbData.Location = new System.Drawing.Point(12, 145);
            this.pbData.Name = "pbData";
            this.pbData.Size = new System.Drawing.Size(56, 37);
            this.pbData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbData.TabIndex = 412;
            this.pbData.TabStop = false;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.Location = new System.Drawing.Point(10, 481);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(258, 166);
            this.btnNovo.TabIndex = 399;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmGerenciarSaidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1146, 659);
            this.Controls.Add(this.pbObs);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.pbValor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.pbMes);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.pbAno);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.cmbAno);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gvExibirSaidas);
            this.Controls.Add(this.pnlDireita);
            this.Controls.Add(this.pnlRodapé);
            this.Controls.Add(this.pnlEsquerda);
            this.Controls.Add(this.pnlCabecalho);
            this.Controls.Add(this.pbTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.pbID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.pbData);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGerenciarSaidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGerenciarSaidas";
            this.Load += new System.EventHandler(this.frmGerenciarSaidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbObs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirSaidas)).EndInit();
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarioAtivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbObs;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.PictureBox pbValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.PictureBox pbMes;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.PictureBox pbAno;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.ComboBox cmbAno;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.DataGridView gvExibirSaidas;
        private System.Windows.Forms.Panel pnlDireita;
        private System.Windows.Forms.Panel pnlRodapé;
        private System.Windows.Forms.Panel pnlEsquerda;
        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.PictureBox pbUsuarioAtivo;
        private System.Windows.Forms.Label lblNomeUsuAtivo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox pbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.PictureBox pbID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.PictureBox pbData;
        private System.Windows.Forms.Button btnNovo;
    }
}