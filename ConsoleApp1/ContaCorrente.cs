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

        public double Saldo { get => saldo; set => saldo = value; }
        public string Titular { get => titular; set => titular = value; }
        public string Conta { get => conta; set => conta = value; }
        public int NumeroAgencia { get => numeroAgencia; set => numeroAgencia = value; }
        public string NomeAgencia { get => nomeAgencia; set => nomeAgencia = value; }

        public ContaCorrente(string conta, int numeroAgencia, string nomeAgencia, string titular = null, double saldo = 0 )
        {
            this.NumeroAgencia = numeroAgencia;
            this.Saldo = saldo;
            this.NomeAgencia = nomeAgencia;
            this.Conta = conta;
            this.Titular = titular;
        }

        public void show()
        {
            Console.WriteLine(Conta+Titular);
        }
        public bool Sacar(double valor)
        {
            if(valor<0)
                return false;
            if (Saldo < valor)
                return false;
            else
                Saldo-=valor;
            return true;
        }

        public void Depositar(double valor)
        {   
            if (valor>0)                
            Saldo = Saldo + valor;

        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (Saldo < valor)
                return false;
            if (valor < 0)
                return false;
            else
            {
                Saldo = Saldo - valor; ;
                destino.Depositar(valor);
                return true;
            }
        }

    }
}
