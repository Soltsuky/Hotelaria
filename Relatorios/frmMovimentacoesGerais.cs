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
    public partial class frmMovimentacoesGerais : Form
    {
        public frmMovimentacoesGerais()
        {
            InitializeComponent();
        }

        private void frmMovimentacoesGerais_Load(object sender, EventArgs e)
        {

            dtInicial.Value = DateTime.Today;
            dtFinal.Value = DateTime.Today;
            BuscarData();
        }

        private void BuscarData()
        {

            this.movimentacoesGeraisTableAdapter.Fill(this.hotelDataSet.movimentacoesGerais, Convert.ToString(dtInicial.Text), Convert.ToString(dtFinal.Text));

            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataInicial", dtInicial.Text));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataFinal", dtFinal.Text));


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
    }
}
