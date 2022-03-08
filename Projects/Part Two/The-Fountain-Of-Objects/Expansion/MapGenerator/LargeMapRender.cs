using The_Fountain_Of_Objects.BaseGame;
using The_Fountain_Of_Objects.BaseGame.Enums;

namespace The_Fountain_Of_Objects.Expansion.MapGenerator;

public class LargeMapRender : MapRender
{
    private readonly string _rowLine = "-|---|---|---|---|---|---|---|---|-";
    private readonly string _colLine = "|";
    private readonly string _marker = "X";
    private readonly string _emptySquare = "   ";



    public LargeMapRender(RoomType[,] mapState, PlayerPosition playerPosition, bool gamewin) : base(mapState, playerPosition, gamewin)
    {
        Render(mapState, playerPosition, gamewin);
    }

    public override void Render(RoomType[,] mapState, PlayerPosition playerPosition, bool gameWin)
    {

        OutputColour.Change(OutputType.Neutral);


        Console.Write("                     - Minimap -");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("                        North");

        for (int i = 0; i < mapState.GetLength(0); i++)
        {
            RenderRows(i);

            Console.Write($"{_colLine,12}");

            for (int j = 0; j < mapState.GetLength(1); j++)
            {
                RenderColumn(i, j, mapState, playerPosition);
            }


            if (i == 7)
            {
                Console.WriteLine();
                Console.WriteLine($"{_rowLine,45}");
                Console.WriteLine();
                Console.WriteLine("                         South");
            }
        }


        if (gameWin)
        {
            OutputColour.Change(OutputType.Winner);
        }
    }


    internal override void RenderRows(int index)
    {
        Console.WriteLine();
        if (index == 4)
        {
            Console.WriteLine($"   West   {_rowLine,3}   East");
        }
        else
        {
            Console.WriteLine($"{_rowLine,45}");
        }
    }

    internal override void RenderColumn(int i, int j, RoomType[,] mapState, PlayerPosition playerPosition)
    {
        if (i == playerPosition.Row && j == playerPosition.Column)
        {
            if (mapState[i, j] == RoomType.Fountain || mapState[i, j] == RoomType.Entrance)
            {
                OutputColour.Change(OutputType.UniqueRoom);
                Console.Write($" {_marker} ");
                OutputColour.Change(OutputType.Neutral);
                Console.Write(_colLine);


            }
            else
            {
                Console.Write($" {_marker} {_colLine}");
            }
        }
        else
        {
            Console.Write($"{_colLine,4}");
        }
    }

}