using MySql.Data.MySqlClient;
using NTVApp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTVApp.database.MySQL
{
    internal class Cliente_Tabela
    {
        private Bank db;

        Cliente_Tabela()
        {
            this.db = new Bank();
           
        }
        public void Inserir(Cliente cliente)
        {   
            db.Connect();
            MySqlCommand cmd= db.con.CreateCommand();
            cmd.CommandText= "insert into Cliente(?Nome,?TipoCliente,?CpfCnpj,?TipoPessoa,?Sexo,?DtNasc,?Email,?Endereco,?Telefone,?DtCadastro,?plano_IDPlano";
            cmd.Parameters.AddWithValue("?Nome", cliente.nome);
            cmd.Parameters.AddWithValue("?TipoCliente", cliente.)
            cmd.Parameters.AddWithValue("?Nome", cliente.nome);
            cmd.Parameters.AddWithValue("?Nome", cliente.nome);
            cmd.Parameters.AddWithValue("?Nome", cliente.nome);
            cmd.Parameters.AddWithValue("?Nome", cliente.nome);










        }
    }
}
