using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace individual
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
            Imprimir_Jogo(tabuleiro);
            //inicio do jogo

            do
            {
                //leitura do j1
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

                //leitura do j2
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

        static int VerificaStatus(string [,] tab)
        {
            if (Vitoria(tab, "X"))
            {
                return 1;
            }

            else if (Vitoria(tab, "O"))
            {
                return 2;
            }

            else if (empate(tab))
            {
                return 0;
            }

            else
            {
                return -1;
            }
        }

        static bool Vitoria(string[,] tab, string peca)
        {
            int condicaoVitoria = 3;

            bool vitoriaDiagonal = DiagonalPrimaria(tab, peca) == condicaoVitoria || DiagonalSecundaria(tab, peca) == condicaoVitoria;
            bool vitoriaLinha = Linha(tab, peca, 0) == condicaoVitoria || Linha(tab, peca, 1) == condicaoVitoria || Linha(tab, peca, 2) == condicaoVitoria;
            bool vitoriaColuna = Coluna(tab, peca, 0) == condicaoVitoria || Coluna(tab, peca, 1) == condicaoVitoria || Coluna(tab, peca, 2) == condicaoVitoria;

            if (vitoriaColuna || vitoriaLinha || vitoriaDiagonal)
            {
                return true;
            }

            else
            {
                return false;
            }
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
                    Console.WriteLine("\nInforme apenas valores que sejam 0, 1 ou 2\n");
                    i = -1;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("\nInforme apenas valores que sejam 0, 1 ou 2\n");
                    i = -1;
                }
            } while ((i < 0) || (i > 2));
            return i;
            
        }

    }
}

