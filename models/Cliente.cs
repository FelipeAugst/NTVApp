using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTVApp.models
{
    public class Cliente
    {
        public int id;
        public string nome;
        public string email;
        private List<Dictionary<string, string>>? usuarios;
        public string plano;
        public DateTime data_nasc;
        public string endereco;
        public string tipoPessoa;
        public string sexo;
        public string CpfCnpj;
        public string telefone;
        public DateTime data_cadastro;

        Cliente(string nome, string email, string plano, DateTime data_nasc, string endereco, string tipoPessoa, string sexo, string CpfCnpj)
        {
            this.nome = nome;
            this.email = email;
            this.plano = plano;
            this.data_nasc = data_nasc;
            this.endereco = endereco;
            this.tipoPessoa = tipoPessoa;
            this.sexo = sexo;
            this.CpfCnpj = CpfCnpj;
            this.data_cadastro = DateTime.Now.Date;

        }


    }

   
    
}
