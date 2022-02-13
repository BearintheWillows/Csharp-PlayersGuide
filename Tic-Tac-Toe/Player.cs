namespace Csharp_PlayersGuide.Tic_Tac_Toe;
using System.Windows.Input;


public class Player
{
    public        string  Name   { get; set; }
    public        Symbols Symbol { get; set; }



    public void ChooseSymbol()
    {
        var input = Console.ReadKey(true).Key;

        switch (input)
        {
            case ConsoleKey.X:
                Symbol = Symbols.X;
                break;
            case ConsoleKey.O:
                Symbol = Symbols.O;
                break;
            default:
                Console.WriteLine("Please press X or O on your keyboard now");
                break;
        }
    }
}