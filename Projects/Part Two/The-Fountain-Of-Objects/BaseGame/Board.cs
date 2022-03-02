using The_Fountain_Of_Objects.BaseGame.Enums;

namespace The_Fountain_Of_Objects.BaseGame;

public class Board
{
    public RoomType[,] BoardState { get; init; } = new RoomType[4, 4];

    public Board()
    {
        foreach (var room in BoardState)
        {
            BoardState.room = RoomType.Empty;
        }
        BoardState[0, 0] = RoomType.Entrance;
        BoardState[0, 2] = RoomType.Fountain;
    }
}

