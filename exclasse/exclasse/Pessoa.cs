using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exclasse
{
    class Pessoa
    {
        #region Exemplo Geral de atributo
        private int id;

        public int GetId() //metodo para recuperar o atributo id
        {
            return id;//não é todo método que vai ter get e set
        }

        public void SetId(int id)
        {
            this.id = id; //this define o id da classe
        }

        #endregion
        //public void xpto()
        //{
        //buscar valor do id no banco de dados
        //atribuir o valor ao ID da pessoa
        //}
        #region Exemplo 2 - c#
        private string nome;


        public string Nome
        {
            get
            {
                return this.nome;
            }

            set
            {
                this.nome = value;
            }
        }

        #endregion

        #region Exemplo 3 - Propriedade c#

        public int Idade { get; set; }//utilizar esse

        public override string ToString()
        {
            return base.ToString();
        }

        #endregion

        //public override string ToString() //reescrever o que tem dentro do método
        //{
        //    return ("ID: "+this.id+"Nome: "+Nome+"Idade: "+Idade);
        //}

        #region Métodos Construtores Tradicionais
        //public Pessoa() //método tradicional construtor
        //{
        //    id = 0;
        //    Nome = "Zé ninguem";
        //    Idade = 0;
        //}

        //public Pessoa(int id, string nome, int idade) 
        //{
        //   this.id = id;
        //   Nome = nome;
        //   Idade = idade; 
        //}

        #endregion


        public Endereco endereco;//associação de uma classe a outra (1 pra 1)
        public bool EhMaior()
        {
            if (Idade >= 18)
            {
                return true;
            }

            return false;
        }
    }
}