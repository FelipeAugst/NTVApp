using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTVApp.database.MySQL
{
    public class Bank
    {
        private string con_Str;
        public MySqlConnection con;

        public Bank()
        {
            con = new MySqlConnection();
            con_Str = "server=127.0.0.1;port=3306;uid=felipe;" + "pwd=felipe;database=nerdtv;";
            con.ConnectionString = con_Str;
        }
        public void Connect()
        {
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Falha ao se conectar ao banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (!con.Ping())
            {
                MessageBox.Show("Erro ao testar conexao de banco de dados");
                return;

            }
            return;

        }
        public void Disconnect()
        {
            con.Dispose();
        }
    }
}


