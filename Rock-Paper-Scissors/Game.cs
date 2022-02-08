namespace Csharp_PlayersGuide.Rock_Paper_Scissors;

public class Game
{
    private Player P1    { get; set; }
    private Player P2    { get; set; }
    private int    Round { get; set; }
    
    public Game(Player player1, Player player2)
    {
        P1 = player1;
        P2 = player2;
        PlayGame();
    }

    private void PlayGame()
    {
        Action P1Action = P1.ChooseAction();
        Action P2Action = P2.ChooseAction();
        
        do
        {
            if (P1Action == Action.Rock && P2Action == Action.Scissors ||
                P1Action == Action.Scissors && P2Action == Action.Paper ||
                P1Action == Action.Paper && P2Action == Action.Rock)
            {
                P1.Score++;
            }
            else
            {
                P2.Score++;
            }
        } while (Round != 5);
    }

    private void SetRound()
    {
        if (Round != 5)
        {
            Console.WriteLine($"Starting Round: {Round}");
            Round++;
        }
    }

    private void PlayRound(Action player1Action, Action player2Action)
    {
        if (player1Action == Action.Rock && player2Action == Action.Scissors)
        {
            P1.Score++;
        }
    }
}