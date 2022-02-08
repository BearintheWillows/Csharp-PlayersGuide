namespace Csharp_PlayersGuide.Rock_Paper_Scissors;

public class Player
{
    public int Score { get; set; }

    public Action ChooseAction()
    {
        Array values = Enum.GetValues(typeof(Action));
        Random randomNum = new Random();
        Action randomAction = (Action) values.GetValue(randomNum.Next(3));

        return randomAction;
    }
}