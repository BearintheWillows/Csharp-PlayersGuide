namespace Csharp_PlayersGuide.Rock_Paper_Scissors;

public class Player
{
    public int Score { get; set; }

    public static void ChooseAction()
    {
        Array values = Enum.GetValues(typeof(Action));
        Random randomNum = new Random(3);
        Action randomAction = (Action) values.GetValue(randomNum.Next(values.Length - 1))!;
Console.WriteLine(randomAction);
    
    }
}