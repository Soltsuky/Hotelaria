using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hotelaria
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            pnlTop.BackColor = Color.FromArgb(213, 213, 213);
        }

        private void funcionáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.frmFuncionarios form = new Cadastros.frmFuncionarios();
            form.Show();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.frmCargo form = new Cadastros.frmCargo();
            form.Show();
        }
    }
}
