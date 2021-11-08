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
    public partial class frmRelProdutos : Form
    {
        public frmRelProdutos()
        {
            InitializeComponent();
        }

        private void frmRelProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'hotelDataSet.Prod_Forn'. Você pode movê-la ou removê-la conforme necessário.
            this.prod_FornTableAdapter.Fill(this.hotelDataSet.Prod_Forn);
            // TODO: esta linha de código carrega dados na tabela 'hotelDataSet.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.hotelDataSet.produtos);

            this.reportViewer1.RefreshReport();
        }
    }
}
