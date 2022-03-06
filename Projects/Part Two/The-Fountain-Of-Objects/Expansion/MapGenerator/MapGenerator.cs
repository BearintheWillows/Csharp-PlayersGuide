using The_Fountain_Of_Objects.BaseGame.Enums;

namespace The_Fountain_Of_Objects.Expansion.MapGenerator;
public class MapGenerator
{
    public RoomType[,] MapState { get; set; }
    public bool FountainActive { get; private set; }

    public MapGenerator(int Row, int Column)
    {
        //Create two-dimensional array to simulate the game board.
        MapState = new RoomType[Row,Column];
        for (int i = 0; i < MapState.GetLength(0); i++)
        {
            for (int j = 0; j < MapState.GetLength(1); j++)
            {
                MapState[i, j] = RoomType.Empty;
            }
        }

        MapState[0, 0] = RoomType.Entrance;
        MapState[0, 2] = RoomType.Fountain;
        int loop = 0;
        foreach (var item in MapState)
        {
            Console.WriteLine(loop);
            loop++;
        }
    }
}
