namespace Espetinho_TCC.Apresentação.Controle_de_Estoque.Entrada_de_Estoque
{
    partial class frmVerProdutosEntradaEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerProdutosEntradaEstoque));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pnlEsquerda = new System.Windows.Forms.Panel();
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.pnlDireita = new System.Windows.Forms.Panel();
            this.txtIdEntradaEstoque = new System.Windows.Forms.TextBox();
            this.pbIdSaidaEstoque = new System.Windows.Forms.PictureBox();
            this.lblIdSaidaEstoque = new System.Windows.Forms.Label();
            this.gvExibirProdutos = new System.Windows.Forms.DataGridView();
            this.pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIdSaidaEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirProdutos)).BeginInit();
            this.SuspendLayout();
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
            this.pnlCabecalho.Size = new System.Drawing.Size(1099, 40);
            this.pnlCabecalho.TabIndex = 234;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(388, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(207, 37);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "VER PRODUTOS";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(1049, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(47, 40);
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
            this.btnMenu.Size = new System.Drawing.Size(47, 40);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.UseVisualStyleBackColor = false;
            // 
            // pnlEsquerda
            // 
            this.pnlEsquerda.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlEsquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEsquerda.Location = new System.Drawing.Point(0, 40);
            this.pnlEsquerda.Name = "pnlEsquerda";
            this.pnlEsquerda.Size = new System.Drawing.Size(5, 456);
            this.pnlEsquerda.TabIndex = 235;
            // 
            // pnlRodape
            // 
            this.pnlRodape.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodape.Location = new System.Drawing.Point(5, 491);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(1094, 5);
            this.pnlRodape.TabIndex = 237;
            // 
            // pnlDireita
            // 
            this.pnlDireita.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlDireita.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDireita.Location = new System.Drawing.Point(1094, 40);
            this.pnlDireita.Name = "pnlDireita";
            this.pnlDireita.Size = new System.Drawing.Size(5, 451);
            this.pnlDireita.TabIndex = 238;
            // 
            // txtIdEntradaEstoque
            // 
            this.txtIdEntradaEstoque.Enabled = false;
            this.txtIdEntradaEstoque.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEntradaEstoque.Location = new System.Drawing.Point(12, 216);
            this.txtIdEntradaEstoque.Name = "txtIdEntradaEstoque";
            this.txtIdEntradaEstoque.Size = new System.Drawing.Size(234, 39);
            this.txtIdEntradaEstoque.TabIndex = 243;
            this.txtIdEntradaEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbIdSaidaEstoque
            // 
            this.pbIdSaidaEstoque.Image = ((System.Drawing.Image)(resources.GetObject("pbIdSaidaEstoque.Image")));
            this.pbIdSaidaEstoque.Location = new System.Drawing.Point(12, 170);
            this.pbIdSaidaEstoque.Name = "pbIdSaidaEstoque";
            this.pbIdSaidaEstoque.Size = new System.Drawing.Size(56, 37);
            this.pbIdSaidaEstoque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIdSaidaEstoque.TabIndex = 242;
            this.pbIdSaidaEstoque.TabStop = false;
            // 
            // lblIdSaidaEstoque
            // 
            this.lblIdSaidaEstoque.AutoSize = true;
            this.lblIdSaidaEstoque.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdSaidaEstoque.Location = new System.Drawing.Point(74, 168);
            this.lblIdSaidaEstoque.Name = "lblIdSaidaEstoque";
            this.lblIdSaidaEstoque.Size = new System.Drawing.Size(58, 45);
            this.lblIdSaidaEstoque.TabIndex = 241;
            this.lblIdSaidaEstoque.Text = "ID:";
            // 
            // gvExibirProdutos
            // 
            this.gvExibirProdutos.AllowUserToAddRows = false;
            this.gvExibirProdutos.AllowUserToDeleteRows = false;
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
            this.gvExibirProdutos.Location = new System.Drawing.Point(258, 47);
            this.gvExibirProdutos.MultiSelect = false;
            this.gvExibirProdutos.Name = "gvExibirProdutos";
            this.gvExibirProdutos.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gvExibirProdutos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gvExibirProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvExibirProdutos.Size = new System.Drawing.Size(827, 438);
            this.gvExibirProdutos.TabIndex = 244;
            this.gvExibirProdutos.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvExibirProdutos_ColumnHeaderMouseClick);
            // 
            // frmVerProdutosEntradaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1099, 496);
            this.Controls.Add(this.gvExibirProdutos);
            this.Controls.Add(this.txtIdEntradaEstoque);
            this.Controls.Add(this.pbIdSaidaEstoque);
            this.Controls.Add(this.lblIdSaidaEstoque);
            this.Controls.Add(this.pnlDireita);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.pnlEsquerda);
            this.Controls.Add(this.pnlCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVerProdutosEntradaEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVerProdutosEntradaEstoque";
            this.Load += new System.EventHandler(this.frmVerProdutosEntradaEstoque_Load);
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIdSaidaEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel pnlEsquerda;
        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.Panel pnlDireita;
        private System.Windows.Forms.TextBox txtIdEntradaEstoque;
        private System.Windows.Forms.PictureBox pbIdSaidaEstoque;
        private System.Windows.Forms.Label lblIdSaidaEstoque;
        public System.Windows.Forms.DataGridView gvExibirProdutos;
    }
}