
using xadrez_console;
using xadrez_console.tabuleiro;
using xadrez_console.xadrez;

internal class Program

{
    private static void Main(string[] args)
    {
        try
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(1, 2));
            tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));
            tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(2, 5));

            Tela.ImprimirTabuleiro(tab);
        }
        catch(TabuleiroException ex) {

            Console.WriteLine(ex.Message);
        }

    }
}