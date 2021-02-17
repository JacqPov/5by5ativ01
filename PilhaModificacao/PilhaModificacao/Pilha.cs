using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaModificacao
{
    class Pilha
    {
        public Livro Topo { get; set; }

        public void Push(Livro aux)
        {
            aux.Anterior = Topo;
            Topo = aux;
            Console.WriteLine("Elemento inserido com sucesso!!\n");
            return;
        }

        private bool Vazia()
        {
            if (Topo == null)
            {
                return true;
            }

            return false;
        }
        public void Imprimir()
        {
            if (Vazia())
            {
                Console.WriteLine("Impossível imprimir!! Pilha vazia!!\n");
                Console.ReadKey();
            }
            else
            {
                Livro aux = Topo;
                Console.WriteLine("Os elementos na pilha são: ");
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Anterior;
                } while (aux != null);

                Console.WriteLine(">>>FIM<<<");
            }
        }

        public void Pop()
        {
            if (Vazia())
            {
                Console.WriteLine("Impossível remover!! Pilha vazia!!\n");
                Console.ReadKey();
            }

            else
            {
                Topo = Topo.Anterior;
                Console.WriteLine("Elemento removido!!\n");
            }

        }

        public void BuscaPorTitulo(string titulo)
        {
            Topo.Busca(titulo);
        }

        public void Quantidade()
        {
            if (Vazia())
            {
                Console.WriteLine("Não há livros na pilha!!");
            }
            else
            {
                int contador = 0;
                Livro aux = Topo;

                do
                {
                    contador++;
                    aux = aux.Anterior;
                } while (aux != null);

                Console.WriteLine("Há um total de " +contador+ " livros!!");
            }
        }
    }
}
