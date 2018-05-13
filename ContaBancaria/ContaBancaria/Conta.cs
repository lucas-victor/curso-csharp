using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace ContaBancaria
{
    class Conta
    {
        public int numero { get; private set; }
        public string titular { get; private set; }
        public double saldo { get; set; }

        public Conta(int num, string nome) {

            this.numero = num;
            this.titular = nome;
            this.saldo = 0.0;

        }
        public Conta(int num, string nome, double saldo) {
            this.numero = num;
            this.titular = nome;
            this.saldo = saldo;
        }
        public override string ToString()
        {
            return "Conta : "
                + numero.ToString()
                + ", Titular: "
                + titular
                + ", Saldo: R$ "
                + saldo.ToString("F2", CultureInfo.InvariantCulture);
                
        }
    }
}
