using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTVApp.models
{
    internal class Cliente
    {
        public int id;
        public string nome { get; private set; }
        public string email { get; private set; }
        private List<Dictionary<string, string>> usuarios;
        public string plano;
        public DateTime data_entrada;

   }
}
