using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] tabuleiro = new string[3, 3];
            int i = 0;
            int l = 0, c = 0;
            bool espaco = true;
            int status = -1;
            do
            {
                do
                {
                    Console.Write("Jogador 1: \nLinha:");
                    l = int.Parse(Console.ReadLine());
                    Console.Write("Coluna:");
                    c = int.Parse(Console.ReadLine());
                    espaco = add_peca("X", l, c, tabuleiro);
                } while (espaco);

                do
                {
                    imprimir_jogo(tabuleiro);
                    Console.Write("Jogador 2: \nLinha:");
                    l = int.Parse(Console.ReadLine());
                    Console.Write("Coluna:");
                    c = int.Parse(Console.ReadLine());
                    espaco = add_peca("O", l, c, tabuleiro);
                } while (espaco);
                imprimir_jogo(tabuleiro);
                if (verificaStatus(tabuleiro) == 1)
                {
                    Console.WriteLine("J1 Vencedor");
                    break;
                }
                if (verificaStatus(tabuleiro) == 2) { 
                    Console.WriteLine("J2 Vencedor");
                    break;
                }
                i++;
            } while (i <= 9);
            Console.WriteLine("Fim");
            //imprimir_jogo(tabuleiro);
            Console.ReadKey();

        }

        static void imprimir_jogo(string[,] tab)
        {
            //for (int l = 0; l < 3; l++)
            //{

            //    for (int c = 0; c < 3; c++)
            //    {
            //        Console.Write(tab[l, c] + "  ");
            //    }
            //    Console.WriteLine("\n");
            //}

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0} \t| {1} \t| {2}", tab[i,0], tab[i,1], tab[i,2]);
            }
        }

        static bool add_peca(string peca, int l, int c, string[,] tab)
        {
            
            
            if ((tab[l, c] == "O") || (tab[l, c] == "X"))
            {
                Console.WriteLine("ESPAÇO OCUPADO!!");
                return true;
            }
            else
            {
                tab[l, c] = peca;
            }

            return false;
            
            
        }

        static int verificaStatus(string[,] tab)
        {
           int contJ1 = 0, 
              int  contJ2 = 0;
           for (int l = 0; l < 3; l++)
           {
                for (int c = 0; c < 3; c++)
                {
                    //Diagonal primária
                    if (l==c)
                    {
                        if (tab[l, c] == "O")
                        {
                            contJ2++;
                        }
                        if (tab[l, c] == "X")
                        {
                            contJ1++;
                        }
                    }
                    //linha
                    if (tab[l,c] == "O") 
                    { 

                    }
                }
           }

            if (contJ1 == 3) return 1;
            if (contJ2 == 3) return 2;

            return 0;
        }

    }
}

