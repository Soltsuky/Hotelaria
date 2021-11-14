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
    public partial class frmRelVendas : Form
    {
        public frmRelVendas()
        {
            InitializeComponent();
        }

        private void frmRelVendas_Load(object sender, EventArgs e)
        {



            dtInicial.Value = DateTime.Today;
            dtFinal.Value = DateTime.Today;
            cbStatus.SelectedIndex = 0;
            BuscarData();

        }

        private void BuscarData()
        {

          //  this.vendasPorDataTableAdapter.Fill(this.hotelDataSet.vendasPorData, Convert.ToDateTime(dtInicial.Text), Convert.ToDateTime(dtFinal.Text), cbStatus.Text);

          //  this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataInicial", dtInicial.Text));
          //  this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataFinal", dtFinal.Text));


            this.reportViewer1.RefreshReport();
        }



    }
}
