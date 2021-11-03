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

namespace Hotelaria
{

    public partial class FormLogin : Form
    {

        Classes.conexao con = new Classes.conexao();
        string sql;
        SqlCommand cmd;
        string id;
        public FormLogin()
        {
            InitializeComponent();
        }

    private void entrarSistema()
        {

            //Verificação de login
            if (txtLogin.Text.ToString().Trim() == "")
            {

                MessageBox.Show("O USUÁRIO Não pode esta em branco");
                txtLogin.Text = "";
                txtLogin.Focus();
                return;

            }
            if (txtSenha.Text.ToString().Trim() == "")
            {

                MessageBox.Show("A SENHA Não pode esta em branco");
                txtSenha.Text = "";
                txtSenha.Focus();
                return;

            }

            //Código de login

            con.AbrirCon();
            SqlCommand cmdVerificacao;
            SqlDataReader reader;

            cmdVerificacao = new SqlCommand("SELECT * FROM usuarios where usuario = @usuario and senha = @senha", con.con);
            cmdVerificacao.Parameters.AddWithValue("@usuario", txtLogin.Text);
            cmdVerificacao.Parameters.AddWithValue("@senha", txtSenha.Text);
            reader = cmdVerificacao.ExecuteReader();



            if (reader.HasRows)
            {

                //Extraindo informações do reader
                while (reader.Read())
                {

                    con.nomeUsuario = Convert.ToString(reader["nome"]);
                    con.cargoUsuario = Convert.ToString(reader["cargo"]);

                  //  MessageBox.Show(con.nomeUsuario);

                }

             //   MessageBox.Show("Bem Vindo!" + con.nomeUsuario, "Login Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMenu form = new frmMenu();
                this.Hide();
                // Limpar();
                form.Show();
                
            }
            else
            {
                MessageBox.Show("Erro ao Logar", "Dados Incorretos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Text = "";
                txtLogin.Focus();
                txtSenha.Text = "";
                
            }

            con.FecharCon();


        }

        private void Limpar()
        {
            txtLogin.Text = "";
            txtSenha.Text = "";
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

            pnlLogin.Location = new Point(this.Width / 2 -129 , this.Height / 2 -138); 

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            entrarSistema();

        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            
            if(e.KeyCode == Keys.Enter)
            {
                entrarSistema();
            }



        }
    }
}
