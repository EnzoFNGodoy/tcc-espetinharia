namespace Espetinho_TCC.Apresentação.Analise_de_Vendas
{
    partial class frmVendasProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendasProdutos));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grpVendasGerais = new System.Windows.Forms.GroupBox();
            this.dtpDataTermino = new System.Windows.Forms.DateTimePicker();
            this.lblAte = new System.Windows.Forms.Label();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblPeriodoDatas = new System.Windows.Forms.Label();
            this.cmbTipoGraficoProduto = new System.Windows.Forms.ComboBox();
            this.lblGrafico = new System.Windows.Forms.Label();
            this.lblDado = new System.Windows.Forms.Label();
            this.cmbDadoProduto = new System.Windows.Forms.ComboBox();
            this.chtProdutos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpVendasGerais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpVendasGerais
            // 
            this.grpVendasGerais.BackColor = System.Drawing.Color.Transparent;
            this.grpVendasGerais.Controls.Add(this.dtpDataTermino);
            this.grpVendasGerais.Controls.Add(this.lblAte);
            this.grpVendasGerais.Controls.Add(this.dtpDataInicio);
            this.grpVendasGerais.Controls.Add(this.btnAdicionar);
            this.grpVendasGerais.Controls.Add(this.btnLimpar);
            this.grpVendasGerais.Controls.Add(this.lblPeriodoDatas);
            this.grpVendasGerais.Controls.Add(this.cmbTipoGraficoProduto);
            this.grpVendasGerais.Controls.Add(this.lblGrafico);
            this.grpVendasGerais.Controls.Add(this.lblDado);
            this.grpVendasGerais.Controls.Add(this.cmbDadoProduto);
            this.grpVendasGerais.Controls.Add(this.chtProdutos);
            this.grpVendasGerais.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVendasGerais.Location = new System.Drawing.Point(7, 4);
            this.grpVendasGerais.Name = "grpVendasGerais";
            this.grpVendasGerais.Size = new System.Drawing.Size(925, 668);
            this.grpVendasGerais.TabIndex = 9;
            this.grpVendasGerais.TabStop = false;
            // 
            // dtpDataTermino
            // 
            this.dtpDataTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataTermino.Location = new System.Drawing.Point(696, 23);
            this.dtpDataTermino.Name = "dtpDataTermino";
            this.dtpDataTermino.Size = new System.Drawing.Size(220, 29);
            this.dtpDataTermino.TabIndex = 49;
            this.dtpDataTermino.ValueChanged += new System.EventHandler(this.dtpDataTermino_ValueChanged);
            // 
            // lblAte
            // 
            this.lblAte.AutoSize = true;
            this.lblAte.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblAte.Location = new System.Drawing.Point(652, 25);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(38, 25);
            this.lblAte.TabIndex = 48;
            this.lblAte.Text = "até";
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicio.Location = new System.Drawing.Point(424, 23);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(220, 29);
            this.dtpDataInicio.TabIndex = 47;
            this.dtpDataInicio.ValueChanged += new System.EventHandler(this.dtpDataInicio_ValueChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(16, 18);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(314, 40);
            this.btnAdicionar.TabIndex = 46;
            this.btnAdicionar.Text = "   Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Tomato;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(16, 63);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(314, 40);
            this.btnLimpar.TabIndex = 43;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblPeriodoDatas
            // 
            this.lblPeriodoDatas.AutoSize = true;
            this.lblPeriodoDatas.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblPeriodoDatas.Location = new System.Drawing.Point(336, 25);
            this.lblPeriodoDatas.Name = "lblPeriodoDatas";
            this.lblPeriodoDatas.Size = new System.Drawing.Size(81, 25);
            this.lblPeriodoDatas.TabIndex = 38;
            this.lblPeriodoDatas.Text = "Periodo:";
            // 
            // cmbTipoGraficoProduto
            // 
            this.cmbTipoGraficoProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTipoGraficoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoGraficoProduto.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cmbTipoGraficoProduto.FormattingEnabled = true;
            this.cmbTipoGraficoProduto.Items.AddRange(new object[] {
            "Coluna",
            "Setor"});
            this.cmbTipoGraficoProduto.Location = new System.Drawing.Point(753, 68);
            this.cmbTipoGraficoProduto.Name = "cmbTipoGraficoProduto";
            this.cmbTipoGraficoProduto.Size = new System.Drawing.Size(163, 33);
            this.cmbTipoGraficoProduto.TabIndex = 33;
            this.cmbTipoGraficoProduto.SelectedIndexChanged += new System.EventHandler(this.cmbTipoGraficoProduto_SelectedIndexChanged);
            // 
            // lblGrafico
            // 
            this.lblGrafico.AutoSize = true;
            this.lblGrafico.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblGrafico.Location = new System.Drawing.Point(670, 71);
            this.lblGrafico.Name = "lblGrafico";
            this.lblGrafico.Size = new System.Drawing.Size(77, 25);
            this.lblGrafico.TabIndex = 32;
            this.lblGrafico.Text = "Gráfico:";
            // 
            // lblDado
            // 
            this.lblDado.AutoSize = true;
            this.lblDado.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblDado.Location = new System.Drawing.Point(336, 71);
            this.lblDado.Name = "lblDado";
            this.lblDado.Size = new System.Drawing.Size(61, 25);
            this.lblDado.TabIndex = 29;
            this.lblDado.Text = "Dado:";
            // 
            // cmbDadoProduto
            // 
            this.cmbDadoProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbDadoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDadoProduto.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cmbDadoProduto.FormattingEnabled = true;
            this.cmbDadoProduto.Items.AddRange(new object[] {
            "Número de Vendas",
            "Receita Total"});
            this.cmbDadoProduto.Location = new System.Drawing.Point(403, 68);
            this.cmbDadoProduto.Name = "cmbDadoProduto";
            this.cmbDadoProduto.Size = new System.Drawing.Size(261, 33);
            this.cmbDadoProduto.TabIndex = 28;
            this.cmbDadoProduto.SelectedIndexChanged += new System.EventHandler(this.cmbDadoProduto_SelectedIndexChanged);
            // 
            // chtProdutos
            // 
            this.chtProdutos.BackColor = System.Drawing.Color.DarkCyan;
            this.chtProdutos.BorderlineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chtProdutos.ChartAreas.Add(chartArea1);
            this.chtProdutos.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chtProdutos.Legends.Add(legend1);
            this.chtProdutos.Location = new System.Drawing.Point(6, 114);
            this.chtProdutos.Name = "chtProdutos";
            this.chtProdutos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            series1.IsValueShownAsLabel = true;
            series1.LabelAngle = 1;
            series1.LabelForeColor = System.Drawing.Color.MediumBlue;
            series1.Legend = "Legend1";
            series1.MarkerBorderWidth = 2;
            series1.Name = "Número de Vendas";
            series1.SmartLabelStyle.MaxMovingDistance = 20D;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValuesPerPoint = 2;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.ChartArea = "ChartArea1";
            series2.Enabled = false;
            series2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.MediumBlue;
            series2.Legend = "Legend1";
            series2.Name = "Receita Total";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series2.YValuesPerPoint = 2;
            this.chtProdutos.Series.Add(series1);
            this.chtProdutos.Series.Add(series2);
            this.chtProdutos.Size = new System.Drawing.Size(910, 547);
            this.chtProdutos.TabIndex = 27;
            this.chtProdutos.Text = "chtVendasPor";
            // 
            // frmVendasProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(938, 676);
            this.Controls.Add(this.grpVendasGerais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVendasProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVendasProdutos";
            this.Load += new System.EventHandler(this.frmVendasProdutos_Load);
            this.grpVendasGerais.ResumeLayout(false);
            this.grpVendasGerais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpVendasGerais;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblPeriodoDatas;
        private System.Windows.Forms.ComboBox cmbTipoGraficoProduto;
        private System.Windows.Forms.Label lblGrafico;
        private System.Windows.Forms.Label lblDado;
        private System.Windows.Forms.ComboBox cmbDadoProduto;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtProdutos;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.DateTimePicker dtpDataTermino;
    }
}