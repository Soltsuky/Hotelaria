using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelaria.Relatorios
{
    public partial class frmRelMovimentacoes : Form
    {
        public frmRelMovimentacoes()
        {
            InitializeComponent();
        }

        private void frmRelMovimentacoes_Load(object sender, EventArgs e)
        {
            dtInicial.Value = DateTime.Today;
            dtFinal.Value = DateTime.Today;
            cbTipo.SelectedIndex = 0;
            BuscarData();

        }

        private void BuscarData()
        {

            this.movimentacoesPorDataTableAdapter.Fill(this.hotelDataSet.movimentacoesPorData, Convert.ToString(dtInicial.Text), Convert.ToString(dtFinal.Text), cbTipo.Text);

            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataInicial", dtInicial.Text));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataFinal", dtFinal.Text));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("tipo", cbTipo.Text));


            this.reportViewer1.RefreshReport();
        }

        private void dtInicial_ValueChanged(object sender, EventArgs e)
        {
            BuscarData();
        }

        private void dtFinal_ValueChanged(object sender, EventArgs e)
        {
            BuscarData();
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarData();
        }
    }
}
