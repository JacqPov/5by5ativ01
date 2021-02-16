using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exclasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa(); // p é objeto da classe pessoa = está instanciando o objeto a classe pessoa
            //p.id = 10; não é poossível acessar se a classe pessoa for private
            Pessoa p2 = p; // p já foi instanciado, p2 aponta para o mesmo objeto
            Pessoa p3 = new Pessoa { 13, "Zé do caixão", 66 };
            //Console.WriteLine(p.ToString());

            p.endereco = new Endereco {Logradouro = "Rua Humaita", Numero = 1234, Localidade = "Araraquara" };
            

            Console.WriteLine("Após instanciar o objeto ID: {0}",p.GetId());
            Console.WriteLine("Após instanciar o objeto nome: {0}", p.Nome);
            Console.WriteLine("Após instanciar a propriedade Idade: {0}", p.Idade);
            p.SetId(10);
            p.Nome = "Fabio";
            p.Idade = 48;
            Console.WriteLine("Após chamar o método setID: {0}", p.GetId());
            Console.WriteLine("Após chamar o método set nome: {0}", p.Nome);
            Console.WriteLine("Após chamar o método set Idade: {0}", p.Idade);

            //Console.WriteLine(p.ToString());
            if (p.EhMaior()) // se chamar p2 no lugar de p apresenta o mesmo resultado; p e p2 referenciam o mesmo objeto e possuem o mesmo estado
            {
                Console.WriteLine(p.Nome+ " é maior de idade");
            }

            else
            {
                Console.WriteLine(p.Nome+ " não é maior de idade");
            }

            
            Console.ReadKey();

        }
    }
}
