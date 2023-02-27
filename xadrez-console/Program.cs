
using xadrez_console;
using xadrez_console.tabuleiro;
using xadrez_console.xadrez;

internal class Program

{
    private static void Main(string[] args)
    {
        try
        {
            PartidaDeXadrez partida = new PartidaDeXadrez();

            while (!partida.terminada)
            {
                Console.Clear();
                Tela.ImprimirTabuleiro(partida.tab);

                Console.WriteLine();

                Console.Write("Origem: ");
                Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();


                bool[,] posicoesPossiveis = partida.tab.Peca(origem).MovimentosPossiveis();
                Console.Clear();
                Tela.ImprimirTabuleiro(partida.tab,posicoesPossiveis);


                Console.WriteLine();
                Console.Write("Destino: ");
                Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

                partida.ExecutaMovimento(origem, destino);
            }


        }
        catch (TabuleiroException ex)
        {

            Console.WriteLine(ex.Message);
        }

    }
}