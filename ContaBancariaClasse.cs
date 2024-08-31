
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Banco {
    internal class ContaBancaria {

        public int numero { get; private set; }
        public string titular {  get; set; }
        public double saldo { get; private set; }

        public ContaBancaria(int codigo, string titular) {
            numero = codigo;
            this.titular = titular;
        }
        
        public ContaBancaria(int codigo, string titular, double saldo) : this(codigo, titular) {
            this.saldo = saldo;
        }

        public void Deposito(double numero) {
            saldo += numero;
        }

        public void Saque(double numero) {
            saldo -= numero + 5.0;
        }

        public override string ToString() {
            return "Conta: " + numero + " , Titular: " + titular + " , Saldo: " + saldo;
        }



    }
}
