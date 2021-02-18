using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaModificacao
{
    class Program
    {
        static void Main(string[] args)
        {
            OrdemServico os = new OrdemServico(); //{ Numero = 123, Tipo = "Usinagem", Descricao = "Fazer 100 unidades de pedaleira de moto", DataCriacao = DateTime.Now, Prazo = 10, Proximo = null };//criou o objeto
            FilaOS minha_fila = new FilaOS { Head = null, Tail = null }; //inicia com head e tail sendo nulos

            do
            {
                Console.WriteLine(">>>>MENU<<<<");
                Console.WriteLine("Você deseja: ");
                Console.WriteLine("1- Inserir O.S");
                Console.WriteLine("2- Remover O.S");
                Console.WriteLine("3- Imprimir Fila");
                Console.WriteLine("4- Quantidade de Elementos na Fila");
                Console.WriteLine("5- Busca de O.S na Fila por Número");
                Console.WriteLine("0- Sair");


                string comando = Console.ReadLine();

                Console.Clear();

                switch (comando)
                {
                    case "1":
                        Console.WriteLine("Inserindo...");
                        minha_fila.Push(new OrdemServico { Numero = 123, Tipo = "Usinagem", Descricao = "Fazer 100 unidades de pedaleira de moto", DataCriacao = DateTime.Now, Prazo = 10, Proximo = null });
                        minha_fila.Push(new OrdemServico { Numero = 456, Tipo = "Pintura", Descricao = "Pintar 20 quadros da BMW12000", DataCriacao = DateTime.Now, Prazo = 15, Proximo = null });
                        minha_fila.Push(new OrdemServico { Numero = 789, Tipo = "Montar Moto", Descricao = "Montar 10 unidades de Biz 100", DataCriacao = DateTime.Now, Prazo = 7, Proximo = null });
                        break;
                    case "2":
                        Console.WriteLine("Removendo...");
                        minha_fila.Pop();
                        break;
                    case "3":
                        Console.WriteLine("Imprimindo...");
                        minha_fila.Print();
                        break;
                    case "4":
                        minha_fila.Quantidade();
                        break;
                    case "5":
                        Console.WriteLine("Informe o número da O.S a ser buscado: ");
                        int numero = int.Parse(Console.ReadLine());

                        minha_fila.BuscaPorNum(numero);
                        break;
                    case "0":
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
