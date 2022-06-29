using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    internal class ContaCorrente
    {
        private string titular;
        private string conta;
        private int numeroAgencia;
        private string nomeAgencia;
        private double saldo;


        public ContaCorrente(string conta, int numeroAgencia, string nomeAgencia, string titular = null, double saldo = 0 )
        {
            this.numeroAgencia = numeroAgencia;
            this.saldo = saldo;
            this.nomeAgencia = nomeAgencia;
            this.conta = conta;
            this.titular = titular;
        }

        public bool Sacar(double valor)
        {
            if(valor<0)
                return false;
            if (saldo < valor)
                return false;
            else
                saldo-=valor;
            return true;
        }

        public void Depositar(double valor)
        {   
            if (valor>0)                
            saldo = saldo + valor;

        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
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
