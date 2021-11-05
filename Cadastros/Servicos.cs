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
    public partial class frmServicos : Form
    {

        Classes.conexao con = new Classes.conexao();
        string sql;
        SqlCommand cmd;
        string id;

        public frmServicos()
        {
            InitializeComponent();
        }

        private void listar()
        {

            con.AbrirCon();
            sql = "SELECT * FROM servicos order by nome asc";
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
            grid.Columns[1].HeaderText = "Serviço";
            grid.Columns[2].HeaderText = "Valor";



            grid.Columns[0].Visible = false;

            grid.Columns[2].DefaultCellStyle.Format = "C2";

            grid.Columns[1].Width = 200;

        }

        private void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtValor.Enabled = true;


        }
        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtValor.Enabled = false;


        }

        private void limparCampos()
        {
            txtNome.Text = "";
            txtValor.Text = "";
        }

        private void frmServicos_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            limparCampos();
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
            

            // Codigo para salvar

            con.AbrirCon();
            sql = "INSERT INTO servicos (nome, valor) VALUES (@nome, @valor)";
            cmd = new SqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@valor", txtValor.Text.Replace(",", "."));

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
            txtValor.Text = grid.CurrentRow.Cells[2].Value.ToString();



        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {

                MessageBox.Show("Preencha o Nome!");
                txtNome.Focus();
                return;

            }
           

            // Codigo para editar
            con.AbrirCon();
            sql = "UPDATE servicos SET nome = @nome, valor = @valor where id = @id";
            cmd = new SqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@valor", txtValor.Text.Replace(",", "."));
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
                sql = "DELETE FROM servicos where id = @id";
                cmd = new SqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.FecharCon();

                MessageBox.Show("Registro Excluido!");
                btnNovo.Enabled = true;
                btnEditar.Enabled = false;
                btnDeletar.Enabled = false;
                limparCampos();
                desabilitarCampos();
                listar();
            }
        }
    }
}
