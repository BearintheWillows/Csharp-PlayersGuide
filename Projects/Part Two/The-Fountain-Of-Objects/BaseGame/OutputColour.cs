

using The_Fountain_Of_Objects.BaseGame.Enums;

namespace The_Fountain_Of_Objects.BaseGame
{
    public static class OutputColour
    {

        public static void Change(OutputType type)
        {
            if (type == OutputType.Warning) Console.ForegroundColor = ConsoleColor.Red;
            if (type == OutputType.Neutral) Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
