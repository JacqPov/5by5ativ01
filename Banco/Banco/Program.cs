using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c = new Cliente();
            Conta cc = new Conta();

            Console.WriteLine("Informe seu nome completo: ");
            c.Nome = Console.ReadLine();
            Console.WriteLine("Informe seu CPF: ");
            c.Cpf = long.Parse(Console.ReadLine());
            Console.WriteLine("Informe seu endereço: ");
            c.Endereco = Console.ReadLine();

            Console.WriteLine("Informe a sua agência bancária: ");
            cc.Agencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o número da conta: ");
            cc.Numero = int.Parse(Console.ReadLine());

           
        }
    }
}
