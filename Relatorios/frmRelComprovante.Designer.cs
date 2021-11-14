
namespace Hotelaria.Relatorios
{
    partial class frmRelComprovante
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.hotelDataSet = new Hotelaria.HotelDataSet();
            this.vendaPorIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendaPorIDTableAdapter = new Hotelaria.HotelDataSetTableAdapters.vendaPorIDTableAdapter();
            this.detalhesvendaIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalhes_venda_IDTableAdapter = new Hotelaria.HotelDataSetTableAdapters.detalhes_venda_IDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaPorIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalhesvendaIDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSVendas";
            reportDataSource1.Value = this.vendaPorIDBindingSource;
            reportDataSource2.Name = "DSDetalhesVendas";
            reportDataSource2.Value = this.detalhesvendaIDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hotelaria.Relatorios.RelComprovante.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(643, 619);
            this.reportViewer1.TabIndex = 0;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendaPorIDBindingSource
            // 
            this.vendaPorIDBindingSource.DataMember = "vendaPorID";
            this.vendaPorIDBindingSource.DataSource = this.hotelDataSet;
            // 
            // vendaPorIDTableAdapter
            // 
            this.vendaPorIDTableAdapter.ClearBeforeFill = true;
            // 
            // detalhesvendaIDBindingSource
            // 
            this.detalhesvendaIDBindingSource.DataMember = "detalhes_venda_ID";
            this.detalhesvendaIDBindingSource.DataSource = this.hotelDataSet;
            // 
            // detalhes_venda_IDTableAdapter
            // 
            this.detalhes_venda_IDTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelComprovante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 619);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelComprovante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprovante de Venda";
            this.Load += new System.EventHandler(this.frmRelComprovante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaPorIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalhesvendaIDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vendaPorIDBindingSource;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource detalhesvendaIDBindingSource;
        private HotelDataSetTableAdapters.vendaPorIDTableAdapter vendaPorIDTableAdapter;
        private HotelDataSetTableAdapters.detalhes_venda_IDTableAdapter detalhes_venda_IDTableAdapter;
    }
}