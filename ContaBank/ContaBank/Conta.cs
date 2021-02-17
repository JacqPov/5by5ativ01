using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBank
{
    class Conta
    {
        public int Agencia { get; set; }

        public int NumConta { get; set; }

        public double Saldo { get; set; }

        public void Sacar(double sacar)
        {
            if (this.Saldo > sacar)
            {
                this.Saldo -= sacar;

            }
            else
            {
                Console.WriteLine("Não é possível sacar!!");
            }

        }

        public void Deposito(double deposito)
        {
            this.Saldo += deposito;
        }

        public void Transferir(double transferir)
        {

        }
    }
}
