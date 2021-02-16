using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] tabuleiro = new string[3, 3];
            int l = 0, c = 0;
            bool espaco = true;


            for (l = 0; l < 3; l++)
            {
                for (c = 0; c < 3; c++)
                {
                    tabuleiro[l, c] = " ";
                }
            }

            do
            {

                do
                {
                    Console.WriteLine("Jogador 1:");
                    l = ValidaPosition("Digite a linha (0, 1 ou 2)");
                    c = ValidaPosition("Digite a coluna (0, 1 ou 2)");
                    espaco = Add_Peca("X", l, c, tabuleiro);
                } while (espaco);

                Imprimir_Jogo(tabuleiro);
                if (VerificaStatus(tabuleiro) == 1)
                {
                    Imprimir_Jogo(tabuleiro);
                    Console.WriteLine("Jogador 1 Foi o vencedor!!!");
                    break;
                }

                if (VerificaStatus(tabuleiro) == 0)
                {
                    Imprimir_Jogo(tabuleiro);
                    Console.WriteLine("Empate!!!");
                    break;
                }


                do
                {
                    Console.WriteLine("Jogador 2:");
                    l = ValidaPosition("Digite a linha (0, 1 ou 2)");
                    c = ValidaPosition("Digite a coluna (0, 1 ou 2)");
                    espaco = Add_Peca("O", l, c, tabuleiro);
                } while (espaco);

                Imprimir_Jogo(tabuleiro);
                if (VerificaStatus(tabuleiro) == 2)
                {
                    Imprimir_Jogo(tabuleiro);
                    Console.WriteLine("Jogador 2 Foi o vencedor!!!");
                    break;
                }

            } while (true);

            Console.WriteLine("Fim do Jogo!");
            Console.ReadKey();
        }

        static void Imprimir_Jogo(string[,] tab)
        {
            Console.WriteLine("\n=* JOGO DA VELHA *=\n");

            for (int l = 0; l < 3; l++)
            {
                Console.Write(l + "  ");
                for (int c = 0; c < 3; c++)
                {
                    Console.Write(tab[l, c]);
                    if (c != 2) Console.Write(" | ");
                }
                if (l != 2) Console.WriteLine("\n   __________\n");
            }
            Console.WriteLine("\n\n   0   1   2\n");
            Console.WriteLine("=*=*=*=*=*=*=*=");
        }

        static bool Add_Peca(string peca, int l, int c, string[,] tab)
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
        static int VerificaStatus(string[,] tab)
        {
            string ganhador = "";
            bool ganhou = false;
                       


            //Linha 1 ganhou {​​​​​​​0,0}​​​​​​​{​​​​​​​0,1}​​​​​​​{​​​​​​​0,2}​​​​​​​ 
            if (tab[0, 0] != "-" && (tab[0, 0] == tab[0, 1]))
            {
                if (tab[0, 1] == tab[0, 2])
                {
                    ganhador = tab[0, 0];
                    ganhou = true;
                }
            }

            //Linha 2 ganhou {​​​​​​​1,0}​​​​​​​{​​​​​​​1,1}​​​​​​​{​​​​​​​1,2}
            if (ganhou == false && tab[1, 0] != "-" && (tab[1, 0] == tab[1, 1]))
            {
                if (tab[1, 1] == tab[1, 2])
                {
                    ganhador = tab[1, 0];
                    ganhou = true;
                }
            }

            //Linha 3 ganhou {​​​​​​​2,0}​​​​​​​{​​​​​​​2,1}​​​​​​​{​​​​​​​2,2}
            if (ganhou == false && tab[2, 0] != "-" && (tab[2, 0] == tab[2, 1]))
            {
                if (tab[2, 1] == tab[2, 2])
                {
                    ganhador = tab[2, 0];
                    ganhou = true;
                }
            }

            //Coluna 1 ganhou {​​​​​​​0,0}​​​​​​​{​​​​​​​1,0}​​​​​​​{​​​​​​​2,0}​​​​​​​
            if (ganhou == false && tab[0, 0] != "-" && (tab[0, 0] == tab[1, 0]))
            {
                if (tab[1, 0] == tab[2, 0])
                {
                    ganhador = tab[0, 0];
                    ganhou = true;
                }
            }

            //Coluna 2 ganhou {​​​​​​​0,1}​​​​​​​{​​​​​​​1,1}​​​​​​​{​​​​​​​2,1}​​​​​​​
            if (ganhou == false && tab[0, 1] != "-" && (tab[0, 1] == tab[1, 1]))
            {
                if (tab[1, 1] == tab[2, 1])
                {
                    ganhador = tab[0, 1];
                    ganhou = true;
                }
            }

            //Coluna 3 ganhou {​​​​​​​0,2}​​​​​​​{​​​​​​​1,2}​​​​​​​{​​​​​​​2,2}
            if (ganhou == false && tab[0, 2] != "-" && (tab[0, 2] == tab[1, 2]))
            {
                if (tab[1, 2] == tab[2, 2])
                {
                    ganhador = tab[0, 2];
                    ganhou = true;
                }
            }

            //Diagonal principal {​​​​​​​0,0}​​​​​​​{​​​​​​​1,1}​​​​​​​{​​​​​​​2,2}​​​​​​​
            if (ganhou == false && tab[0, 0] != "-" && (tab[0, 0] == tab[1, 1]))
            {
                if (tab[1, 1] == tab[2, 2])
                {
                    ganhador = tab[0, 0];
                    ganhou = true;
                }
            }

            //Diagonal principal {​​​​​​​0,2}​​​​​​​{​​​​​​​1,1}​​​​​​​{​​​​​​​2,0}​​​​​​​
            if (ganhou == false && tab[0, 2] != "-" && (tab[0, 2] == tab[1, 1]))
            {
                if (tab[1, 1] == tab[2, 0])
                {
                    ganhador = tab[0, 2];
                    ganhou = true;
                }
            }

            //verifica se há um vencedor!
            if (ganhou)
            {
                if (ganhador == "X")
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }

            

            return -1;

        }    
            
            static int ValidaPosition(string texto)
        {
            int i;
            do
            {
                try
                {
                    Console.Write("{0}\n>>", texto);
                    i = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    i = -1;
                }
                catch (OverflowException)
                {
                    i = -1;
                }
            } while ((i < 0) || (i > 2));
            return i;
        }
    }
}
