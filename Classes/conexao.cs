using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Hotelaria.Classes
{
    class conexao
    {

        //Conectar ao banco.
        string Conec = "Server=localhost\\SQLEXPRESS; Initial Catalog = Hotel; User ID = Hotel; Password = 123456";
        public SqlConnection con = null;
        
        public void AbrirCon()
        {
            try { 
            con = new SqlConnection(Conec);
            con.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public void FecharCon()
        {
            try
            {
                con = new SqlConnection(Conec);
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


    }
}
