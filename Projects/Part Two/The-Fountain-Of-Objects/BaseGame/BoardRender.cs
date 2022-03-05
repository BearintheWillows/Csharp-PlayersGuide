using The_Fountain_Of_Objects.BaseGame.Enums;

namespace The_Fountain_Of_Objects.BaseGame
{
    public static class BoardRender
    {
        public static async void Render(RoomType[,] boardState, PlayerPosition playerPosition, bool gamewin)
        {
            OutputColour.Change(OutputType.Neutral);

            const string rowLine = "-|---|---|---|---|-";
            const string colLine = "|";
            const string marker = "x";
            Console.Write("                          - Minimap -");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                             North");

            for (int i = 0; i < boardState.GetLength(0); i++)
            {
                Console.WriteLine();
                if (i == 2)
                {
                    Console.WriteLine($"               West   {rowLine,3}   East");
                }
                else
                {
                    Console.WriteLine($"{rowLine,41}");
                }

                Console.Write($"{colLine,24}");

                for (int j = 0; j < boardState.GetLength(1); j++)
                {
                    if (i == playerPosition.Row && j == playerPosition.Column)
                    {
                        if (boardState[i, j] == RoomType.Fountain || boardState[i, j] == RoomType.Entrance)
                        {
                            OutputColour.Change(OutputType.UniqueRoom);
                            Console.Write($" {marker} ");
                            OutputColour.Change(OutputType.Neutral);
                            Console.Write(colLine);
                        }
                        else
                        {
                            Console.Write($" {marker} {colLine}");
                        }
                    }
                    else
                    {
                        Console.Write($"{colLine,4}");
                    }
                }

                if (i == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{rowLine,41}");
                    Console.WriteLine();
                    Console.WriteLine("                             South");
                }
            }

            if (gamewin)
            {
                OutputColour.Change(OutputType.Winner);
            }
        }
    }
}