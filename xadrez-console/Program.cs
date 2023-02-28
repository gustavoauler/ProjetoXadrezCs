
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

                try
                {
                    Console.Clear();
                    Tela.ImprimirPartida(partida);
                   

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                    partida.ValidarPosicaoDeOrigem(origem);


                    bool[,] posicoesPossiveis = partida.tab.Peca(origem).MovimentosPossiveis();
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.tab, posicoesPossiveis);


                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
                    partida.ValidarPosicaoDeDestino(origem,destino);

                    partida.RealizaJogada(origem, destino);

                }
                catch(TabuleiroException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                }

            }


        }
        catch (TabuleiroException ex)
        {

            Console.WriteLine(ex.Message);
        }

    }
}