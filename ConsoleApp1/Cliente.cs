using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    internal class Cliente
    {
        private string nome, cpf, profissão;

        public Cliente(string nome,string cpf, string profissão)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.profissão = profissão;
        }

        public string Profissão { get => profissão; set => profissão = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
    }
}
