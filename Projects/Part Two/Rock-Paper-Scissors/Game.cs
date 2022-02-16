using System.Security.Cryptography;

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
        do

        {
            SetRound();
            PlayRound(P1.ChooseAction(), P2.ChooseAction());
            Console.WriteLine();
            Console.WriteLine("Scores: ");
            Console.WriteLine();
            Console.WriteLine($"Player One Score: {P1.Score}");
            Console.WriteLine($"Player Two Score: {P2.Score}");
            Console.WriteLine();
        } while (Round != 6);

        CheckWinner();
    }

    private void SetRound()
    {
        Console.WriteLine($"Starting Round: {Round}");
        Round++;
    }

    private void PlayRound(Action P1Action, Action P2Action)
    {
        if (P1Action == Action.Rock && P2Action == Action.Scissors ||
            P1Action == Action.Scissors && P2Action == Action.Paper ||
            P1Action == Action.Paper && P2Action == Action.Rock)
        {
            Console.WriteLine($"Player one chooses: {P1Action}");
            Console.WriteLine($"Player Two chooses: {P2Action}");
            Console.WriteLine("***        Player One Wins Round        ***");

            P1.Score++;
        }
        else if (P1Action == P2Action)
        {
            Console.WriteLine($"Player one chooses: {P1Action}");
            Console.WriteLine($"Player Two chooses: {P2Action}");
            Console.WriteLine("       ***        Draw. No points awarded      ***");
        }
        else
        {
            Console.WriteLine($"Player one chooses: {P1Action}");
            Console.WriteLine($"Player Two chooses: {P2Action}");
            Console.WriteLine("     ***        Player Two Wins Round        ***");

            P2.Score++;
        }
    }

    private void CheckWinner()
    {
        if (Round == 6)
        {
            if (P1.Score > P2.Score)
            {
                Console.WriteLine("Player 1 Wins the Game!");
            }
            else if (P1.Score == P2.Score)
            {
                Console.WriteLine("Game is a Draw!");
            }
            else
            {
                Console.WriteLine("Player 2 Wins the Game!");
            }
        }
    }
}