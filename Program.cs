using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelaria
{
    static class Program
    {

        //Variaveis Globais do sistema

        public static string nomeUsuario;
        public static string cargoUsuario;

        public static string chamadaProdutos;

        public static string nomeProduto;
        public static string estoqueProduto;
        public static string valorProduto;
        public static string idProduto;

        public static string idVenda;

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}
