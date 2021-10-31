using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Hotelaria.Cadastros
{
    public partial class frmCargo : Form
    {

        Classes.conexao con = new Classes.conexao();
        string sql;
        SqlCommand cmd;
        string id;
        public frmCargo()
        {
            InitializeComponent();
        }


        private void FormatarDG()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Cargo";

            grid.Columns[0].Visible = false;

            grid.Columns[1].Width = 400;

        }

        private void listar()
        {
            
            con.AbrirCon();
            sql = "SELECT * FROM Cargos order by cargo asc";
            cmd = new SqlCommand(sql, con.con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharCon();

            FormatarDG();

        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnDeletar.Enabled = false;
            txtNome.Focus();
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

            // Codigo para salvar
            con.AbrirCon();
            sql = "INSERT INTO Cargos (cargo) VALUES (@cargo)";         
            cmd = new SqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@cargo", txtNome.Text);
            cmd.ExecuteNonQuery();
            con.FecharCon();

            MessageBox.Show("Registro Salvo com Sucesso!");
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            txtNome.Text = "";
            txtNome.Enabled = false;
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

            // Codigo para editar

            con.AbrirCon();
            sql = "UPDATE Cargos SET cargo = @cargo where id = @id";
            cmd = new SqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@cargo", txtNome.Text);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.FecharCon();



            MessageBox.Show("Registro Editado com Sucesso!");
            btnEditar.Enabled = false;
            btnDeletar.Enabled = false;
            txtNome.Text = "";
            txtNome.Enabled = false;
            listar();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
           var resultado = MessageBox.Show("Tem certeza que quer Excluir o Registro", "Excluir Registro",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
           
           if(resultado == DialogResult.Yes)
            {

                //Codigo de excluir

                con.AbrirCon();
                sql = "DELETE FROM Cargos where id = @id";
                cmd = new SqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.FecharCon();

                MessageBox.Show("Registro Excluido!");
                btnNovo.Enabled = true;
                btnEditar.Enabled = false;
                btnDeletar.Enabled = false;
                txtNome.Text = "";
                txtNome.Enabled = false;
                listar();
            }
        
        }

        private void frmCargo_Load(object sender, EventArgs e)
        {
            listar();
        }


        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnDeletar.Enabled = true;
            btnSalvar.Enabled = false;
            txtNome.Enabled = true;

            id = grid.CurrentRow.Cells[0].Value.ToString(); 
            txtNome.Text = grid.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
