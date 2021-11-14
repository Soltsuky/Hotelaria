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
    public partial class frmRelComprovante : Form
    {
        public frmRelComprovante()
        {
            InitializeComponent();
        }

        private void frmRelComprovante_Load(object sender, EventArgs e)
        {

            

            this.vendaPorIDTableAdapter.Fill(this.hotelDataSet.vendaPorID, Convert.ToInt32(Program.idVenda));
            this.detalhes_venda_IDTableAdapter.Fill(this.hotelDataSet.detalhes_venda_ID, Convert.ToInt32(Program.idVenda));
            this.reportViewer1.RefreshReport();
        }
    }
}
