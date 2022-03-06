using The_Fountain_Of_Objects.BaseGame.Enums;

namespace The_Fountain_Of_Objects.Expansion.MapGenerator;
public static class MapGenerator
{
    public static RoomType[,] Generate(int Row, int Column, RoomType[,] mapState)
    {
        //Create two-dimensional array to simulate the game board.
        mapState = new RoomType[Row,Column];
        for (int i = 0; i < mapState.GetLength(0); i++)
        {
            for (int j = 0; j < mapState.GetLength(1); j++)
            {
                mapState[i, j] = RoomType.Empty;
            }
        }

        mapState[0, 0] = RoomType.Entrance;
        mapState[0, 2] = RoomType.Fountain;

        return mapState;
    }
}
