﻿using MySql.Data.MySqlClient;
using NTVApp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            MySqlCommand cmd = db.con.CreateCommand();
            string query = "insert into Cliente(Nome,TipoCliente,CpfCnpj,TipoPessoa,Sexo,DtNasc,Email,Endereco,Telefone,DtCadastro,plano_IDPlano) ";
            query += "values(?Nome,?TipoCliente,?CpfCnpj,?TipoPessoa,?Sexo,?DtNasc,? Email,?Endereco,?Telefone,?DtCadastro,?plano_IDPlano";

            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("?Nome", cliente.nome);
            cmd.Parameters.AddWithValue("?TipoCliente", cliente.tipoPessoa);
            cmd.Parameters.AddWithValue("?Sexo", cliente.sexo);
            cmd.Parameters.AddWithValue("?DtNasc", cliente.data_nasc);
            cmd.Parameters.AddWithValue("?email", cliente.email);
            cmd.Parameters.AddWithValue("?Endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("?Telefone", cliente.telefone);
            cmd.Parameters.AddWithValue("DtCadastro", cliente.data_cadastro);
            cmd.Parameters.AddWithValue("plano_IDPlano", cliente.plano);
            try
            {
                cmd.ExecuteNonQuery();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro Ao Inserir No Banco De Dados", ex.ToString());
                return;
            }

            finally
            {
                db.Disconnect();
            }

            return;

        }








        }
    }
}
