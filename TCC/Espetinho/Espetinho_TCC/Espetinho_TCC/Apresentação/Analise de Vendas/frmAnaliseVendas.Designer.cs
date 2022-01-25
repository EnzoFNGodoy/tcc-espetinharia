namespace Espetinho_TCC.Apresentação
{
    partial class frmAnaliseVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaliseVendas));
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.pbUsuarioAtivo = new System.Windows.Forms.PictureBox();
            this.lblNomeUsuAtivo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pnlEsquerda = new System.Windows.Forms.Panel();
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.pnlDireita = new System.Windows.Forms.Panel();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.msTipoAnalise = new System.Windows.Forms.MenuStrip();
            this.vendasGeraisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasPorProdutosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarioAtivo)).BeginInit();
            this.pnlConteudo.SuspendLayout();
            this.msTipoAnalise.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlCabecalho.Controls.Add(this.pbUsuarioAtivo);
            this.pnlCabecalho.Controls.Add(this.lblNomeUsuAtivo);
            this.pnlCabecalho.Controls.Add(this.lblTitulo);
            this.pnlCabecalho.Controls.Add(this.btnFechar);
            this.pnlCabecalho.Controls.Add(this.btnMenu);
            this.pnlCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new System.Drawing.Size(958, 50);
            this.pnlCabecalho.TabIndex = 0;
            // 
            // pbUsuarioAtivo
            // 
            this.pbUsuarioAtivo.Image = ((System.Drawing.Image)(resources.GetObject("pbUsuarioAtivo.Image")));
            this.pbUsuarioAtivo.Location = new System.Drawing.Point(744, 7);
            this.pbUsuarioAtivo.Name = "pbUsuarioAtivo";
            this.pbUsuarioAtivo.Size = new System.Drawing.Size(42, 40);
            this.pbUsuarioAtivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbUsuarioAtivo.TabIndex = 15;
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
            this.lblNomeUsuAtivo.Location = new System.Drawing.Point(795, 12);
            this.lblNomeUsuAtivo.Name = "lblNomeUsuAtivo";
            this.lblNomeUsuAtivo.Size = new System.Drawing.Size(0, 30);
            this.lblNomeUsuAtivo.TabIndex = 11;
            this.lblNomeUsuAtivo.Visible = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(299, 2);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(318, 45);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "ANÁLISE DE VENDAS";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(908, 0);
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
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(47, 50);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.UseVisualStyleBackColor = false;
            // 
            // pnlEsquerda
            // 
            this.pnlEsquerda.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlEsquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEsquerda.Location = new System.Drawing.Point(0, 50);
            this.pnlEsquerda.Name = "pnlEsquerda";
            this.pnlEsquerda.Size = new System.Drawing.Size(10, 720);
            this.pnlEsquerda.TabIndex = 1;
            // 
            // pnlRodape
            // 
            this.pnlRodape.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodape.Location = new System.Drawing.Point(10, 760);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(948, 10);
            this.pnlRodape.TabIndex = 2;
            // 
            // pnlDireita
            // 
            this.pnlDireita.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlDireita.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDireita.Location = new System.Drawing.Point(948, 50);
            this.pnlDireita.Name = "pnlDireita";
            this.pnlDireita.Size = new System.Drawing.Size(10, 710);
            this.pnlDireita.TabIndex = 3;
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Controls.Add(this.msTipoAnalise);
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.Location = new System.Drawing.Point(10, 50);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(938, 710);
            this.pnlConteudo.TabIndex = 4;
            // 
            // msTipoAnalise
            // 
            this.msTipoAnalise.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msTipoAnalise.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasGeraisToolStripMenuItem,
            this.vendasPorProdutosToolStripMenuItem1});
            this.msTipoAnalise.Location = new System.Drawing.Point(0, 0);
            this.msTipoAnalise.Name = "msTipoAnalise";
            this.msTipoAnalise.Size = new System.Drawing.Size(938, 29);
            this.msTipoAnalise.TabIndex = 0;
            this.msTipoAnalise.Text = "menuStrip1";
            // 
            // vendasGeraisToolStripMenuItem
            // 
            this.vendasGeraisToolStripMenuItem.Name = "vendasGeraisToolStripMenuItem";
            this.vendasGeraisToolStripMenuItem.Size = new System.Drawing.Size(120, 25);
            this.vendasGeraisToolStripMenuItem.Text = "Vendas Gerais";
            this.vendasGeraisToolStripMenuItem.Click += new System.EventHandler(this.vendasGeraisToolStripMenuItem_Click);
            // 
            // vendasPorProdutosToolStripMenuItem1
            // 
            this.vendasPorProdutosToolStripMenuItem1.Name = "vendasPorProdutosToolStripMenuItem1";
            this.vendasPorProdutosToolStripMenuItem1.Size = new System.Drawing.Size(160, 25);
            this.vendasPorProdutosToolStripMenuItem1.Text = "Vendas de Produtos";
            this.vendasPorProdutosToolStripMenuItem1.Click += new System.EventHandler(this.vendasPorProdutosToolStripMenuItem1_Click);
            // 
            // frmAnaliseVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(958, 770);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlDireita);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.pnlEsquerda);
            this.Controls.Add(this.pnlCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msTipoAnalise;
            this.Name = "frmAnaliseVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaliseDeVendas";
            this.Load += new System.EventHandler(this.frmAnaliseVendas_Load);
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarioAtivo)).EndInit();
            this.pnlConteudo.ResumeLayout(false);
            this.pnlConteudo.PerformLayout();
            this.msTipoAnalise.ResumeLayout(false);
            this.msTipoAnalise.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.Panel pnlEsquerda;
        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.Panel pnlDireita;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNomeUsuAtivo;
        private System.Windows.Forms.PictureBox pbUsuarioAtivo;
        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.MenuStrip msTipoAnalise;
        private System.Windows.Forms.ToolStripMenuItem vendasGeraisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasPorProdutosToolStripMenuItem1;
    }
}