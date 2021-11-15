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
    public partial class frmRelComprovanteServico : Form
    {
        public frmRelComprovanteServico()
        {
            InitializeComponent();
        }

        private void frmRelComprovanteServico_Load(object sender, EventArgs e)
        {

            this.comprovanteServicoTableAdapter.Fill(this.hotelDataSet.comprovanteServico, Convert.ToInt32(Program.idNovoServico));

            this.reportViewer1.RefreshReport();
        }
    }
}
