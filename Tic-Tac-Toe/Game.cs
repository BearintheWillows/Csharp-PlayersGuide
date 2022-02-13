namespace Csharp_PlayersGuide.Tic_Tac_Toe;

public class Game
{
    private Board  Board          { get; } = new Board();
    private Player PlayerOne      { get; } = new Player();
    private Player PlayerTwo      { get; } = new Player();
    public  Player ActivePlayer   { get; private set; }
    private Player InactivePlayer { get; set; }
 

    public Game()
    {
        PlayerOne.Name = "Player One";
        PlayerTwo.Name = "Player Two";
        SetUpGame();
        PlayGame();
    }

    private void SetUpGame()
    {
        Console.WriteLine("Randomising Starting PLayer...");
        RandomiseStartingPlayer();
        Console.WriteLine($"{ActivePlayer.Name}, you go first!");
        Console.WriteLine("Choose a symbol: Press X or O on your keyboard now");
        ActivePlayer.ChooseSymbol();
        AssignSymbol();
        Console.WriteLine($"You've chosen: {ActivePlayer.Symbol}. {InactivePlayer.Name}, you are {InactivePlayer.Symbol}.");
    }

    private void PlayGame()
    {
        int round = 0;
        bool winner = false;
        
        Console.Clear();
        Console.WriteLine("To Play, choose a square by pressing the corresponding" +
                          " square number on your keyboard as shown below");
        Board.RenderBoard(BoardRender.DisplayNumbers);
        do
        {
            Console.WriteLine();
            Console.WriteLine($" --- Round {round} Starts ---");
                    Console.WriteLine($"{ActivePlayer.Name} Choose A square: ");
                    Board.ChangeState(Console.ReadKey(true).Key, ActivePlayer);
                    Board.RenderBoard(BoardRender.CurrentState);
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Here's the current board");
                    Board.RenderBoard(BoardRender.CurrentState);
                    changePlayer();
                    round++;
                    checkWinner();
        } while (!winner);
        
            
    }

    private void checkWinner()
    {
        Symbols symbol1;
        Symbols symbol2;
        Symbols symbol3;
        for (var index0 = 0; index0 < Board.BoardState.GetLength(0); index0++)
            for (var index1 = 0; index1 < Board.BoardState.GetLength(1); index1++)
            {
                Console.WriteLine(Board.BoardState[index0, index1]);

            }
    }

    public void AssignSymbol()
    {
        InactivePlayer.Symbol = ActivePlayer.Symbol == Symbols.X ? Symbols.O : Symbols.X;
    }

    private void changePlayer()
    {
        ActivePlayer = ActivePlayer == PlayerOne ? PlayerTwo : PlayerOne;
    }

    private void setActivePlayer(Player player)
    {
        ActivePlayer = player;
        InactivePlayer = ActivePlayer == PlayerOne ? PlayerTwo : PlayerOne;
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