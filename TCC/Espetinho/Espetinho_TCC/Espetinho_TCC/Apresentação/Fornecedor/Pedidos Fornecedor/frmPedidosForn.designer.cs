namespace Espetinho_TCC.Apresentação.Fornecedor
{
    partial class frmPedidosForn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidosForn));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.gvExibirPedForn = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gbPedForn = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPesqPorValor = new System.Windows.Forms.ComboBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnPesqPorPreco = new System.Windows.Forms.Button();
            this.btnPesqPorForn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPesquisarPorID = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.pbID = new System.Windows.Forms.PictureBox();
            this.txtPesqPorForn = new System.Windows.Forms.TextBox();
            this.txtPesqPorId = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirPedForn)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbPedForn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbID)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCabecalho.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlCabecalho.Controls.Add(this.lblTitulo);
            this.pnlCabecalho.Controls.Add(this.btnFechar);
            this.pnlCabecalho.Controls.Add(this.btnMenu);
            this.pnlCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new System.Drawing.Size(1010, 41);
            this.pnlCabecalho.TabIndex = 79;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(262, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(347, 37);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "PEDIDOS DO FORNECEDOR";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(962, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(47, 40);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(56, 40);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.UseVisualStyleBackColor = false;
            // 
            // gvExibirPedForn
            // 
            this.gvExibirPedForn.AllowUserToAddRows = false;
            this.gvExibirPedForn.AllowUserToDeleteRows = false;
            this.gvExibirPedForn.AllowUserToOrderColumns = true;
            this.gvExibirPedForn.AllowUserToResizeColumns = false;
            this.gvExibirPedForn.AllowUserToResizeRows = false;
            this.gvExibirPedForn.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.gvExibirPedForn.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gvExibirPedForn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvExibirPedForn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvExibirPedForn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvExibirPedForn.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvExibirPedForn.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvExibirPedForn.Location = new System.Drawing.Point(12, 269);
            this.gvExibirPedForn.MultiSelect = false;
            this.gvExibirPedForn.Name = "gvExibirPedForn";
            this.gvExibirPedForn.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gvExibirPedForn.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gvExibirPedForn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvExibirPedForn.Size = new System.Drawing.Size(985, 395);
            this.gvExibirPedForn.TabIndex = 198;
            this.gvExibirPedForn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvExibirPedForn_CellContentClick);
            this.gvExibirPedForn.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvExibirPedForn_CellDoubleClick);
            this.gvExibirPedForn.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvExibirPedForn_ColumnHeaderMouseClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 637);
            this.panel1.TabIndex = 199;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 637);
            this.panel2.TabIndex = 200;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(1002, 41);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 637);
            this.panel3.TabIndex = 201;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Location = new System.Drawing.Point(661, 7);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 536);
            this.panel4.TabIndex = 200;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel5.Location = new System.Drawing.Point(8, 670);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(994, 8);
            this.panel5.TabIndex = 201;
            // 
            // gbPedForn
            // 
            this.gbPedForn.Controls.Add(this.label1);
            this.gbPedForn.Controls.Add(this.cmbPesqPorValor);
            this.gbPedForn.Controls.Add(this.lblValor);
            this.gbPedForn.Controls.Add(this.pictureBox2);
            this.gbPedForn.Controls.Add(this.btnPesqPorPreco);
            this.gbPedForn.Controls.Add(this.btnPesqPorForn);
            this.gbPedForn.Controls.Add(this.pictureBox1);
            this.gbPedForn.Controls.Add(this.btnPesquisarPorID);
            this.gbPedForn.Controls.Add(this.lblID);
            this.gbPedForn.Controls.Add(this.pbID);
            this.gbPedForn.Controls.Add(this.txtPesqPorForn);
            this.gbPedForn.Controls.Add(this.txtPesqPorId);
            this.gbPedForn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPedForn.Location = new System.Drawing.Point(13, 158);
            this.gbPedForn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbPedForn.Name = "gbPedForn";
            this.gbPedForn.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbPedForn.Size = new System.Drawing.Size(984, 107);
            this.gbPedForn.TabIndex = 202;
            this.gbPedForn.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 32);
            this.label1.TabIndex = 239;
            this.label1.Text = "FORNECEDOR:";
            // 
            // cmbPesqPorValor
            // 
            this.cmbPesqPorValor.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPesqPorValor.FormattingEnabled = true;
            this.cmbPesqPorValor.Items.AddRange(new object[] {
            "100 OU MENOS",
            "ENTRE 100 E 500",
            "ENTRE 500 E 1000",
            "1000 OU MAIS"});
            this.cmbPesqPorValor.Location = new System.Drawing.Point(682, 66);
            this.cmbPesqPorValor.Name = "cmbPesqPorValor";
            this.cmbPesqPorValor.Size = new System.Drawing.Size(243, 38);
            this.cmbPesqPorValor.TabIndex = 238;
            this.cmbPesqPorValor.SelectedIndexChanged += new System.EventHandler(this.cmbPesqPorValor_SelectedIndexChanged);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(744, 24);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(91, 32);
            this.lblValor.TabIndex = 203;
            this.lblValor.Text = "VALOR:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(682, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 237;
            this.pictureBox2.TabStop = false;
            // 
            // btnPesqPorPreco
            // 
            this.btnPesqPorPreco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesqPorPreco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqPorPreco.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnPesqPorPreco.Image = ((System.Drawing.Image)(resources.GetObject("btnPesqPorPreco.Image")));
            this.btnPesqPorPreco.Location = new System.Drawing.Point(925, 66);
            this.btnPesqPorPreco.Name = "btnPesqPorPreco";
            this.btnPesqPorPreco.Size = new System.Drawing.Size(54, 38);
            this.btnPesqPorPreco.TabIndex = 236;
            this.btnPesqPorPreco.UseVisualStyleBackColor = false;
            this.btnPesqPorPreco.Click += new System.EventHandler(this.btnPesqPorPreco_Click);
            // 
            // btnPesqPorForn
            // 
            this.btnPesqPorForn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesqPorForn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqPorForn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnPesqPorForn.Image = ((System.Drawing.Image)(resources.GetObject("btnPesqPorForn.Image")));
            this.btnPesqPorForn.Location = new System.Drawing.Point(622, 65);
            this.btnPesqPorForn.Name = "btnPesqPorForn";
            this.btnPesqPorForn.Size = new System.Drawing.Size(54, 39);
            this.btnPesqPorForn.TabIndex = 235;
            this.btnPesqPorForn.UseVisualStyleBackColor = false;
            this.btnPesqPorForn.Click += new System.EventHandler(this.btnPesqPorData_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(223, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 233;
            this.pictureBox1.TabStop = false;
            // 
            // btnPesquisarPorID
            // 
            this.btnPesquisarPorID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarPorID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarPorID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnPesquisarPorID.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarPorID.Image")));
            this.btnPesquisarPorID.Location = new System.Drawing.Point(163, 63);
            this.btnPesquisarPorID.Name = "btnPesquisarPorID";
            this.btnPesquisarPorID.Size = new System.Drawing.Size(54, 39);
            this.btnPesquisarPorID.TabIndex = 232;
            this.btnPesquisarPorID.UseVisualStyleBackColor = false;
            this.btnPesquisarPorID.Click += new System.EventHandler(this.btnPesquisarPorID_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(68, 24);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(43, 32);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "ID:";
            // 
            // pbID
            // 
            this.pbID.Image = ((System.Drawing.Image)(resources.GetObject("pbID.Image")));
            this.pbID.Location = new System.Drawing.Point(5, 20);
            this.pbID.Name = "pbID";
            this.pbID.Size = new System.Drawing.Size(56, 37);
            this.pbID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbID.TabIndex = 231;
            this.pbID.TabStop = false;
            // 
            // txtPesqPorForn
            // 
            this.txtPesqPorForn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesqPorForn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesqPorForn.Location = new System.Drawing.Point(223, 65);
            this.txtPesqPorForn.Name = "txtPesqPorForn";
            this.txtPesqPorForn.Size = new System.Drawing.Size(399, 39);
            this.txtPesqPorForn.TabIndex = 4;
            // 
            // txtPesqPorId
            // 
            this.txtPesqPorId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesqPorId.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesqPorId.Location = new System.Drawing.Point(5, 63);
            this.txtPesqPorId.Name = "txtPesqPorId";
            this.txtPesqPorId.Size = new System.Drawing.Size(158, 39);
            this.txtPesqPorId.TabIndex = 2;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Tomato;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(583, 48);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(355, 111);
            this.btnLimpar.TabIndex = 203;
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
            this.btnMostrarTodos.Location = new System.Drawing.Point(87, 47);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(355, 111);
            this.btnMostrarTodos.TabIndex = 204;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMostrarTodos.UseVisualStyleBackColor = false;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // frmPedidosForn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1010, 678);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.gbPedForn);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCabecalho);
            this.Controls.Add(this.gvExibirPedForn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPedidosForn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPedidosForn";
            this.Load += new System.EventHandler(this.frmPedidosForn_Load);
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirPedForn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.gbPedForn.ResumeLayout(false);
            this.gbPedForn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMenu;
        public System.Windows.Forms.DataGridView gvExibirPedForn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox gbPedForn;
        private System.Windows.Forms.TextBox txtPesqPorId;
        private System.Windows.Forms.TextBox txtPesqPorForn;
        private System.Windows.Forms.PictureBox pbID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnPesquisarPorID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnPesqPorPreco;
        private System.Windows.Forms.Button btnPesqPorForn;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.ComboBox cmbPesqPorValor;
        private System.Windows.Forms.Label label1;
    }
}