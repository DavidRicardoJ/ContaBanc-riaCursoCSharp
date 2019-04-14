using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ContaBancáriaCursoCSharp
{
    class Conta
    {
        public int NConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int nConta, string titular, double saldo)
        {
            NConta = nConta;
            Titular = titular;
            Saldo = saldo;
        }

        public void Deposito (double deposito)
        {
            Saldo += deposito;
        }

        public void Saque (double saque)
        {
            Saldo -= saque;
            Saldo -= 5.00; // taxa de saque.
        }

        
        public override string ToString()
        {
            return "Conta: " + NConta + ", Titular: " + Titular + ", Saldo: $ " + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
