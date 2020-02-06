using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Cliente
    {
        public int ID { get;set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool EhAtivo { get; set; }
    }
}
