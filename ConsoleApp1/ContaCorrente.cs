using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    internal class ContaCorrente
    {
        

        private double saldo;
        private int _numero_agencia;
        private string _nome_agencia, _conta;

        public Cliente Titular { get; set; }

        public double Saldo { get => saldo; }

        
        public string Conta
        {
            get
            {
                return _conta;
            }                
            set
            {
                if (value == null)
                    return;
                else
                    _conta = value;
            }
        }
        
        public int NumeroAgencia 
        {
            get
            {
                return _numero_agencia;
            }
            set 
            {
                if (value <= 0)
                    return;
                else
                    _numero_agencia = value;    
            }
        }
        
        public string NomeAgencia
        {
            get
            {
                return _nome_agencia;
            }
            set
            {
                if (value == null)
                    return;
                else
                    _nome_agencia = value;
            }
        }

        public ContaCorrente(string conta , int numeroAgencia, string nomeAgencia )
        {
            this.NumeroAgencia = numeroAgencia;
            this.NomeAgencia = nomeAgencia;
            this.Conta = conta;           
        }

        public ContaCorrente()
        {

        }

        public bool Sacar(double valor)
        {
            if (valor < 0)
                return false;
            if (saldo < valor)
                return false;
            else
                saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
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
        public int TotalDeContasCriadas { get; set; }

    }
}
