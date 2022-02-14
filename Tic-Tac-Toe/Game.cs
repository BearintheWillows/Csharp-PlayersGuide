namespace Csharp_PlayersGuide.Tic_Tac_Toe;

public class Game
{
    private Board  Board          { get; } = new Board();
    private Player PlayerOne      { get; } = new Player();
    private Player PlayerTwo      { get; } = new Player();
    public  Player ActivePlayer   { get; private set; }
    private Player InactivePlayer { get; set; }
    private bool   GameWon        { get; set; } = false;


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
        Console.WriteLine(
            $"You've chosen: {ActivePlayer.Symbol}. {InactivePlayer.Name}, you are {InactivePlayer.Symbol}.");
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
            if (GameWon)
            {
                Console.Clear();
                Console.WriteLine($"Coongratulations! {ActivePlayer.Name} you have won!");
                Board.RenderBoard(BoardRender.CurrentState);
            }
        } while (!GameWon);
    }

    private void checkWinner()
    {
        Symbols?[][] winCheckArray = new Symbols?[4][];
        int column = 0;
        int row = 0;
        
        //Iterates 3 times, each time creates a new array of current BoardState Row
        //Checks if null is preset
        //Check if all values are the same
        for (int i = 0; i < 3; i++)
        {
            winCheckArray[0] = new[]
                {Board.BoardState[row, 0], Board.BoardState[row, 1], Board.BoardState[row, 2]};
          
            foreach (var VARIABLE in winCheckArray[0].Where(n => n != null))
            {
                if (winCheckArray[0].Distinct().Take(2).Count() == 1)
                {
                    GameWon = true;
                }
            }
            row++;
        }
        
        //Iterates 3 times, each time creates a new array of current BoardState Column
        //Checks if null is preset
        //Check if all values are the same
        for (int i = 0; i < 3; i++)
        {
            winCheckArray[1] = new[]
                {Board.BoardState[0, column], Board.BoardState[1, column], Board.BoardState[2, column]};
          
            foreach (var VARIABLE in winCheckArray[1].Where(n => n != null))
            {
                if (winCheckArray[1].Distinct().Take(2).Count() == 1)
                {
                    GameWon = true;
                }
            }
            column++;
        }

        // Creates new array with the Top left to Bottom right diagnol BoardState values
        //Checks if null present
        //Checks if all values are the same
        winCheckArray[2] = new[]
            {Board.BoardState[0, 0], Board.BoardState[1, 1], Board.BoardState[2, 2]};
        foreach (var VARIABLE in winCheckArray[2].Where(n => n != null))
        {
            if (winCheckArray[2].Distinct().Take(2).Count() == 1)
            {
                GameWon = true;
            }
        }
        
        // Creates new array with the Top right to Bottom left diagnol BoardState values
        //Checks if null present
        //Checks if all values are the same
        winCheckArray[3] = new[] {Board.BoardState[0, 2], Board.BoardState[1, 1], Board.BoardState[2, 0]};
        foreach (var VARIABLE in winCheckArray[3].Where(n => n != null))
        {
            if (winCheckArray[3].Distinct().Take(2).Count() == 1)
            {
                GameWon = true;
            }
        }
        
    }

    //Assigns the inactive player the opposite symbol to what the ActivePlayer chose
    public void AssignSymbol()
    {
        InactivePlayer.Symbol = ActivePlayer.Symbol == Symbols.X ? Symbols.O : Symbols.X;
    }

    //Changes the ActivePlayer based on which player is currently ActivePlayer
    private void changePlayer()
    {
        ActivePlayer = ActivePlayer == PlayerOne ? PlayerTwo : PlayerOne;
    }

    //Sets initial ActivePlayer
    private void setActivePlayer(Player player)
    {
        ActivePlayer = player;
        InactivePlayer = ActivePlayer == PlayerOne ? PlayerTwo : PlayerOne;
    }

    //Randomises which player starts first
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