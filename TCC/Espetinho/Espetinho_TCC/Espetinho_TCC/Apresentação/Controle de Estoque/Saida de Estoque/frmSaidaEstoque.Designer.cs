namespace Espetinho_TCC.Apresentação.Controle_de_Estoque
{
    partial class frmSaidaEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaidaEstoque));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlDireita = new System.Windows.Forms.Panel();
            this.pnlRodapé = new System.Windows.Forms.Panel();
            this.pnlEsquerda = new System.Windows.Forms.Panel();
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.pbUsuarioAtivo = new System.Windows.Forms.PictureBox();
            this.lblNomeUsuAtivo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.gvExibirSaidasEstoque = new System.Windows.Forms.DataGridView();
            this.grpPesquisarProd = new System.Windows.Forms.GroupBox();
            this.lblAte = new System.Windows.Forms.Label();
            this.dtpDataTermino = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.pbValor = new System.Windows.Forms.PictureBox();
            this.pbData = new System.Windows.Forms.PictureBox();
            this.pbID = new System.Windows.Forms.PictureBox();
            this.cmbPesqPorValor = new System.Windows.Forms.ComboBox();
            this.btnPesqValor = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnPesqData = new System.Windows.Forms.Button();
            this.btnPesqID = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarioAtivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirSaidasEstoque)).BeginInit();
            this.grpPesquisarProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbID)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDireita
            // 
            this.pnlDireita.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlDireita.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDireita.Location = new System.Drawing.Point(1051, 50);
            this.pnlDireita.Name = "pnlDireita";
            this.pnlDireita.Size = new System.Drawing.Size(5, 695);
            this.pnlDireita.TabIndex = 208;
            // 
            // pnlRodapé
            // 
            this.pnlRodapé.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlRodapé.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodapé.Location = new System.Drawing.Point(5, 745);
            this.pnlRodapé.Name = "pnlRodapé";
            this.pnlRodapé.Size = new System.Drawing.Size(1051, 5);
            this.pnlRodapé.TabIndex = 207;
            // 
            // pnlEsquerda
            // 
            this.pnlEsquerda.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlEsquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEsquerda.Location = new System.Drawing.Point(0, 50);
            this.pnlEsquerda.Name = "pnlEsquerda";
            this.pnlEsquerda.Size = new System.Drawing.Size(5, 700);
            this.pnlEsquerda.TabIndex = 206;
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
            this.pnlCabecalho.Size = new System.Drawing.Size(1056, 50);
            this.pnlCabecalho.TabIndex = 205;
            // 
            // pbUsuarioAtivo
            // 
            this.pbUsuarioAtivo.Image = ((System.Drawing.Image)(resources.GetObject("pbUsuarioAtivo.Image")));
            this.pbUsuarioAtivo.Location = new System.Drawing.Point(846, 4);
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
            this.lblNomeUsuAtivo.Location = new System.Drawing.Point(894, 9);
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
            this.lblTitulo.Location = new System.Drawing.Point(368, 2);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(317, 45);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "SAÍDAS DE ESTOQUE";
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(3, 3);
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
            this.btnFechar.Location = new System.Drawing.Point(1006, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(47, 46);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // gvExibirSaidasEstoque
            // 
            this.gvExibirSaidasEstoque.AllowUserToAddRows = false;
            this.gvExibirSaidasEstoque.AllowUserToDeleteRows = false;
            this.gvExibirSaidasEstoque.AllowUserToOrderColumns = true;
            this.gvExibirSaidasEstoque.AllowUserToResizeColumns = false;
            this.gvExibirSaidasEstoque.AllowUserToResizeRows = false;
            this.gvExibirSaidasEstoque.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.gvExibirSaidasEstoque.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gvExibirSaidasEstoque.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvExibirSaidasEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvExibirSaidasEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvExibirSaidasEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvExibirSaidasEstoque.DefaultCellStyle = dataGridViewCellStyle5;
            this.gvExibirSaidasEstoque.Location = new System.Drawing.Point(11, 299);
            this.gvExibirSaidasEstoque.MultiSelect = false;
            this.gvExibirSaidasEstoque.Name = "gvExibirSaidasEstoque";
            this.gvExibirSaidasEstoque.ReadOnly = true;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gvExibirSaidasEstoque.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gvExibirSaidasEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvExibirSaidasEstoque.Size = new System.Drawing.Size(1033, 439);
            this.gvExibirSaidasEstoque.TabIndex = 209;
            this.gvExibirSaidasEstoque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvExibirSaidasEstoque_CellContentClick);
            this.gvExibirSaidasEstoque.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvExibirSaidasEstoque_CellDoubleClick);
            // 
            // grpPesquisarProd
            // 
            this.grpPesquisarProd.Controls.Add(this.lblAte);
            this.grpPesquisarProd.Controls.Add(this.dtpDataTermino);
            this.grpPesquisarProd.Controls.Add(this.dtpDataInicio);
            this.grpPesquisarProd.Controls.Add(this.pbValor);
            this.grpPesquisarProd.Controls.Add(this.pbData);
            this.grpPesquisarProd.Controls.Add(this.pbID);
            this.grpPesquisarProd.Controls.Add(this.cmbPesqPorValor);
            this.grpPesquisarProd.Controls.Add(this.btnPesqValor);
            this.grpPesquisarProd.Controls.Add(this.lblValor);
            this.grpPesquisarProd.Controls.Add(this.btnPesqData);
            this.grpPesquisarProd.Controls.Add(this.btnPesqID);
            this.grpPesquisarProd.Controls.Add(this.lblData);
            this.grpPesquisarProd.Controls.Add(this.txtID);
            this.grpPesquisarProd.Controls.Add(this.lblID);
            this.grpPesquisarProd.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPesquisarProd.Location = new System.Drawing.Point(12, 182);
            this.grpPesquisarProd.Name = "grpPesquisarProd";
            this.grpPesquisarProd.Size = new System.Drawing.Size(1033, 111);
            this.grpPesquisarProd.TabIndex = 210;
            this.grpPesquisarProd.TabStop = false;
            // 
            // lblAte
            // 
            this.lblAte.AutoSize = true;
            this.lblAte.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAte.Location = new System.Drawing.Point(445, 65);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(48, 32);
            this.lblAte.TabIndex = 235;
            this.lblAte.Text = "até";
            // 
            // dtpDataTermino
            // 
            this.dtpDataTermino.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.dtpDataTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataTermino.Location = new System.Drawing.Point(499, 60);
            this.dtpDataTermino.Name = "dtpDataTermino";
            this.dtpDataTermino.Size = new System.Drawing.Size(174, 39);
            this.dtpDataTermino.TabIndex = 234;
            this.dtpDataTermino.Enter += new System.EventHandler(this.dtpDataTermino_Enter);
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicio.Location = new System.Drawing.Point(237, 60);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(202, 39);
            this.dtpDataInicio.TabIndex = 233;
            this.dtpDataInicio.Enter += new System.EventHandler(this.dtpDataInicio_Enter);
            // 
            // pbValor
            // 
            this.pbValor.Image = ((System.Drawing.Image)(resources.GetObject("pbValor.Image")));
            this.pbValor.Location = new System.Drawing.Point(733, 18);
            this.pbValor.Name = "pbValor";
            this.pbValor.Size = new System.Drawing.Size(56, 37);
            this.pbValor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbValor.TabIndex = 232;
            this.pbValor.TabStop = false;
            // 
            // pbData
            // 
            this.pbData.Image = ((System.Drawing.Image)(resources.GetObject("pbData.Image")));
            this.pbData.Location = new System.Drawing.Point(237, 18);
            this.pbData.Name = "pbData";
            this.pbData.Size = new System.Drawing.Size(56, 37);
            this.pbData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbData.TabIndex = 231;
            this.pbData.TabStop = false;
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
            // cmbPesqPorValor
            // 
            this.cmbPesqPorValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPesqPorValor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPesqPorValor.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPesqPorValor.FormattingEnabled = true;
            this.cmbPesqPorValor.Items.AddRange(new object[] {
            "25 OU MENOS",
            "ENTRE 25 E 50",
            "ENTRE 50 E 100",
            "100 OU MAIS"});
            this.cmbPesqPorValor.Location = new System.Drawing.Point(733, 61);
            this.cmbPesqPorValor.Name = "cmbPesqPorValor";
            this.cmbPesqPorValor.Size = new System.Drawing.Size(235, 38);
            this.cmbPesqPorValor.TabIndex = 204;
            this.cmbPesqPorValor.SelectedIndexChanged += new System.EventHandler(this.cmbPesqPorValor_SelectedIndexChanged);
            // 
            // btnPesqValor
            // 
            this.btnPesqValor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPesqValor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesqValor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqValor.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnPesqValor.Image = ((System.Drawing.Image)(resources.GetObject("btnPesqValor.Image")));
            this.btnPesqValor.Location = new System.Drawing.Point(968, 61);
            this.btnPesqValor.Name = "btnPesqValor";
            this.btnPesqValor.Size = new System.Drawing.Size(54, 38);
            this.btnPesqValor.TabIndex = 8;
            this.btnPesqValor.UseVisualStyleBackColor = false;
            this.btnPesqValor.Click += new System.EventHandler(this.btnPesqValor_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(795, 23);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(148, 32);
            this.lblValor.TabIndex = 6;
            this.lblValor.Text = "Valor em R$:";
            // 
            // btnPesqData
            // 
            this.btnPesqData.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPesqData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesqData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqData.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnPesqData.Image = ((System.Drawing.Image)(resources.GetObject("btnPesqData.Image")));
            this.btnPesqData.Location = new System.Drawing.Point(673, 60);
            this.btnPesqData.Name = "btnPesqData";
            this.btnPesqData.Size = new System.Drawing.Size(54, 39);
            this.btnPesqData.TabIndex = 5;
            this.btnPesqData.UseVisualStyleBackColor = false;
            this.btnPesqData.Click += new System.EventHandler(this.btnPesqData_Click);
            // 
            // btnPesqID
            // 
            this.btnPesqID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesqID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnPesqID.Image = ((System.Drawing.Image)(resources.GetObject("btnPesqID.Image")));
            this.btnPesqID.Location = new System.Drawing.Point(177, 60);
            this.btnPesqID.Name = "btnPesqID";
            this.btnPesqID.Size = new System.Drawing.Size(54, 39);
            this.btnPesqID.TabIndex = 4;
            this.btnPesqID.UseVisualStyleBackColor = false;
            this.btnPesqID.Click += new System.EventHandler(this.btnPesqID_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(294, 23);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(69, 32);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data:";
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
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Tomato;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(690, 56);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(265, 111);
            this.btnLimpar.TabIndex = 212;
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
            this.btnMostrarTodos.Location = new System.Drawing.Point(110, 56);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(265, 111);
            this.btnMostrarTodos.TabIndex = 211;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMostrarTodos.UseVisualStyleBackColor = false;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // frmSaidaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1056, 750);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.grpPesquisarProd);
            this.Controls.Add(this.gvExibirSaidasEstoque);
            this.Controls.Add(this.pnlDireita);
            this.Controls.Add(this.pnlRodapé);
            this.Controls.Add(this.pnlEsquerda);
            this.Controls.Add(this.pnlCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSaidaEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSaidaEstoque";
            this.Load += new System.EventHandler(this.frmSaidaEstoque_Load);
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarioAtivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirSaidasEstoque)).EndInit();
            this.grpPesquisarProd.ResumeLayout(false);
            this.grpPesquisarProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDireita;
        private System.Windows.Forms.Panel pnlRodapé;
        private System.Windows.Forms.Panel pnlEsquerda;
        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.PictureBox pbUsuarioAtivo;
        private System.Windows.Forms.Label lblNomeUsuAtivo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnFechar;
        public System.Windows.Forms.DataGridView gvExibirSaidasEstoque;
        private System.Windows.Forms.GroupBox grpPesquisarProd;
        private System.Windows.Forms.PictureBox pbValor;
        private System.Windows.Forms.PictureBox pbData;
        private System.Windows.Forms.PictureBox pbID;
        private System.Windows.Forms.ComboBox cmbPesqPorValor;
        private System.Windows.Forms.Button btnPesqValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnPesqData;
        private System.Windows.Forms.Button btnPesqID;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
        private System.Windows.Forms.DateTimePicker dtpDataTermino;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnMostrarTodos;
    }
}