using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaModificacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha minha_pilha = new Pilha { Topo = null };
            Livro l = new Livro { Titulo = "A volta dos que não foram", Autor = "John Doe", Isbn = 1234567, Anterior = null };
            

            do
            {
                Console.WriteLine(">>>>MENU<<<<");
                Console.WriteLine("Você deseja: ");
                Console.WriteLine("1- Inserir Livro");
                Console.WriteLine("2- Remover Livro");
                Console.WriteLine("3- Imprimir Pilha");
                Console.WriteLine("4- Quantidade de Elementos na Pilha");
                Console.WriteLine("5- Busca de Livro na Pilha por Título");
                Console.WriteLine("0- Sair");


                string comando = Console.ReadLine();

                Console.Clear();

                switch (comando)
                {
                    case "1":
                        Console.WriteLine("Inserindo...");
                        minha_pilha.Push(new Livro {Titulo = "A volta dos que não foram", Autor = "John Doe", Isbn = 1234567, Anterior = null });
                        minha_pilha.Push(new Livro {Titulo = "Hobbit", Autor = "John Doe", Isbn = 1234567, Anterior = null });
                        minha_pilha.Push(new Livro {Titulo = "Harry Potter", Autor = "John Doe", Isbn = 1234567, Anterior = null });
                        minha_pilha.Push(new Livro {Titulo = "Senhor dos Anéis", Autor = "John Doe", Isbn = 1234567, Anterior = null });
                        break;
                    case "2":
                        Console.WriteLine("Removendo...");
                        minha_pilha.Pop();
                        break;
                    case "3":
                        Console.WriteLine("Imprimindo...");
                        minha_pilha.Imprimir();
                        break;
                    case "4":
                        minha_pilha.Quantidade();
                        break;
                    case "5":
                        Console.WriteLine("Informe o título a ser buscado: ");
                        string titulo = Console.ReadLine();
                        
                        minha_pilha.BuscaPorTitulo(titulo);
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
