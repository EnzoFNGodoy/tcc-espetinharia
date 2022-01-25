namespace Espetinho_TCC.Apresentação.Auditoria
{
    partial class frmAuditoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuditoria));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlDireita = new System.Windows.Forms.Panel();
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.pnlEsquerda = new System.Windows.Forms.Panel();
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.gvAuditoria = new System.Windows.Forms.DataGridView();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnMostrarTudo = new System.Windows.Forms.Button();
            this.cmbAcoes = new System.Windows.Forms.ComboBox();
            this.sp3 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblAcoes = new System.Windows.Forms.Label();
            this.cmbTabela = new System.Windows.Forms.ComboBox();
            this.sp2 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblTabela = new System.Windows.Forms.Label();
            this.sp1 = new Guna.UI2.WinForms.Guna2Separator();
            this.dtpDataAuditoria = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvAuditoria)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDireita
            // 
            this.pnlDireita.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlDireita.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDireita.Location = new System.Drawing.Point(1050, 50);
            this.pnlDireita.Name = "pnlDireita";
            this.pnlDireita.Size = new System.Drawing.Size(10, 646);
            this.pnlDireita.TabIndex = 7;
            // 
            // pnlRodape
            // 
            this.pnlRodape.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodape.Location = new System.Drawing.Point(10, 696);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(1050, 10);
            this.pnlRodape.TabIndex = 6;
            // 
            // pnlEsquerda
            // 
            this.pnlEsquerda.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlEsquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEsquerda.Location = new System.Drawing.Point(0, 50);
            this.pnlEsquerda.Name = "pnlEsquerda";
            this.pnlEsquerda.Size = new System.Drawing.Size(10, 656);
            this.pnlEsquerda.TabIndex = 5;
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlCabecalho.Controls.Add(this.lblTitulo);
            this.pnlCabecalho.Controls.Add(this.btnFechar);
            this.pnlCabecalho.Controls.Add(this.btnMenu);
            this.pnlCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new System.Drawing.Size(1060, 50);
            this.pnlCabecalho.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(392, 2);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(182, 45);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "AUDITORIA";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(1010, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(47, 50);
            this.btnFechar.TabIndex = 4;
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
            this.btnMenu.Location = new System.Drawing.Point(3, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(47, 50);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.UseVisualStyleBackColor = false;
            // 
            // gvAuditoria
            // 
            this.gvAuditoria.AllowUserToAddRows = false;
            this.gvAuditoria.AllowUserToDeleteRows = false;
            this.gvAuditoria.AllowUserToResizeColumns = false;
            this.gvAuditoria.AllowUserToResizeRows = false;
            this.gvAuditoria.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.gvAuditoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gvAuditoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvAuditoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvAuditoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAuditoria.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvAuditoria.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvAuditoria.Location = new System.Drawing.Point(322, 56);
            this.gvAuditoria.MultiSelect = false;
            this.gvAuditoria.Name = "gvAuditoria";
            this.gvAuditoria.ReadOnly = true;
            this.gvAuditoria.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gvAuditoria.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gvAuditoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvAuditoria.Size = new System.Drawing.Size(722, 634);
            this.gvAuditoria.TabIndex = 293;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Gray;
            this.pnlMenu.Controls.Add(this.btnLimpar);
            this.pnlMenu.Controls.Add(this.btnMostrarTudo);
            this.pnlMenu.Controls.Add(this.cmbAcoes);
            this.pnlMenu.Controls.Add(this.sp3);
            this.pnlMenu.Controls.Add(this.lblAcoes);
            this.pnlMenu.Controls.Add(this.cmbTabela);
            this.pnlMenu.Controls.Add(this.sp2);
            this.pnlMenu.Controls.Add(this.lblTabela);
            this.pnlMenu.Controls.Add(this.sp1);
            this.pnlMenu.Controls.Add(this.dtpDataAuditoria);
            this.pnlMenu.Controls.Add(this.lblData);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(10, 50);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(306, 646);
            this.pnlMenu.TabIndex = 294;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Tomato;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(10, 512);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(289, 111);
            this.btnLimpar.TabIndex = 308;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnMostrarTudo
            // 
            this.btnMostrarTudo.BackColor = System.Drawing.Color.Turquoise;
            this.btnMostrarTudo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarTudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTudo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnMostrarTudo.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarTudo.Image")));
            this.btnMostrarTudo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMostrarTudo.Location = new System.Drawing.Point(9, 386);
            this.btnMostrarTudo.Name = "btnMostrarTudo";
            this.btnMostrarTudo.Size = new System.Drawing.Size(290, 111);
            this.btnMostrarTudo.TabIndex = 307;
            this.btnMostrarTudo.Text = "Mostrar Tudo";
            this.btnMostrarTudo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMostrarTudo.UseVisualStyleBackColor = false;
            this.btnMostrarTudo.Click += new System.EventHandler(this.btnMostrarTudo_Click);
            // 
            // cmbAcoes
            // 
            this.cmbAcoes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAcoes.FormattingEnabled = true;
            this.cmbAcoes.Items.AddRange(new object[] {
            "CADASTROS",
            "ALTERAÇÕES ",
            "EXCLUSÕES"});
            this.cmbAcoes.Location = new System.Drawing.Point(16, 312);
            this.cmbAcoes.Name = "cmbAcoes";
            this.cmbAcoes.Size = new System.Drawing.Size(275, 40);
            this.cmbAcoes.TabIndex = 303;
            this.cmbAcoes.SelectedIndexChanged += new System.EventHandler(this.cmbAcoes_SelectedIndexChanged);
            // 
            // sp3
            // 
            this.sp3.Location = new System.Drawing.Point(2, 370);
            this.sp3.Name = "sp3";
            this.sp3.Size = new System.Drawing.Size(301, 10);
            this.sp3.TabIndex = 302;
            // 
            // lblAcoes
            // 
            this.lblAcoes.AutoSize = true;
            this.lblAcoes.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblAcoes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAcoes.Location = new System.Drawing.Point(101, 266);
            this.lblAcoes.Name = "lblAcoes";
            this.lblAcoes.Size = new System.Drawing.Size(83, 32);
            this.lblAcoes.TabIndex = 301;
            this.lblAcoes.Text = "Ações:";
            // 
            // cmbTabela
            // 
            this.cmbTabela.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTabela.FormattingEnabled = true;
            this.cmbTabela.Items.AddRange(new object[] {
            "USUÁRIOS",
            "CLIENTES",
            "FUNCIONÁRIOS",
            "FORNECEDORES",
            "PRODUTOS",
            "COMANDA / PEDIDOS",
            "SAIDAS DE ESTOQUE",
            "ENTRADAS DE ESTOQUE",
            "PEDIDOS PARA FORNECEDORES",
            "TIPOS DE USUÁRIO",
            "TIPOS DE PRODUTO",
            "CARGOS",
            "FINANÇAS",
            "FORMAS DE PAGAMENTO"});
            this.cmbTabela.Location = new System.Drawing.Point(15, 175);
            this.cmbTabela.Name = "cmbTabela";
            this.cmbTabela.Size = new System.Drawing.Size(276, 40);
            this.cmbTabela.TabIndex = 300;
            this.cmbTabela.SelectedIndexChanged += new System.EventHandler(this.cmbTabela_SelectedIndexChanged);
            // 
            // sp2
            // 
            this.sp2.Location = new System.Drawing.Point(1, 233);
            this.sp2.Name = "sp2";
            this.sp2.Size = new System.Drawing.Size(301, 10);
            this.sp2.TabIndex = 299;
            // 
            // lblTabela
            // 
            this.lblTabela.AutoSize = true;
            this.lblTabela.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblTabela.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTabela.Location = new System.Drawing.Point(71, 130);
            this.lblTabela.Name = "lblTabela";
            this.lblTabela.Size = new System.Drawing.Size(150, 32);
            this.lblTabela.TabIndex = 297;
            this.lblTabela.Text = "Registros de:";
            // 
            // sp1
            // 
            this.sp1.Location = new System.Drawing.Point(1, 102);
            this.sp1.Name = "sp1";
            this.sp1.Size = new System.Drawing.Size(301, 10);
            this.sp1.TabIndex = 296;
            // 
            // dtpDataAuditoria
            // 
            this.dtpDataAuditoria.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.dtpDataAuditoria.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAuditoria.Location = new System.Drawing.Point(16, 57);
            this.dtpDataAuditoria.Name = "dtpDataAuditoria";
            this.dtpDataAuditoria.Size = new System.Drawing.Size(275, 39);
            this.dtpDataAuditoria.TabIndex = 295;
            this.dtpDataAuditoria.ValueChanged += new System.EventHandler(this.dtpDataAuditoria_ValueChanged);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblData.Location = new System.Drawing.Point(112, 6);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(69, 32);
            this.lblData.TabIndex = 10;
            this.lblData.Text = "Data:";
            // 
            // frmAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1060, 706);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.gvAuditoria);
            this.Controls.Add(this.pnlDireita);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.pnlEsquerda);
            this.Controls.Add(this.pnlCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAuditoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAuditoria";
            this.Load += new System.EventHandler(this.frmAuditoria_Load);
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvAuditoria)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDireita;
        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.Panel pnlEsquerda;
        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMenu;
        public System.Windows.Forms.DataGridView gvAuditoria;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtpDataAuditoria;
        private Guna.UI2.WinForms.Guna2Separator sp1;
        private Guna.UI2.WinForms.Guna2Separator sp2;
        private System.Windows.Forms.Label lblTabela;
        private System.Windows.Forms.ComboBox cmbTabela;
        private System.Windows.Forms.ComboBox cmbAcoes;
        private Guna.UI2.WinForms.Guna2Separator sp3;
        private System.Windows.Forms.Label lblAcoes;
        private System.Windows.Forms.Button btnMostrarTudo;
        private System.Windows.Forms.Button btnLimpar;
    }
}