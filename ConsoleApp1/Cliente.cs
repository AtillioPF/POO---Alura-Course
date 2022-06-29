using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    internal class Cliente
    {
        public string Profissão { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Cliente() { }
        public Cliente(string nome, string cpf, string profissão)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Profissão = profissão;
        }

        
        
    }
}
