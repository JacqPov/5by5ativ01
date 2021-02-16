using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class Conta
    {
        private string NomeCliente;
        private int NumConta;
        private double Saldo;

        public string GetNomeCliente()
        {
            return NomeCliente;
        }

        public string SetNomeCliente(string nome)
        {
            this.NomeCliente = nome;
        }
        public double GetSaldo()
        {
            return Saldo;
        }

        public void SetSaldo(double saldo)
        {
            this.Saldo = saldo;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
