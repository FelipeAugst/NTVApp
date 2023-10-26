using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTVApp.models
{
    internal class Usuario
    {
        private Dictionary<string, string> data;
        private int id;
        private string nick;
        private string email;
        private string senha;
        private Cliente cliente;
        private bool isActive;

        Usuario(string senha,string email,int id,string nick,Cliente dono)
        {
            this.data = new Dictionary<string, string>();
            this.id = id;
            this.nick = nick;
            this.isActive = true;           
            data.Add("senha", senha);
            data.Add("email", email);
            data.Add("ID", id.ToString());
            data.Add("Nick", nick);
            data.Add("Cliente", dono.nome);


        }

        
    }
}
