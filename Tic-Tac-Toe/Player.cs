namespace Csharp_PlayersGuide.Tic_Tac_Toe;
using System.Windows.Input;


public class Player
{
    public        string  Name   { get; set; }
    public        Symbols Symbol { get; set; }



    public void chooseSymbol()
    {
        if (Console.ReadKey(true).Key == ConsoleKey.X)
        {
            Symbol = Symbols.X;
        }
        else
        {
            Symbol = Symbols.O;
        }
    }
}