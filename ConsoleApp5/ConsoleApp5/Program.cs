using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            Veiculo carro = new Veiculo();
            int op = 0;


            do {
                Console.WriteLine("Informe o seu nome completo: ");
                p.Nome = Console.ReadLine();
                Console.WriteLine("Informe o seu CPF: ");
                p.Cpf = long.Parse(Console.ReadLine());
                Console.WriteLine("Informe o seu endereço: ");
                p.Endereco = Console.ReadLine();
                Console.WriteLine("Informe sua data de nascimento: ");
                p.DataNascimento = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe a data da compra: ");
                p.DataCompra = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite 1 para continuar o cadastro ou outro valor para sair");
                op = int.Parse(Console.ReadLine());

            } while (op==1);

            do {
                Console.WriteLine("Informe a marca do veículo: ");
                carro.Marca = Console.ReadLine();
                Console.WriteLine("Informe o modelo do veículo: ");
                carro.Modelo = Console.ReadLine();
                Console.WriteLine("Informar a cor do veículo: ");
                carro.Cor = Console.ReadLine();
                Console.WriteLine("Informe o ano do veículo: ");
                carro.Ano = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe a placa do veículo: ");
                carro.Placa = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o Renavam do veículo: ");
                carro.Renavam = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite 1 para continuar o cadastro ou outro valor para sair");
                op = int.Parse(Console.ReadLine());

            } while (op == 1);

            Console.WriteLine("Digite 2 para imprimir os dados do cadastro: ");
            op = int.Parse(Console.ReadLine());
            if (op==2) {
                Console.WriteLine("\nNome: " + p.Nome);
                Console.WriteLine("\nCPF: " + p.Cpf);
                Console.WriteLine("\nEndereço: " + p.Endereco);
                Console.WriteLine("\nData de Nascimento: " + p.DataNascimento);
                Console.WriteLine("\nData da compra: " + p.DataCompra);
                Console.WriteLine("\nMarca do veículo: " + carro.Marca);
                Console.WriteLine("\nModelo do veículo: " + carro.Modelo);
                Console.WriteLine("\nCor do veículo: " + carro.Cor);
                Console.WriteLine("\nAno do veículo: " + carro.Ano);
                Console.WriteLine("\nPlaca do veículo: " + carro.Placa);
                Console.WriteLine("\nRenavam do veículo: " + carro.Renavam);
            }


            Console.WriteLine("APERTE QUALQUER TECLA PARA ENCERRAR!!");
            Console.ReadKey();



        }

        //static void clientelista(int cadastrar, int mostrar, int sair)
        //{
        //    int opcao;

        //    switch (opcao)
        //    {
        //        case 1:
        //                cadastrar();
        //            break;

        //        case 2:
        //                mostrar();
        //            break;
        //        case 3:
        //                sair();
        //            break;
        //    }
        //}

    }
}
