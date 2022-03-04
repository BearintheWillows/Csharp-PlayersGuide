using The_Fountain_Of_Objects.BaseGame.Enums;

namespace The_Fountain_Of_Objects.BaseGame;

public static class Sense
{
    public static string Hear(bool fountainActive)
    {
        OutputColour.Change(OutputType.UniqueRoom);
        return fountainActive ? "You hear the rushing waters from the Fountain of Objects. It has been reactivated!" : "You hear water dripping. The Fountain of Objects is here!";
    }

    public static string See(bool inEntrance)
    {
        OutputColour.Change(OutputType.UniqueRoom);
        return inEntrance ? "You see light coming from outside the cavern. This is the entrance" : "You see light coming from the cavern entrance. It is near.";
    }
}