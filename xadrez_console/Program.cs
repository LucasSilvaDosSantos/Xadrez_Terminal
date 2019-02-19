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
                    try
                    {
                        Console.Clear();
                        Tela.Imprimirtabuleiro(partida.Tab);
                        Console.WriteLine();
                        Console.WriteLine($"Truno: {partida.Turno}");
                        Console.WriteLine($"Aguardando Jogada: {partida.JogadorAtual}");

                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPossicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.Tab.PosPeca(origem).MovimentosPossiveis();

                        Console.Clear();
                        Tela.Imprimirtabuleiro(partida.Tab, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaoDeDestino(origem, destino);

                        partida.RealizaJogada(origem, destino);
                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
            }
            catch(TabuleiroException e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
