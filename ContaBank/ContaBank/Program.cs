using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente p = new Cliente();
            Conta c = new Conta();
            double deposito;
            double sacar;
            double transferir;
            //Conta c2 = new Conta();

            do
            {

                Console.WriteLine("Você deseja: ");
                Console.WriteLine("1- Informar os dados (Conta/Cliente)");
                Console.WriteLine("2- Fazer depósito");
                Console.WriteLine("3- Fazer saque");
                Console.WriteLine("4- Fazer transferência");
                Console.WriteLine("5- Imprimir saldo");


                string comando = Console.ReadLine();


                switch (comando)
                {
                    case "1":
                        Console.WriteLine("Informe o seu nome completo: ");
                        p.Nome = Console.ReadLine();
                        Console.WriteLine("Informe o seu CPF: ");
                        p.Cpf = long.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o seu endereço: ");
                        p.Endereco = Console.ReadLine();
                        Console.WriteLine("Informe a sua agência bancária: ");
                        c.Agencia = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o número da sua conta bancária: ");
                        c.NumConta = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o seu saldo: ");
                        c.Saldo = double.Parse(Console.ReadLine());

                        break;
                    case "2":
                        Console.WriteLine("Informe o valor a ser depositado: ");
                        deposito = double.Parse(Console.ReadLine());
                        c.Deposito(deposito);
                        break;
                    case "3":
                        Console.WriteLine("Informe o valor a ser sacado: ");
                        sacar = double.Parse(Console.ReadLine());
                        c.Sacar(sacar);
                        break;
                    case "4":
                        Console.WriteLine("Informe o valor a ser transferido: ");
                        transferir = double.Parse(Console.ReadLine());
                        break;//não foi possível
                    case "5":
                        Console.WriteLine("\nSaldo: " + c.Saldo);
                        break;

                }

            } while (true);

            Console.ReadKey();
        }

    }
}
