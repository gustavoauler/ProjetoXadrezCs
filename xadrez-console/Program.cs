﻿
using xadrez_console;
using xadrez_console.tabuleiro;

internal class Program

{
    private static void Main(string[] args)
    {
        Tabuleiro tab = new Tabuleiro(8,8);

        Tela.ImprimirTabuleiro(tab);

    }
}