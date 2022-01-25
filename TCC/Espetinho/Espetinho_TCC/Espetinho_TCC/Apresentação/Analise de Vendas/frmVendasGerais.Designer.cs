namespace Espetinho_TCC.Apresentação.Analise_de_Vendas
{
    partial class frmVendasGerais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendasGerais));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grpVendasGerais = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblPeriodoDatas = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.cmbTipoGraficoVendas = new System.Windows.Forms.ComboBox();
            this.lblGrafico = new System.Windows.Forms.Label();
            this.lblDado = new System.Windows.Forms.Label();
            this.cmbDadoVendasGerais = new System.Windows.Forms.ComboBox();
            this.chtVendas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbAno = new System.Windows.Forms.ComboBox();
            this.cmbMeses = new System.Windows.Forms.ComboBox();
            this.grpVendasGerais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // grpVendasGerais
            // 
            this.grpVendasGerais.BackColor = System.Drawing.Color.Transparent;
            this.grpVendasGerais.Controls.Add(this.btnLimpar);
            this.grpVendasGerais.Controls.Add(this.lblPeriodoDatas);
            this.grpVendasGerais.Controls.Add(this.lblPeriodo);
            this.grpVendasGerais.Controls.Add(this.cmbPeriodo);
            this.grpVendasGerais.Controls.Add(this.cmbTipoGraficoVendas);
            this.grpVendasGerais.Controls.Add(this.lblGrafico);
            this.grpVendasGerais.Controls.Add(this.lblDado);
            this.grpVendasGerais.Controls.Add(this.cmbDadoVendasGerais);
            this.grpVendasGerais.Controls.Add(this.chtVendas);
            this.grpVendasGerais.Controls.Add(this.cmbAno);
            this.grpVendasGerais.Controls.Add(this.cmbMeses);
            this.grpVendasGerais.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVendasGerais.Location = new System.Drawing.Point(7, 3);
            this.grpVendasGerais.Name = "grpVendasGerais";
            this.grpVendasGerais.Size = new System.Drawing.Size(925, 668);
            this.grpVendasGerais.TabIndex = 8;
            this.grpVendasGerais.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Tomato;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(11, 64);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(319, 40);
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
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblPeriodo.Location = new System.Drawing.Point(6, 25);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(81, 25);
            this.lblPeriodo.TabIndex = 35;
            this.lblPeriodo.Text = "Periodo:";
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Items.AddRange(new object[] {
            "Mês",
            "Ano"});
            this.cmbPeriodo.Location = new System.Drawing.Point(93, 22);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(237, 33);
            this.cmbPeriodo.TabIndex = 34;
            this.cmbPeriodo.SelectedIndexChanged += new System.EventHandler(this.cmbPeriodo_SelectedIndexChanged);
            // 
            // cmbTipoGraficoVendas
            // 
            this.cmbTipoGraficoVendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTipoGraficoVendas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoGraficoVendas.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cmbTipoGraficoVendas.FormattingEnabled = true;
            this.cmbTipoGraficoVendas.Items.AddRange(new object[] {
            "Coluna",
            "Linha"});
            this.cmbTipoGraficoVendas.Location = new System.Drawing.Point(753, 68);
            this.cmbTipoGraficoVendas.Name = "cmbTipoGraficoVendas";
            this.cmbTipoGraficoVendas.Size = new System.Drawing.Size(163, 33);
            this.cmbTipoGraficoVendas.TabIndex = 33;
            this.cmbTipoGraficoVendas.SelectedIndexChanged += new System.EventHandler(this.cmbTipoGraficoVendas_SelectedIndexChanged);
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
            // cmbDadoVendasGerais
            // 
            this.cmbDadoVendasGerais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbDadoVendasGerais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDadoVendasGerais.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cmbDadoVendasGerais.FormattingEnabled = true;
            this.cmbDadoVendasGerais.Items.AddRange(new object[] {
            "Número de Vendas",
            "Receita Total"});
            this.cmbDadoVendasGerais.Location = new System.Drawing.Point(403, 68);
            this.cmbDadoVendasGerais.Name = "cmbDadoVendasGerais";
            this.cmbDadoVendasGerais.Size = new System.Drawing.Size(261, 33);
            this.cmbDadoVendasGerais.TabIndex = 28;
            this.cmbDadoVendasGerais.SelectedIndexChanged += new System.EventHandler(this.cmbDadoVendasGerais_SelectedIndexChanged);
            // 
            // chtVendas
            // 
            this.chtVendas.BackColor = System.Drawing.Color.DarkCyan;
            this.chtVendas.BorderlineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chtVendas.ChartAreas.Add(chartArea1);
            this.chtVendas.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chtVendas.Legends.Add(legend1);
            this.chtVendas.Location = new System.Drawing.Point(6, 114);
            this.chtVendas.Name = "chtVendas";
            this.chtVendas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
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
            series2.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.MediumBlue;
            series2.Legend = "Legend1";
            series2.Name = "Receita Total";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series2.YValuesPerPoint = 2;
            this.chtVendas.Series.Add(series1);
            this.chtVendas.Series.Add(series2);
            this.chtVendas.Size = new System.Drawing.Size(910, 547);
            this.chtVendas.TabIndex = 27;
            this.chtVendas.Text = "chtVendasPor";
            // 
            // cmbAno
            // 
            this.cmbAno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAno.Enabled = false;
            this.cmbAno.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cmbAno.FormattingEnabled = true;
            this.cmbAno.Location = new System.Drawing.Point(425, 22);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(491, 33);
            this.cmbAno.TabIndex = 44;
            this.cmbAno.SelectedIndexChanged += new System.EventHandler(this.cmbAno_SelectedIndexChanged);
            // 
            // cmbMeses
            // 
            this.cmbMeses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeses.Enabled = false;
            this.cmbMeses.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cmbMeses.FormattingEnabled = true;
            this.cmbMeses.Items.AddRange(new object[] {
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
            this.cmbMeses.Location = new System.Drawing.Point(425, 22);
            this.cmbMeses.Name = "cmbMeses";
            this.cmbMeses.Size = new System.Drawing.Size(491, 33);
            this.cmbMeses.TabIndex = 45;
            this.cmbMeses.SelectedIndexChanged += new System.EventHandler(this.cmbMeses_SelectedIndexChanged);
            // 
            // frmVendasGerais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(938, 676);
            this.Controls.Add(this.grpVendasGerais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVendasGerais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVendasGerais";
            this.Load += new System.EventHandler(this.frmVendasGerais_Load);
            this.grpVendasGerais.ResumeLayout(false);
            this.grpVendasGerais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtVendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpVendasGerais;
        private System.Windows.Forms.ComboBox cmbTipoGraficoVendas;
        private System.Windows.Forms.Label lblGrafico;
        private System.Windows.Forms.Label lblDado;
        private System.Windows.Forms.ComboBox cmbDadoVendasGerais;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtVendas;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.Label lblPeriodoDatas;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cmbAno;
        private System.Windows.Forms.ComboBox cmbMeses;
    }
}