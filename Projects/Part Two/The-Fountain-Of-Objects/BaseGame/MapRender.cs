using The_Fountain_Of_Objects.BaseGame.Enums;

namespace The_Fountain_Of_Objects.BaseGame;

public abstract class MapRender
{
    private readonly string _rowLine;
    private readonly string _colLine;
    private readonly string _marker;

    public MapRender(RoomType[,] mapState, PlayerPosition playerPosition, bool gameWin) { }

    public abstract void Render(RoomType[,] mapState, PlayerPosition playerPosition, bool gameWin);

   internal abstract void RenderRows(int index);

   internal abstract void RenderColumn(int i, int j, RoomType[,] mapState, PlayerPosition playerPosition);
}






    