using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaModificacao
{
    class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Isbn { get; set; }

        public Livro Anterior { get; set; }

        public override string ToString()
        {
            return ">>>>DADOS DO LIVRO<<<<\nTitulo:" + Titulo + "\nAutor:" + Autor + "\nISBN:" + Isbn;
        }

        public bool Busca(string titulo)
        {
            if (Titulo == titulo)
            {
                Console.WriteLine("Livro encontrado!!");
            }
            else
            {
                if (Anterior == null)
                {
                    Console.WriteLine("Livro não encontrado!!");
                    return false;
                }

                Anterior.Busca(titulo);
            }

            return true;
        }


    }
}
