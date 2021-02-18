using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaModificacao
{
    class FilaOS
    {
        public OrdemServico Head { get; set; }
        public OrdemServico Tail { get; set; }


        public bool Vazia()
        {
            if ((Head == null) && (Tail == null)) 
            {
                return true;
            }

            return false;
        }

        public void Push(OrdemServico aux)//precisa passar parametro
        {
            if (Vazia())
            {
                Head = aux;
                Tail = aux;
            }
            else
            {
                Tail.Proximo = aux; //encadeamento da nova OS
                Tail = aux; //atualização do tail para o ultimo elemento

            }

            Console.WriteLine("Elemento inserido com sucesso!!");
        }

        public void Print()//não precisa passar parametro
        {
            if (Vazia())
            {
                Console.WriteLine("Impossível imprimir!! Fila vazia!!");
                Console.ReadKey();
            }

            else
            {
                OrdemServico aux = Head; //inicia pelo head
                Console.WriteLine("\n>>>>As ordens de serviço são<<<<\n");
                do
                {

                    Console.WriteLine(aux.ToString());
                    aux = aux.Proximo;

                } while (aux != null); //enquanto o aux não for nulo, deve fazer o laço

                Console.WriteLine("\n>>>>FIM DA IMPRESSÃO<<<<");
            }
        }

        public void Pop() //não precisa de parametro
        {
            if (Vazia())
            {
                Console.WriteLine("Impossível remover!! Fila vazia!!");
                Console.ReadLine();
            }
            else
            {
                Head = Head.Proximo; //head recebe o proximo de quem está apontando
                Console.WriteLine("Elemento removido com sucesso!!");
                if (Head == null)
                {
                    Tail = null;
                    Console.WriteLine("Fila vazia!!");
                    Console.ReadKey();
                }
            }
        }
        public void BuscaPorNum(int numero)
        {
            if (Vazia())
            {
                Console.WriteLine("Fila vazia!! Não é possível buscar!!");
            }
            else
            {
                Head.Busca(numero);
            }
           
        }
        public void Quantidade()
        {
            if (Vazia())
            {
                Console.WriteLine("Não há O.S na fila!!");
            }
            else
            {
                int contador = 0;
                OrdemServico aux = Head;

                do
                {
                    contador++;
                    aux = aux.Proximo;//remove o proximo que está recebendo o aux
                } while (aux != null);

                Console.WriteLine("Há um total de " + contador + " O.S!!");
            }
        }
    }
}
