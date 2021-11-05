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

        Classes.conexao con = new Classes.conexao();
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            pnlTop.BackColor = Color.FromArgb(213, 213, 213);


            lblUsuario.Text = Program.nomeUsuario;
            lblCargo.Text = Program.cargoUsuario;
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

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.frmUsuario form = new Cadastros.frmUsuario();
            form.Show();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin();
            this.Close();
            // Limpar();
            form.Show();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.frmServicos form = new Cadastros.frmServicos();
            form.Show();

        }
    }
}
