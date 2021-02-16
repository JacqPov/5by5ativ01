using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroVeiculo
{
    class Cliente
    {
        public long Cpf { get; set; }
        public string Nome { get; set; }

        public string Endereco { get; set; }

        public string DataNascimento { get; set; }

        public string DataCompra { get; set; }
    }
}
