using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroVeiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente p = new Cliente();
            Veiculo carro = new Veiculo();

            do
            {

                Console.WriteLine("Você deseja: ");
                Console.WriteLine("1- Informar os dados");
                Console.WriteLine("2- Imprimir os dados que possui");
                Console.WriteLine("3- Finalizar o programa");

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
                        Console.WriteLine("Informe sua data de nascimento: ");
                        p.DataNascimento = Console.ReadLine();
                        Console.WriteLine("Informe a data da compra: ");
                        p.DataCompra = Console.ReadLine();
                        Console.WriteLine("Informe a marca do veículo: ");
                        carro.Marca = Console.ReadLine();
                        Console.WriteLine("Informe o modelo do veículo: ");
                        carro.Modelo = Console.ReadLine();
                        Console.WriteLine("Informar a cor do veículo: ");
                        carro.Cor = Console.ReadLine();
                        Console.WriteLine("Informe o ano do veículo: ");
                        carro.Ano = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe a placa do veículo: ");
                        carro.Placa = Console.ReadLine();
                        Console.WriteLine("Informe o Renavam do veículo: ");
                        carro.Renavam =Console.ReadLine();
                        break;
                    case "2":
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
                        break;
                    case "3":
                        Finalizar();
                        break;

                }

            } while (true);
            Console.ReadKey();

        }

        
        static void Finalizar()
        {
            Environment.Exit(0);
        }
        
    }
}
