﻿using tabuleiro;
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

                Tela.Imprimirtabuleiro(partida.Tab);
            }
            catch(TabuleiroException e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
