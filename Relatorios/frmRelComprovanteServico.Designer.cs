
namespace Hotelaria.Relatorios
{
    partial class frmRelComprovanteServico
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.hotelDataSet = new Hotelaria.HotelDataSet();
            this.comprovanteServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comprovanteServicoTableAdapter = new Hotelaria.HotelDataSetTableAdapters.comprovanteServicoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprovanteServicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSComprovanteServico";
            reportDataSource1.Value = this.comprovanteServicoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hotelaria.Relatorios.RelComprovanteServico.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(614, 600);
            this.reportViewer1.TabIndex = 0;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comprovanteServicoBindingSource
            // 
            this.comprovanteServicoBindingSource.DataMember = "comprovanteServico";
            this.comprovanteServicoBindingSource.DataSource = this.hotelDataSet;
            // 
            // comprovanteServicoTableAdapter
            // 
            this.comprovanteServicoTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelComprovanteServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 600);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelComprovanteServico";
            this.Text = "frmRelComprovanteServico";
            this.Load += new System.EventHandler(this.frmRelComprovanteServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprovanteServicoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource comprovanteServicoBindingSource;
        private HotelDataSet hotelDataSet;
        private HotelDataSetTableAdapters.comprovanteServicoTableAdapter comprovanteServicoTableAdapter;
    }
}