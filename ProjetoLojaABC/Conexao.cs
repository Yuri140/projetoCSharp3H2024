using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetoLojaABC
{
    class Conexao
    {
        private static String conString = "Server = localhost; Port = 3306; Database = dbLoja; Uid = etecia; Pwd = 123456";
        private static MySqlConnection con = null;
        public static MySqlConnection obterConexao()
        {
            con = new MySqlConnection(conString);

            try
            {
                con.Open();
            }
            catch (MySqlException)
            {
                con = null;
            }

            
            return con;
        }

        public static MySqlConnection fecharConexao()
        {
            if (con != null)
            {
                con.Close();
            }
            return con;
        }

    }
}
