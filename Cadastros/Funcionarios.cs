using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hotelaria.Cadastros
{
    public partial class frmFuncionarios : Form
    {

        Classes.conexao con = new Classes.conexao();
        string sql;
        SqlCommand cmd;
        string id;

        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void listar()
        {

            con.AbrirCon();
            sql = "SELECT * FROM funcionarios order by nome asc";
            cmd = new SqlCommand(sql, con.con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharCon();

            FormatarDG();

        }

        private void BuscarNome()
        {

            con.AbrirCon();
            sql = "SELECT * FROM funcionarios where nome LIKE @nome order by nome asc";
            cmd = new SqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txtBuscarNome.Text + "%");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharCon();

            FormatarDG();

        }

        private void BuscarCPF()
        {

            con.AbrirCon();
            sql = "SELECT * FROM funcionarios where cpf = @cpf order by nome asc";
            cmd = new SqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@cpf", txtBuscarCPF.Text);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharCon();

            FormatarDG();

        }


        private void FormatarDG()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Nome";
            grid.Columns[2].HeaderText = "CPF";
            grid.Columns[3].HeaderText = "Endereço";
            grid.Columns[4].HeaderText = "Telefone";
            grid.Columns[5].HeaderText = "Cargo";
            grid.Columns[6].HeaderText = "Data";

            grid.Columns[0].Visible = false;

            grid.Columns[1].Width = 200;

        }

        private void LoadComboBox()
        {
            con.AbrirCon();
            sql = "SELECT * FROM Cargos order by cargo asc";
            cmd = new SqlCommand(sql, con.con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbCargo.DataSource = dt;
            //cbCargo.ValueMember = "id";
            cbCargo.DisplayMember = "cargo";
            con.FecharCon();
        }

        private void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtCPF.Enabled = true;
            txtEndereco.Enabled = true;
            cbCargo.Enabled = true;
            txtTelefone.Enabled = true;
        }
        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtCPF.Enabled = false;
            txtEndereco.Enabled = false;
            cbCargo.Enabled = false;
            txtTelefone.Enabled = false;
        }

        private void limparCampos()
        {
            txtNome.Text = "";
            txtCPF.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
        }


        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            rbNome.Checked = true;
            LoadComboBox();
            listar();


        }

        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscarNome.Visible = true;
            txtBuscarCPF.Visible = false;

            txtBuscarNome.Text = "";
            txtBuscarCPF.Text = "";
        }

        private void rbCPF_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscarNome.Visible = false;
            txtBuscarCPF.Visible = true;

            txtBuscarNome.Text = "";
            txtBuscarCPF.Text = "";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

            if(cbCargo.Text == "")
            {
                MessageBox.Show("Cadastre um Cargo antes!");
                this.Close();
            }
            habilitarCampos();
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnDeletar.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {

                MessageBox.Show("Preencha o Nome!");
                txtNome.Text = "";
                txtNome.Focus();
                return;

            }
            if (txtCPF.Text == "   .   .   -")
            {

                MessageBox.Show("Preencha o CPF!");
                txtCPF.Focus();
                return;

            }

            // Codigo para salvar

            con.AbrirCon();
            sql = "INSERT INTO funcionarios (nome, cpf, endereco, telefone, cargo, data) VALUES (@nome, @cpf, @endereco, @telefone, @cargo, GETDATE())";
            cmd = new SqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
            cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
            cmd.Parameters.AddWithValue("@cargo", cbCargo.Text);

            //Verificar se o CPF já existe

            SqlCommand cmdVerificacao;

            cmdVerificacao = new SqlCommand("SELECT * FROM funcionarios where cpf = @cpf", con.con);
            cmdVerificacao.Parameters.AddWithValue("@cpf", txtCPF.Text);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmdVerificacao;
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("CPF já Registrado!", "CPF Não Salvo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCPF.Text = "";
                txtCPF.Focus();
                return;
            }

            cmd.ExecuteNonQuery();
            con.FecharCon();
            listar();

            MessageBox.Show("Registro Salvo com Sucesso!");
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            limparCampos();
            desabilitarCampos();
            listar();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {

                MessageBox.Show("Preencha o Nome!");
                txtNome.Text = "";
                txtNome.Focus();
                return;

            }
            if (txtCPF.Text == "   .   .   -")
            {

                MessageBox.Show("Preencha o CPF!");
                txtCPF.Focus();
                return;

            }

            // Codigo para editar
            con.AbrirCon();
            sql = "UPDATE funcionarios SET nome = @nome, cpf = @cpf, endereco = @endereco, telefone = @telefone, cargo = @cargo where id = @id";
            cmd = new SqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
            cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
            cmd.Parameters.AddWithValue("@cargo", cbCargo.Text);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.FecharCon();

            MessageBox.Show("Registro Editado com Sucesso!");
            btnEditar.Enabled = false;
            btnDeletar.Enabled = false;
            limparCampos();
            desabilitarCampos();
            listar();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem certeza que quer Excluir o Registro", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {

                //Codigo de excluir
                con.AbrirCon();
                sql = "DELETE FROM funcionarios where id = @id";
                cmd = new SqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.FecharCon();

                MessageBox.Show("Registro Excluido!");
                btnNovo.Enabled = true;
                btnEditar.Enabled = false;
                btnDeletar.Enabled = false;
                limparCampos();
                txtNome.Enabled = false;
                listar();
            }
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            btnEditar.Enabled = true;
            btnDeletar.Enabled = true;
            btnSalvar.Enabled = false;
            habilitarCampos();

            id = grid.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = grid.CurrentRow.Cells[1].Value.ToString();
            txtCPF.Text = grid.CurrentRow.Cells[2].Value.ToString();
            txtEndereco.Text = grid.CurrentRow.Cells[3].Value.ToString();
            txtTelefone.Text = grid.CurrentRow.Cells[4].Value.ToString();
            cbCargo.Text = grid.CurrentRow.Cells[5].Value.ToString();


        }

        private void txtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            BuscarNome();
        }


        private void txtBuscarCPF_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarCPF.Text == "   .   .   -")
            {
                listar();
            }
            else
            {
                BuscarCPF();
            }
            
        }
    }
}
