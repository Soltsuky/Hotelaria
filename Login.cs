using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelaria
{
    public partial class FormLogin : Form
    {
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

            frmMenu form = new frmMenu();
            this.Hide();
           // Limpar();
            form.Show();


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
