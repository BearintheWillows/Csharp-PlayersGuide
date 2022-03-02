using The_Fountain_Of_Objects.BaseGame.Enums;

namespace The_Fountain_Of_Objects.BaseGame;

public class Board
{
    public RoomType[,]    BoardState      { get; set; } = new RoomType[4, 4];
    public PlayerPosition CurrentPlayerPosition { get; set; } = new(0, 0);

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

    public void SetCurrentPosition(Heading heading)
    {
        switch (heading)
        {
            case Heading.North:
                if (CurrentPlayerPosition.Row > 0)
                {
                    CurrentPlayerPosition =
                        new PlayerPosition(CurrentPlayerPosition.Row - 1, CurrentPlayerPosition.Column);
                }
                else
                {
                    Console.WriteLine("You can't move any further north");
                }
                break;
            case Heading.East:
                if (CurrentPlayerPosition.Column < 3)
                {
                    CurrentPlayerPosition =
                        new PlayerPosition(CurrentPlayerPosition.Row, CurrentPlayerPosition.Column + 1);
                }
                break;
            case Heading.South:
                if (CurrentPlayerPosition.Row < 3)
                {
                    CurrentPlayerPosition =
                        new PlayerPosition(CurrentPlayerPosition.Row + 1, CurrentPlayerPosition.Column);
                }

                break;
            case Heading.West:
                if (CurrentPlayerPosition.Column > 0)
                {
                    CurrentPlayerPosition =
                        new PlayerPosition(CurrentPlayerPosition.Row, CurrentPlayerPosition.Column - 1);
                }
                break;
            default:
                Console.WriteLine("You Can't go that way young padawan");
                break;
        }
        Console.WriteLine(CurrentPlayerPosition);
    }
}