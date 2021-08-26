using System;
using crud.Enum;

namespace crud.Models
{
    public class Clientes
    {
        public int Id {get; set; }
        public string Nome {get; set; }
        public string Telefone {get; set; }
        public string Email {get; set; }
        public Estados Estado {get; set; }
        public int Produto {get; set; }
        public int valorTotal {get; set; }

    }
}