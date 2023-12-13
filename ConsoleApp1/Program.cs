///layout do jogo 
string[,] jogo = {
{"#", "#", "#" },
{"#", "#", "#" },
{"#", "#", "#" },
};

string jogador = "x";
bool jogadavalida = false;
bool partida = true;
bool vencedor = false;
int[] layout = { 1, 2, 3 };



while (partida == true)
{
    Console.Write("\n C:");

        for (int i = 0; i < jogo.GetLength(0); i++)
        {
            Console.Write($" {layout[i]}  ");
        }
        Console.WriteLine();
        for (int i = 0; i < jogo.GetLength(0); i++)
        {
            Console.Write($"L:{layout[i]}");
            Console.WriteLine($" {jogo[i, 0]}   {jogo[i, 1]}   {jogo[i, 2]}");
        }

    // Troca de Jogador
    Console.WriteLine("_______________________");

    Console.WriteLine($"\nVez do Jogador:{jogador}");
    Console.Write("Jogar na Linha:");
    int jogadac = int.Parse(Console.ReadLine()) - 1;

    Console.Write("Na Coluna:");
    int jogadal = int.Parse(Console.ReadLine()) - 1;

    do {
            if (jogo[jogadac, jogadal] == "#" && jogador == "x")
            {
                jogo[jogadac, jogadal] = jogador;
                jogadavalida = true;
                jogador = "o";
                Console.Clear();
            }
            else if (jogo[jogadac, jogadal] == "#" && jogador == "o")
            {
                jogo[jogadac, jogadal] = jogador;
                jogadavalida = true;
                jogador = "x";
                Console.Clear();
            }
            else
            {
            Console.Clear();
                Console.WriteLine("Jogada Invalida");
            }
        } while (jogadavalida == false);

    //conferir se alguem já venceu   
    if ((jogo[0, 0] == "x" && jogo[0, 1] == "x" && jogo[0, 2] == "x") ||
        (jogo[1, 0] == "x" && jogo[1, 1] == "x" && jogo[1, 2] == "x") ||
        (jogo[2, 0] == "x" && jogo[2, 1] == "x" && jogo[2, 2] == "x") ||
        (jogo[0, 0] == "x" && jogo[1, 0] == "x" && jogo[2, 0] == "x") ||
        (jogo[0, 1] == "x" && jogo[1, 1] == "x" && jogo[2, 1] == "x") ||
        (jogo[0, 2] == "x" && jogo[1, 2] == "x" && jogo[2, 2] == "x") ||
        (jogo[0, 0] == "x" && jogo[1, 1] == "x" && jogo[2, 2] == "x") ||
        (jogo[0, 2] == "x" && jogo[1, 1] == "x" && jogo[2, 0] == "x"))
    {
        Console.WriteLine("Jogador X venceu!!");
        vencedor = true;
        partida = false;
    }
    else if ((jogo[0, 0] == "o" && jogo[0, 1] == "o" && jogo[0, 2] == "o") ||
        (jogo[1, 0] == "o" && jogo[1, 1] == "o" && jogo[1, 2] == "o") ||
        (jogo[2, 0] == "o" && jogo[2, 1] == "o" && jogo[2, 2] == "o") ||
        (jogo[0, 0] == "o" && jogo[1, 0] == "o" && jogo[2, 0] == "o") ||
        (jogo[0, 1] == "o" && jogo[1, 1] == "o" && jogo[2, 1] == "o") ||
        (jogo[0, 2] == "o" && jogo[1, 2] == "o" && jogo[2, 2] == "o") ||
        (jogo[0, 0] == "o" && jogo[1, 1] == "o" && jogo[2, 2] == "o") ||
        (jogo[0, 2] == "o" && jogo[1, 1] == "o" && jogo[2, 0] == "o"))
    {
        Console.WriteLine("Jogador O venceu!!");
        vencedor = true;
        partida = false;
    }

}
if(vencedor == false)
{
    Console.WriteLine("Empate!");
}