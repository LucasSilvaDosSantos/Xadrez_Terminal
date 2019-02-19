using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.Terminada)
                {
                    
                    Console.Clear();
                    Tela.Imprimirtabuleiro(partida.Tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();


                    bool[,] posicoesPossiveis = partida.Tab.PosPeca(origem).MovimentosPossiveis();

                    Console.Clear();
                    Tela.Imprimirtabuleiro(partida.Tab, posicoesPossiveis);

                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

                    partida.ExecutaMovimento(origem, destino);
                }

                Tela.Imprimirtabuleiro(partida.Tab);
            }
            catch(TabuleiroException e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
