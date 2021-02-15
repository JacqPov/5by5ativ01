using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] tabuleiro = new string[3, 3];
            int l = 0, c = 0;
            bool espaco = true;
            InicializaTabuleiro(tabuleiro);//preenche a matriz de espaços
            Console.WriteLine("JOGO DA VELHA");
            imprimir_jogo(tabuleiro);
            //inicio do jogo

            do
            {
                //leitura do j1
                do
                {
                    Console.WriteLine("Jogador 1:");
                    l = validaPosition("Linha");
                    c = validaPosition("Coluna");
                    espaco = add_peca("X", l, c, tabuleiro);
                } while (espaco);

                imprimir_jogo(tabuleiro);
                if (verificaStatus(tabuleiro) == 1)
                {
                    imprimir_jogo(tabuleiro);
                    Console.WriteLine("Jogador 1 Foi o vencedor!!!");
                    break;
                }

                if (verificaStatus(tabuleiro) == 0)
                {
                    imprimir_jogo(tabuleiro);
                    Console.WriteLine("Empate!!!");
                    break;
                }

                //leitura do j2
                do
                {
                    Console.WriteLine("Jogador 2:");
                    l = validaPosition("Linha");
                    c = validaPosition("Coluna");
                    espaco = add_peca("O", l, c, tabuleiro);
                } while (espaco);

                imprimir_jogo(tabuleiro);
                if (verificaStatus(tabuleiro) == 2)
                {
                    imprimir_jogo(tabuleiro);
                    Console.WriteLine("Jogador 2 Foi o vencedor!!!");
                    break;
                }

            } while (true);
            Console.WriteLine("Fim do Jogo!");
            Console.ReadKey();
        }

        static void imprimir_jogo(string[,] tab)
        {
            Console.WriteLine("\n=* TABULEIRO *=\n");

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
            
            int[] contJ1 = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] contJ2 = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };

            
          
            contJ1[0] = DiagonalPrimaria(tab, "X");
            contJ2[0] = DiagonalPrimaria(tab, "O");
            
            contJ1[1] = DiagonalSecundaria(tab, "X");
            contJ2[1] = DiagonalSecundaria(tab, "O");
            
            contJ1[2] = Linha(tab, "X", 0);
            contJ2[2] = Linha(tab, "O", 0);
            contJ1[3] = Linha(tab, "X", 1);
            contJ2[3] = Linha(tab, "O", 1);
            contJ1[4] = Linha(tab, "X", 2);
            contJ2[4] = Linha(tab, "O", 2);
            
            contJ1[5] = Coluna(tab, "X", 0);
            contJ2[5] = Coluna(tab, "O", 0);
            contJ1[6] = Coluna(tab, "X", 1);
            contJ2[6] = Coluna(tab, "O", 1);
            contJ1[7] = Coluna(tab, "X", 2);
            contJ2[7] = Coluna(tab, "O", 2);
            
            for (int i = 0; i < 8; i++)
            {
                if (contJ1[i] == 3) return 1;
                if (contJ2[i] == 3) return 2;
                if (empate(tab)) return 0;
            }

            return -1;
        }

        static bool empate(string[,] tab)
        {
            bool empate = false;
            int cont = 0;
            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (tab[l, c] != " ") cont++;
                }
            }
            if (cont == 9) empate = true;
            return empate;
        }

        static int Linha(string[,] tab, string peca, int linha)
        {
            int cont = 0;
            for (int i = 0; i < 3; i++)
            {
                if (tab[linha, i] == peca)
                {
                    cont++;
                }
            }
            return cont;
        }

        static int Coluna(string[,] tab, string peca, int coluna)
        {
            int cont = 0;
            for (int i = 0; i < 3; i++)
            {
                if (tab[i, coluna] == peca)
                {
                    cont++;
                }
            }
            return cont;
        }
        static int DiagonalPrimaria(string[,] tab, string peca)
        {
            int cont = 0;

            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (l == c)
                    {
                        if (tab[l, c] == peca)
                        {
                            cont++;
                        }
                     
                    }

                }
            }

            return cont;
        }
        static int DiagonalSecundaria(string[,] tab, string peca)
        {
            int cont = 0;
            int j = 2;
            for (int i = 0; i < 3; i++)
            {
                if (tab[i, j] == peca)
                {
                    cont++;
                }
                j--;
            }
            return cont;
        }

        static void InicializaTabuleiro(string[,] tab)
        {
            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    tab[l, c] = " ";
                }
            }
        }

        static int validaPosition(string texto)
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
