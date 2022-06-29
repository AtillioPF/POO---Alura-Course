using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    internal class ContaCorrente
    {
        public Cliente cliente;

        private int numeroAgencia;
        private string conta, nomeAgencia;
        private double saldo;

        public double Saldo { get => saldo; }
        public string Conta { get => conta; set => conta = value; }
        public int NumeroAgencia { get => numeroAgencia; }        
        private int NumeroAgencia2{ set => numeroAgencia = value;}
        public string NomeAgencia { get => nomeAgencia;  }
        private string NomeAgencia2 { set => nomeAgencia = value; }
        public ContaCorrente(string conta, int numeroAgencia, string nomeAgencia, Cliente cliente)
        {
            this.NumeroAgencia2 = numeroAgencia;            
            this.NomeAgencia2 = nomeAgencia;
            this.Conta = conta;
            this.cliente = cliente;
        }

        
        public bool Sacar(double valor)
        {
            if(valor<0)
                return false;
            if (saldo < valor)
                return false;
            else
                saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {   
            if (valor>0)
                saldo = saldo + valor;

        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (Saldo < valor)
                return false;
            if (valor < 0)
                return false;
            else
            {
                saldo = saldo - valor; ;
                destino.Depositar(valor);
                return true;
            }
        }

    }
}
