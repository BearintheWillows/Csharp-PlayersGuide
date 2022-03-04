using The_Fountain_Of_Objects.BaseGame.Enums;

namespace The_Fountain_Of_Objects.BaseGame
{
    public static class OutputColour
    {

        public static void Change(OutputType type)
        {
            if (type == OutputType.Warning) Console.ForegroundColor = ConsoleColor.Red;
            if (type == OutputType.Neutral) Console.ForegroundColor = ConsoleColor.White;
            if (type == OutputType.UniqueRoom) Console.ForegroundColor = ConsoleColor.Blue;
            if (type == OutputType.Story) Console.ForegroundColor = ConsoleColor.Green;
            if (type == OutputType.Winner) Console.ForegroundColor = ConsoleColor.Yellow;
        }

    }
}