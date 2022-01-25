namespace Espetinho_TCC
{
    partial class frmBemVindo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBemVindo));
            this.tmrCarregar = new System.Windows.Forms.Timer(this.components);
            this.pgbCarregar = new System.Windows.Forms.ProgressBar();
            this.lblConexao = new System.Windows.Forms.Label();
            this.lblContagemRegressiva = new System.Windows.Forms.Label();
            this.tmrContagem = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tmrCarregar
            // 
            this.tmrCarregar.Tick += new System.EventHandler(this.tmrCarregar_Tick);
            // 
            // pgbCarregar
            // 
            this.pgbCarregar.BackColor = System.Drawing.Color.White;
            this.pgbCarregar.Location = new System.Drawing.Point(12, 584);
            this.pgbCarregar.Name = "pgbCarregar";
            this.pgbCarregar.Size = new System.Drawing.Size(504, 53);
            this.pgbCarregar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbCarregar.TabIndex = 0;
            // 
            // lblConexao
            // 
            this.lblConexao.AutoSize = true;
            this.lblConexao.BackColor = System.Drawing.Color.Transparent;
            this.lblConexao.ForeColor = System.Drawing.Color.White;
            this.lblConexao.Location = new System.Drawing.Point(451, 9);
            this.lblConexao.Name = "lblConexao";
            this.lblConexao.Size = new System.Drawing.Size(0, 13);
            this.lblConexao.TabIndex = 1;
            // 
            // lblContagemRegressiva
            // 
            this.lblContagemRegressiva.AutoSize = true;
            this.lblContagemRegressiva.BackColor = System.Drawing.Color.Black;
            this.lblContagemRegressiva.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContagemRegressiva.ForeColor = System.Drawing.Color.White;
            this.lblContagemRegressiva.Location = new System.Drawing.Point(12, 556);
            this.lblContagemRegressiva.Name = "lblContagemRegressiva";
            this.lblContagemRegressiva.Size = new System.Drawing.Size(0, 25);
            this.lblContagemRegressiva.TabIndex = 2;
            // 
            // tmrContagem
            // 
            this.tmrContagem.Interval = 1000;
            this.tmrContagem.Tick += new System.EventHandler(this.tmrContagem_Tick);
            // 
            // frmBemVindo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(539, 651);
            this.Controls.Add(this.lblContagemRegressiva);
            this.Controls.Add(this.lblConexao);
            this.Controls.Add(this.pgbCarregar);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBemVindo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estação do Espeto";
            this.Load += new System.EventHandler(this.frmBemVindo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBemVindo_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrCarregar;
        private System.Windows.Forms.ProgressBar pgbCarregar;
        private System.Windows.Forms.Label lblConexao;
        private System.Windows.Forms.Label lblContagemRegressiva;
        private System.Windows.Forms.Timer tmrContagem;
    }
}

