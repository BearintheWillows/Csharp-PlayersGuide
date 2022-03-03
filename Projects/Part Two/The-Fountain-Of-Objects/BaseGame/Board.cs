using System.Globalization;
using The_Fountain_Of_Objects.BaseGame.Enums;

namespace The_Fountain_Of_Objects.BaseGame;

public class Board
{
    public RoomType[,] BoardState { get; set; } = new RoomType[4, 4];

    public Board()
    {
        for (int i = 0; i < BoardState.GetLength(0); i++)
            for (int j = 0; j < BoardState.GetLength(1); j++)
            {
                BoardState[i, j] = RoomType.Empty;
                // Console.WriteLine($"Boardstate [{i}, {j}] is {BoardState[i, j]}");
            }

        BoardState[0, 0] = RoomType.Entrance;
        BoardState[0, 2] = RoomType.Fountain;
    }

    public PlayerPosition SetCurrentPosition(string heading, PlayerPosition playerPosition)
    {
        //Creates a Culture info obj
        TextInfo myTI = new CultureInfo("en-UK", false).TextInfo;

        // Converts heading to a title case to match Enum
        heading = myTI.ToTitleCase(heading);

        //Parses heading and converts to applicable Enum.
        Enum.TryParse(heading, out Heading newHeading);

        switch (newHeading)
        {
            case Heading.North:
                if (playerPosition.Row > 0)
                {
                    playerPosition =
                        new PlayerPosition(playerPosition.Row - 1, playerPosition.Column);
                }
                else
                {
                    Console.WriteLine("You can't move any further north");
                }
                break;

            case Heading.East:
                if (playerPosition.Column < 3)
                {
                    playerPosition =
                        new PlayerPosition(playerPosition.Row, playerPosition.Column + 1);
                }
                else
                {
                    Console.WriteLine("You can't move further East.");
                }
                break;

            case Heading.South:
                if (playerPosition.Row < 3)
                {
                    playerPosition =
                        new PlayerPosition(playerPosition.Row + 1, playerPosition.Column);
                }
                else
                {
                    OutputColour.Change(OutputType.Warning);
                    Console.WriteLine("You can't move further South.");
                }
                break;

            case Heading.West:
                if (playerPosition.Column > 0)
                {
                    playerPosition =
                        new PlayerPosition(playerPosition.Row, playerPosition.Column - 1);
                }
                else
                {
                    Console.WriteLine("You can't move further West.");
                }
                break;

            default:
                Console.WriteLine("You Can't go that way young padawan");
                break;
        }
        return playerPosition;

    }
}