using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelaria.Cadastros
{
    public partial class frmUsuario : Form
    {
        Classes.conexao con = new Classes.conexao();
        string sql;
        SqlCommand cmd;
        string id;


        public frmUsuario()
        {
            InitializeComponent();
        }

        private void listar()
        {

            con.AbrirCon();
            sql = "SELECT * FROM usuarios order by nome asc";
            cmd = new SqlCommand(sql, con.con);
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
            grid.Columns[2].HeaderText = "Cargo";
            grid.Columns[3].HeaderText = "Usuário";
            grid.Columns[4].HeaderText = "Senha";
            grid.Columns[5].HeaderText = "Data";


            grid.Columns[0].Visible = false;

            grid.Columns[1].Width = 200;

        }

        private void BuscarNome()
        {

            con.AbrirCon();
            sql = "SELECT * FROM usuarios where nome LIKE @nome order by nome asc";
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
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
            cbCargo.Enabled = true;
            
        }
        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtUsuario.Enabled = false;
            txtSenha.Enabled = false;
            cbCargo.Enabled = false;

        }

        private void limparCampos()
        {
            txtNome.Text = "";
            txtUsuario.Text = "";
            txtSenha.Text = "";
        }
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            listar();
            LoadComboBox();

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (cbCargo.Text == "")
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
                txtNome.Focus();
                return;

            }
            if (cbCargo.Text.ToString().Trim() == "")
            {

                MessageBox.Show("Preencha o Cargo!");
                cbCargo.Focus();
                return;

            }
            if (txtUsuario.Text.ToString().Trim() == "")
            {

                MessageBox.Show("Preencha o Usuário!");
                txtUsuario.Focus();
                return;

            }
            if (txtSenha.Text.ToString().Trim() == "")
            {

                MessageBox.Show("Preencha a Senha!");
                txtSenha.Focus();
                return;

            }

            // Codigo para salvar

            con.AbrirCon();
            sql = "INSERT INTO usuarios (nome, cargo, usuario, senha, data) VALUES (@nome, @cargo, @usuario, @senha, GETDATE())";
            cmd = new SqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@cargo", cbCargo.Text);
            cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@senha", txtSenha.Text);

            // Verificar se já existe o usuario no banco

            SqlCommand cmdVerificacao;

            cmdVerificacao = new SqlCommand("SELECT * FROM usuarios where usuario = @usuario", con.con);
            cmdVerificacao.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmdVerificacao;
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Usuario já Registrado!", "Dados Não Salvo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Text = "";
                txtUsuario.Focus();
                return;
            }

            cmd.ExecuteNonQuery();
            con.FecharCon();

            MessageBox.Show("Registro Salvo com Sucesso!");
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            limparCampos();
            desabilitarCampos();
            listar();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnDeletar.Enabled = true;
            btnSalvar.Enabled = false;
            habilitarCampos();

            id = grid.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = grid.CurrentRow.Cells[1].Value.ToString();
            cbCargo.Text = grid.CurrentRow.Cells[2].Value.ToString();
            txtUsuario.Text = grid.CurrentRow.Cells[3].Value.ToString();
            txtSenha.Text = grid.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {

                MessageBox.Show("Preencha o Nome!");
                txtNome.Focus();
                return;

            }
            if (cbCargo.Text.ToString().Trim() == "")
            {

                MessageBox.Show("Preencha o Cargo!");
                cbCargo.Focus();
                return;

            }
            if (txtUsuario.Text.ToString().Trim() == "")
            {

                MessageBox.Show("Preencha o Usuário!");
                txtUsuario.Focus();
                return;

            }
            if (txtSenha.Text.ToString().Trim() == "")
            {

                MessageBox.Show("Preencha a Senha!");
                txtSenha.Focus();
                return;

            }

            // Codigo para editar
            con.AbrirCon();
            sql = "UPDATE usuario SET nome = @nome, cargo = @cargo, usuario = @usuario, senha = @senha, where id = @id";
            cmd = new SqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@cargo", cbCargo.Text);
            cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
            cmd.Parameters.AddWithValue("@id", id);

            SqlCommand cmdVerificacao;

            cmdVerificacao = new SqlCommand("SELECT * FROM usuarios where usuario = @usuario", con.con);
            cmdVerificacao.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmdVerificacao;
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Usuario já Registrado!", "Dados Não Salvo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Text = "";
                txtUsuario.Focus();
                return;
            }

            cmd.ExecuteNonQuery();
            con.FecharCon();

            MessageBox.Show("Registro Editado com Sucesso!");
            btnEditar.Enabled = false;
            btnDeletar.Enabled = false;
            limparCampos();
            desabilitarCampos();
            listar();
        }
    }
}
