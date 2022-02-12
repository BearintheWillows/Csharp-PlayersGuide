namespace Csharp_PlayersGuide.Tic_Tac_Toe;

public class Game
{
    private Board   Board              { get; } = new Board();
    private Player  PlayerOne          { get; } = new Player();
    private Player  PlayerTwo          { get; } = new Player();
    private Player  ActivePlayer       { get; set; }
    private string? ActivePlayerString { get; set; }

    public Game()
    {
        PlayerOne.Name = "Player One";
        PlayerTwo.Name = "Player Two";
        Console.WriteLine("Randomising Starting PLayer...");
        RandomiseStartingPlayer();
        Console.WriteLine($"{ActivePlayer.Name}, you go first!");
        Console.WriteLine("Choose a symbol: Press X or O on your keyboard now");
        ActivePlayer.chooseSymbol();
        Console.WriteLine($"You've chosen: {ActivePlayer.Symbol}");
    }


    private void changePlayer()
    {
        if (ActivePlayer == PlayerOne)
        {
            ActivePlayer = PlayerTwo;
        }
        else
        {
            ActivePlayer = PlayerOne;
        }
    }

    private void setActivePlayer(Player player)
    {
        ActivePlayer = player;
    }

    private void RandomiseStartingPlayer()
    {
        Random randomNum = new Random();
        int randomNumber = randomNum.Next(2);

        if (randomNumber == 1)
        {
            setActivePlayer(PlayerOne);
        }
        else
        {
            setActivePlayer(PlayerTwo);
        }
    }
}