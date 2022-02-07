namespace Csharp_PlayersGuide.Rock_Paper_Scissors;

public class Game
{
    private int    Round { get; set; }
    private Player P1    { get; set; }
    private Player P2    { get; set; }

    public Game(Player player1, Player player2)
    {
        P1 = player1;
        P2 = player2;
        SetRound();
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