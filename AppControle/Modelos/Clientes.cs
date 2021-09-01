using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCadastro
{
    public class Clientes
    {
        public int Id {get; set; }
        public string Nome {get; set; }
        public string Telefone {get; set; }
        public string Email {get; set; }
        public string Estado {get; set; }
        public int Produto {get; set; }
        public int valorTotal {get; set; }
    }
}
