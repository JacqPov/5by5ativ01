using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Cliente
    {
        public long Cpf { get; set; }

        public string Nome { get; set; }

        public string Endereco { get; set; }

        public void Sacar(double valor)
        {
            if((saldo - valor) >= 0)
            {
                saldo -= valor;
            }
        }

        public void Depositar(double valor)
        {

        }
    }
}
