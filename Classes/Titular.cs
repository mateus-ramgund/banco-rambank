using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace banco_rambank.Classes
{
    public class Titular
    {
        public Titular(string nome, string cpf, string endereco)
        {
            Nome = nome;
            Cpf = cpf;
            Endereco = endereco;
            
        }
        public string Nome {get; set;}
        public string Cpf {get; set;}
        public string Endereco {get; set;}
    }
}
