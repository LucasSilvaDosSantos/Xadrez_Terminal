using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            /*PosicaoXadrez pos = new PosicaoXadrez('a', 1);

            System.Console.WriteLine(pos);

            System.Console.WriteLine(pos.ToPosicao());
            */
            try
            {


                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 7));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(1, 2));

                

                Tela.Imprimirtabuleiro(tab);
            }
            catch(TabuleiroException e)
            {
                System.Console.WriteLine(e.Message);
            }


        }
    }
}
