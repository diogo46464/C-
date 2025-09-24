using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Conta_Bancaria {
    public class ContaBancaria {


        public int Conta { get; private set; }
        public string Titular { get;  set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int conta, string titular) {
            Conta = conta;
            Titular = titular;
        }

        public ContaBancaria(int conta, string titular, double saldo) : this(conta, titular )
            
            {
                     
            Saldo = saldo;
           
        }

        public  void Depositar(double quantia) {

             Saldo += quantia;
        }

        public void Sacar(double quantia) {

            Saldo -= quantia + 5.0;
        }

        public override string ToString() {
            return $"Conta: " 
             + Conta 
             +", Titular: " 
            + Titular 
            + ", Saldo:R$" 
             + Saldo.ToString("F2", CultureInfo.InvariantCulture);

            
        }
    }
}
