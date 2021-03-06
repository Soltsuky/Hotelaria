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

        private void novoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos.FrmProdutos form = new Produtos.FrmProdutos();
            form.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos.FrmEstoque form = new Produtos.FrmEstoque();
            form.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.FrmFornecedores form = new Cadastros.FrmFornecedores();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produtos.FrmProdutos form = new Produtos.FrmProdutos();
            form.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Relatorios.frmRelProdutos form = new Relatorios.frmRelProdutos();
            form.Show();
        }

        private void novaVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movimentacoes.frmVendas form = new Movimentacoes.frmVendas();
            form.Show();
        }

        private void entradaESaídasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movimentacoes.FrmMovimentacoes form = new Movimentacoes.FrmMovimentacoes();
            form.Show();
        }

        private void gastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movimentacoes.FrmGastos form = new Movimentacoes.FrmGastos();
            form.Show();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movimentacoes.FrmHospedes form = new Movimentacoes.FrmHospedes();
            form.Show();
        }

        private void quartosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movimentacoes.FrmQuartos form = new Movimentacoes.FrmQuartos();
            form.Show();
        }

        private void novaServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movimentacoes.FrmNovoServics form = new Movimentacoes.FrmNovoServics();
            form.Show();
        }

        private void relatórioDeServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.frmRelServicos form = new Relatorios.frmRelServicos();
            form.Show();
        }

        private void relatórioDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.frmRelVendas form = new Relatorios.frmRelVendas();
            form.Show();
        }

        private void relatirioDeEntradaSaídaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.frmRelMovimentacoes form = new Relatorios.frmRelMovimentacoes();
            form.Show();
        }

        private void relatórioDeMovimentaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.frmMovimentacoesGerais form = new Relatorios.frmMovimentacoesGerais();
            form.Show();
        }

        private void novaReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          Cadastros.FrmReservas form = new Cadastros.FrmReservas();
          form.Show();
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.FrmCheckIn form = new Cadastros.FrmCheckIn();
            form.Show();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.FrmCheckOut form = new Cadastros.FrmCheckOut();
            form.Show();
        }

        private void consultarReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.FrmConsultarReservas form = new Cadastros.FrmConsultarReservas();
            form.Show();
        }
    }
}
