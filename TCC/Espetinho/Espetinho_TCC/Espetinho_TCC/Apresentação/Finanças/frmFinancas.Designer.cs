namespace Espetinho_TCC.Apresentação.Finanças
{
    partial class frmFinancas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinancas));
            this.gvExibirFinancas = new System.Windows.Forms.DataGridView();
            this.pnlDireita = new System.Windows.Forms.Panel();
            this.pnlRodapé = new System.Windows.Forms.Panel();
            this.pnlEsquerda = new System.Windows.Forms.Panel();
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.pbUsuarioAtivo = new System.Windows.Forms.PictureBox();
            this.lblNomeUsuAtivo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblEntradaSaida = new System.Windows.Forms.Label();
            this.grpPesquisarFinanca = new System.Windows.Forms.GroupBox();
            this.pbMes = new System.Windows.Forms.PictureBox();
            this.lblMes = new System.Windows.Forms.Label();
            this.rbTudo = new System.Windows.Forms.RadioButton();
            this.rbSaidas = new System.Windows.Forms.RadioButton();
            this.rbEntradas = new System.Windows.Forms.RadioButton();
            this.pbAno = new System.Windows.Forms.PictureBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.pbEntradaSaida = new System.Windows.Forms.PictureBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.cmbAno = new System.Windows.Forms.ComboBox();
            this.grpEntradas = new System.Windows.Forms.GroupBox();
            this.btnAddEntradas = new System.Windows.Forms.Button();
            this.lblValorEntrada = new System.Windows.Forms.Label();
            this.grpSaidas = new System.Windows.Forms.GroupBox();
            this.btnAddSaidas = new System.Windows.Forms.Button();
            this.lblValorSaida = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpLucro = new System.Windows.Forms.GroupBox();
            this.pbBomRuimLucro = new System.Windows.Forms.PictureBox();
            this.lblValorLucro = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbCaixaTotal = new System.Windows.Forms.PictureBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirFinancas)).BeginInit();
            this.pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarioAtivo)).BeginInit();
            this.grpPesquisarFinanca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEntradaSaida)).BeginInit();
            this.grpEntradas.SuspendLayout();
            this.grpSaidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpLucro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBomRuimLucro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaixaTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // gvExibirFinancas
            // 
            this.gvExibirFinancas.AllowUserToAddRows = false;
            this.gvExibirFinancas.AllowUserToDeleteRows = false;
            this.gvExibirFinancas.AllowUserToOrderColumns = true;
            this.gvExibirFinancas.AllowUserToResizeColumns = false;
            this.gvExibirFinancas.AllowUserToResizeRows = false;
            this.gvExibirFinancas.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.gvExibirFinancas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gvExibirFinancas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvExibirFinancas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvExibirFinancas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvExibirFinancas.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvExibirFinancas.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvExibirFinancas.Location = new System.Drawing.Point(16, 290);
            this.gvExibirFinancas.MultiSelect = false;
            this.gvExibirFinancas.Name = "gvExibirFinancas";
            this.gvExibirFinancas.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gvExibirFinancas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gvExibirFinancas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvExibirFinancas.Size = new System.Drawing.Size(1165, 520);
            this.gvExibirFinancas.TabIndex = 211;
            this.gvExibirFinancas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvExibirFinancas_CellContentClick);
            this.gvExibirFinancas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvExibirFinancas_CellDoubleClick);
            // 
            // pnlDireita
            // 
            this.pnlDireita.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlDireita.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDireita.Location = new System.Drawing.Point(1194, 50);
            this.pnlDireita.Name = "pnlDireita";
            this.pnlDireita.Size = new System.Drawing.Size(10, 766);
            this.pnlDireita.TabIndex = 210;
            // 
            // pnlRodapé
            // 
            this.pnlRodapé.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlRodapé.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodapé.Location = new System.Drawing.Point(10, 816);
            this.pnlRodapé.Name = "pnlRodapé";
            this.pnlRodapé.Size = new System.Drawing.Size(1194, 10);
            this.pnlRodapé.TabIndex = 209;
            // 
            // pnlEsquerda
            // 
            this.pnlEsquerda.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlEsquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEsquerda.Location = new System.Drawing.Point(0, 50);
            this.pnlEsquerda.Name = "pnlEsquerda";
            this.pnlEsquerda.Size = new System.Drawing.Size(10, 776);
            this.pnlEsquerda.TabIndex = 208;
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
            this.pnlCabecalho.TabIndex = 207;
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
            this.lblTitulo.Location = new System.Drawing.Point(489, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(172, 45);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "FINANÇAS";
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
            // lblEntradaSaida
            // 
            this.lblEntradaSaida.AutoSize = true;
            this.lblEntradaSaida.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradaSaida.Location = new System.Drawing.Point(906, 20);
            this.lblEntradaSaida.Name = "lblEntradaSaida";
            this.lblEntradaSaida.Size = new System.Drawing.Size(175, 32);
            this.lblEntradaSaida.TabIndex = 6;
            this.lblEntradaSaida.Text = "Entrada / Saída";
            // 
            // grpPesquisarFinanca
            // 
            this.grpPesquisarFinanca.Controls.Add(this.pbMes);
            this.grpPesquisarFinanca.Controls.Add(this.lblMes);
            this.grpPesquisarFinanca.Controls.Add(this.rbTudo);
            this.grpPesquisarFinanca.Controls.Add(this.rbSaidas);
            this.grpPesquisarFinanca.Controls.Add(this.rbEntradas);
            this.grpPesquisarFinanca.Controls.Add(this.pbAno);
            this.grpPesquisarFinanca.Controls.Add(this.lblAno);
            this.grpPesquisarFinanca.Controls.Add(this.lblEntradaSaida);
            this.grpPesquisarFinanca.Controls.Add(this.pbEntradaSaida);
            this.grpPesquisarFinanca.Controls.Add(this.cmbMes);
            this.grpPesquisarFinanca.Controls.Add(this.cmbAno);
            this.grpPesquisarFinanca.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPesquisarFinanca.Location = new System.Drawing.Point(16, 168);
            this.grpPesquisarFinanca.Name = "grpPesquisarFinanca";
            this.grpPesquisarFinanca.Size = new System.Drawing.Size(1165, 116);
            this.grpPesquisarFinanca.TabIndex = 215;
            this.grpPesquisarFinanca.TabStop = false;
            // 
            // pbMes
            // 
            this.pbMes.Image = ((System.Drawing.Image)(resources.GetObject("pbMes.Image")));
            this.pbMes.Location = new System.Drawing.Point(364, 23);
            this.pbMes.Name = "pbMes";
            this.pbMes.Size = new System.Drawing.Size(56, 37);
            this.pbMes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMes.TabIndex = 262;
            this.pbMes.TabStop = false;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(421, 26);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(65, 32);
            this.lblMes.TabIndex = 261;
            this.lblMes.Text = "Mês:";
            // 
            // rbTudo
            // 
            this.rbTudo.AutoSize = true;
            this.rbTudo.Location = new System.Drawing.Point(1044, 70);
            this.rbTudo.Name = "rbTudo";
            this.rbTudo.Size = new System.Drawing.Size(72, 29);
            this.rbTudo.TabIndex = 260;
            this.rbTudo.TabStop = true;
            this.rbTudo.Text = "Tudo";
            this.rbTudo.UseVisualStyleBackColor = true;
            this.rbTudo.CheckedChanged += new System.EventHandler(this.rbTudo_CheckedChanged);
            // 
            // rbSaidas
            // 
            this.rbSaidas.AutoSize = true;
            this.rbSaidas.Location = new System.Drawing.Point(954, 70);
            this.rbSaidas.Name = "rbSaidas";
            this.rbSaidas.Size = new System.Drawing.Size(84, 29);
            this.rbSaidas.TabIndex = 259;
            this.rbSaidas.TabStop = true;
            this.rbSaidas.Text = "Saídas";
            this.rbSaidas.UseVisualStyleBackColor = true;
            this.rbSaidas.CheckedChanged += new System.EventHandler(this.rbSaidas_CheckedChanged);
            // 
            // rbEntradas
            // 
            this.rbEntradas.AutoSize = true;
            this.rbEntradas.Location = new System.Drawing.Point(844, 70);
            this.rbEntradas.Name = "rbEntradas";
            this.rbEntradas.Size = new System.Drawing.Size(104, 29);
            this.rbEntradas.TabIndex = 258;
            this.rbEntradas.TabStop = true;
            this.rbEntradas.Text = "Entradas";
            this.rbEntradas.UseVisualStyleBackColor = true;
            this.rbEntradas.CheckedChanged += new System.EventHandler(this.rbEntradas_CheckedChanged);
            // 
            // pbAno
            // 
            this.pbAno.Image = ((System.Drawing.Image)(resources.GetObject("pbAno.Image")));
            this.pbAno.Location = new System.Drawing.Point(6, 23);
            this.pbAno.Name = "pbAno";
            this.pbAno.Size = new System.Drawing.Size(56, 37);
            this.pbAno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAno.TabIndex = 238;
            this.pbAno.TabStop = false;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(63, 26);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(63, 32);
            this.lblAno.TabIndex = 236;
            this.lblAno.Text = "Ano:";
            // 
            // pbEntradaSaida
            // 
            this.pbEntradaSaida.Image = ((System.Drawing.Image)(resources.GetObject("pbEntradaSaida.Image")));
            this.pbEntradaSaida.Location = new System.Drawing.Point(844, 17);
            this.pbEntradaSaida.Name = "pbEntradaSaida";
            this.pbEntradaSaida.Size = new System.Drawing.Size(56, 37);
            this.pbEntradaSaida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEntradaSaida.TabIndex = 257;
            this.pbEntradaSaida.TabStop = false;
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
            this.cmbMes.Location = new System.Drawing.Point(364, 65);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(450, 40);
            this.cmbMes.TabIndex = 265;
            this.cmbMes.SelectedIndexChanged += new System.EventHandler(this.cmbMes_SelectedIndexChanged);
            // 
            // cmbAno
            // 
            this.cmbAno.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.cmbAno.FormattingEnabled = true;
            this.cmbAno.Location = new System.Drawing.Point(6, 65);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(352, 40);
            this.cmbAno.TabIndex = 264;
            this.cmbAno.SelectedIndexChanged += new System.EventHandler(this.cmbAno_SelectedIndexChanged);
            // 
            // grpEntradas
            // 
            this.grpEntradas.Controls.Add(this.btnAddEntradas);
            this.grpEntradas.Controls.Add(this.lblValorEntrada);
            this.grpEntradas.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grpEntradas.Location = new System.Drawing.Point(17, 52);
            this.grpEntradas.Name = "grpEntradas";
            this.grpEntradas.Size = new System.Drawing.Size(200, 116);
            this.grpEntradas.TabIndex = 219;
            this.grpEntradas.TabStop = false;
            this.grpEntradas.Text = "Entradas";
            // 
            // btnAddEntradas
            // 
            this.btnAddEntradas.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddEntradas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEntradas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddEntradas.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEntradas.Image")));
            this.btnAddEntradas.Location = new System.Drawing.Point(113, 18);
            this.btnAddEntradas.Name = "btnAddEntradas";
            this.btnAddEntradas.Size = new System.Drawing.Size(49, 37);
            this.btnAddEntradas.TabIndex = 291;
            this.btnAddEntradas.UseVisualStyleBackColor = false;
            this.btnAddEntradas.Click += new System.EventHandler(this.btnAddEntradas_Click);
            // 
            // lblValorEntrada
            // 
            this.lblValorEntrada.AutoSize = true;
            this.lblValorEntrada.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorEntrada.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblValorEntrada.Location = new System.Drawing.Point(87, 58);
            this.lblValorEntrada.Name = "lblValorEntrada";
            this.lblValorEntrada.Size = new System.Drawing.Size(89, 25);
            this.lblValorEntrada.TabIndex = 1;
            this.lblValorEntrada.Text = "R$ 11000";
            // 
            // grpSaidas
            // 
            this.grpSaidas.Controls.Add(this.btnAddSaidas);
            this.grpSaidas.Controls.Add(this.lblValorSaida);
            this.grpSaidas.Controls.Add(this.pictureBox1);
            this.grpSaidas.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grpSaidas.Location = new System.Drawing.Point(223, 52);
            this.grpSaidas.Name = "grpSaidas";
            this.grpSaidas.Size = new System.Drawing.Size(200, 116);
            this.grpSaidas.TabIndex = 220;
            this.grpSaidas.TabStop = false;
            this.grpSaidas.Text = "Saídas";
            // 
            // btnAddSaidas
            // 
            this.btnAddSaidas.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddSaidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSaidas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddSaidas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddSaidas.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSaidas.Image")));
            this.btnAddSaidas.Location = new System.Drawing.Point(112, 18);
            this.btnAddSaidas.Name = "btnAddSaidas";
            this.btnAddSaidas.Size = new System.Drawing.Size(49, 37);
            this.btnAddSaidas.TabIndex = 293;
            this.btnAddSaidas.UseVisualStyleBackColor = false;
            this.btnAddSaidas.Click += new System.EventHandler(this.btnAddSaidas_Click);
            // 
            // lblValorSaida
            // 
            this.lblValorSaida.AutoSize = true;
            this.lblValorSaida.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblValorSaida.ForeColor = System.Drawing.Color.Tomato;
            this.lblValorSaida.Location = new System.Drawing.Point(87, 58);
            this.lblValorSaida.Name = "lblValorSaida";
            this.lblValorSaida.Size = new System.Drawing.Size(89, 25);
            this.lblValorSaida.TabIndex = 2;
            this.lblValorSaida.Text = "R$ 11000";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 217;
            this.pictureBox1.TabStop = false;
            // 
            // grpLucro
            // 
            this.grpLucro.Controls.Add(this.pbBomRuimLucro);
            this.grpLucro.Controls.Add(this.lblValorLucro);
            this.grpLucro.Controls.Add(this.pictureBox2);
            this.grpLucro.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLucro.Location = new System.Drawing.Point(428, 52);
            this.grpLucro.Name = "grpLucro";
            this.grpLucro.Size = new System.Drawing.Size(200, 116);
            this.grpLucro.TabIndex = 220;
            this.grpLucro.TabStop = false;
            this.grpLucro.Text = "Lucro";
            // 
            // pbBomRuimLucro
            // 
            this.pbBomRuimLucro.Location = new System.Drawing.Point(121, 18);
            this.pbBomRuimLucro.Name = "pbBomRuimLucro";
            this.pbBomRuimLucro.Size = new System.Drawing.Size(40, 37);
            this.pbBomRuimLucro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBomRuimLucro.TabIndex = 2;
            this.pbBomRuimLucro.TabStop = false;
            // 
            // lblValorLucro
            // 
            this.lblValorLucro.AutoSize = true;
            this.lblValorLucro.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblValorLucro.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblValorLucro.Location = new System.Drawing.Point(87, 58);
            this.lblValorLucro.Name = "lblValorLucro";
            this.lblValorLucro.Size = new System.Drawing.Size(89, 25);
            this.lblValorLucro.TabIndex = 3;
            this.lblValorLucro.Text = "R$ 11000";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 218;
            this.pictureBox2.TabStop = false;
            // 
            // pbCaixaTotal
            // 
            this.pbCaixaTotal.Image = ((System.Drawing.Image)(resources.GetObject("pbCaixaTotal.Image")));
            this.pbCaixaTotal.Location = new System.Drawing.Point(22, 89);
            this.pbCaixaTotal.Name = "pbCaixaTotal";
            this.pbCaixaTotal.Size = new System.Drawing.Size(79, 73);
            this.pbCaixaTotal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCaixaTotal.TabIndex = 216;
            this.pbCaixaTotal.TabStop = false;
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
            this.btnLimpar.TabIndex = 213;
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
            this.btnMostrarTodos.Location = new System.Drawing.Point(634, 57);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(265, 111);
            this.btnMostrarTodos.TabIndex = 212;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMostrarTodos.UseVisualStyleBackColor = false;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // frmFinancas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1204, 826);
            this.Controls.Add(this.pbCaixaTotal);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.gvExibirFinancas);
            this.Controls.Add(this.grpPesquisarFinanca);
            this.Controls.Add(this.pnlDireita);
            this.Controls.Add(this.pnlRodapé);
            this.Controls.Add(this.pnlEsquerda);
            this.Controls.Add(this.pnlCabecalho);
            this.Controls.Add(this.grpEntradas);
            this.Controls.Add(this.grpSaidas);
            this.Controls.Add(this.grpLucro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFinancas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmFinancas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirFinancas)).EndInit();
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarioAtivo)).EndInit();
            this.grpPesquisarFinanca.ResumeLayout(false);
            this.grpPesquisarFinanca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEntradaSaida)).EndInit();
            this.grpEntradas.ResumeLayout(false);
            this.grpEntradas.PerformLayout();
            this.grpSaidas.ResumeLayout(false);
            this.grpSaidas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpLucro.ResumeLayout(false);
            this.grpLucro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBomRuimLucro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaixaTotal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnMostrarTodos;
        public System.Windows.Forms.DataGridView gvExibirFinancas;
        private System.Windows.Forms.Panel pnlDireita;
        private System.Windows.Forms.Panel pnlRodapé;
        private System.Windows.Forms.Panel pnlEsquerda;
        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.PictureBox pbUsuarioAtivo;
        private System.Windows.Forms.Label lblNomeUsuAtivo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblEntradaSaida;
        private System.Windows.Forms.GroupBox grpPesquisarFinanca;
        private System.Windows.Forms.PictureBox pbAno;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.PictureBox pbEntradaSaida;
        private System.Windows.Forms.RadioButton rbSaidas;
        private System.Windows.Forms.RadioButton rbEntradas;
        private System.Windows.Forms.RadioButton rbTudo;
        private System.Windows.Forms.PictureBox pbMes;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.PictureBox pbCaixaTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox grpEntradas;
        private System.Windows.Forms.GroupBox grpSaidas;
        private System.Windows.Forms.GroupBox grpLucro;
        private System.Windows.Forms.Label lblValorEntrada;
        private System.Windows.Forms.Label lblValorSaida;
        private System.Windows.Forms.Label lblValorLucro;
        private System.Windows.Forms.ComboBox cmbAno;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.PictureBox pbBomRuimLucro;
        private System.Windows.Forms.Button btnAddEntradas;
        private System.Windows.Forms.Button btnAddSaidas;
    }
}