using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTVApp.database.bank
{
    public class Bank
    {
        private string con_Str;
        protected MySqlConnection con;

        public Bank()
        {
            this.con = new MySqlConnection();
            this.con_Str = "server=127.0.0.1;port=3306;uid=root;" + "pwd=minhavida;database=nerdtv;";
            this.con.ConnectionString=  con_Str;
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
            else
            {
                
                MessageBox.Show("Sucesso", "Conectado ao banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            int id = 1;
            string val = "Testando";
            string query = "insert into teste(id,val) values (?id,?val)";
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("?id", id);
            cmd.Parameters.AddWithValue("?val", val);
            cmd.Connection = con;
            try
            {
                cmd.ExecuteNonQuery();
                    }
            catch(Exception ex)
            {
                Console.WriteLine("Falha ao realizar consulta");
                return;

            }

            MessageBox.Show("Sucesso com query");

        }
    }
}