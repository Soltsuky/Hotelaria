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
    public partial class frmRelServicos : Form
    {
        public frmRelServicos()
        {
            InitializeComponent();
        }

        private void frmRelServicos_Load(object sender, EventArgs e)
        {

            dtInicial.Value = DateTime.Today;
            dtFinal.Value = DateTime.Today;
            BuscarPorData();
        }
        private void BuscarPorData()
        {
            this.servicoPorDataTableAdapter.Fill(this.hotelDataSet.servicoPorData, Convert.ToString(dtInicial.Text), Convert.ToString(dtFinal.Text));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataInicial", dtInicial.Text));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataFinal", dtFinal.Text));
            this.reportViewer1.RefreshReport();
        }

        private void dtInicial_ValueChanged(object sender, EventArgs e)
        {
            BuscarPorData();
        }

        private void dtFinal_ValueChanged(object sender, EventArgs e)
        {
            BuscarPorData();
        }
    }
}
