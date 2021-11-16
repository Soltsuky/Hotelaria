
namespace Hotelaria.Relatorios
{
    partial class frmRelMovimentacoes
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.movimentacoesPorDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new Hotelaria.HotelDataSet();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.movimentacoesPorDataTableAdapter = new Hotelaria.HotelDataSetTableAdapters.movimentacoesPorDataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.movimentacoesPorDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // movimentacoesPorDataBindingSource
            // 
            this.movimentacoesPorDataBindingSource.DataMember = "movimentacoesPorData";
            this.movimentacoesPorDataBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Entrada",
            "Saída"});
            this.cbTipo.Location = new System.Drawing.Point(59, 12);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbTipo.TabIndex = 125;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 124;
            this.label2.Text = "Tipo:";
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(521, 14);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(85, 20);
            this.dtFinal.TabIndex = 123;
            this.dtFinal.ValueChanged += new System.EventHandler(this.dtFinal_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 122;
            this.label1.Text = "Data Final:";
            // 
            // dtInicial
            // 
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(366, 14);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(85, 20);
            this.dtInicial.TabIndex = 121;
            this.dtInicial.ValueChanged += new System.EventHandler(this.dtInicial_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 120;
            this.label3.Text = "Data Inicial:";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DSMovimentacoes";
            reportDataSource1.Value = this.movimentacoesPorDataBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hotelaria.Relatorios.RelMovimentacoes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 40);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(640, 596);
            this.reportViewer1.TabIndex = 126;
            // 
            // movimentacoesPorDataTableAdapter
            // 
            this.movimentacoesPorDataTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelMovimentacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 637);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtFinal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtInicial);
            this.Controls.Add(this.label3);
            this.Name = "frmRelMovimentacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimentacões De Entrada e Saída";
            this.Load += new System.EventHandler(this.frmRelMovimentacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movimentacoesPorDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Windows.Forms.Label label3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource movimentacoesPorDataBindingSource;
        private HotelDataSet hotelDataSet;
        private HotelDataSetTableAdapters.movimentacoesPorDataTableAdapter movimentacoesPorDataTableAdapter;
    }
}