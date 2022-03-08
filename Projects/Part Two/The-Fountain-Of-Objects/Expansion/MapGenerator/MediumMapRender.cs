using The_Fountain_Of_Objects.BaseGame;
using The_Fountain_Of_Objects.BaseGame.Enums;

namespace The_Fountain_Of_Objects.Expansion.MapGenerator;

public class MediumMapRender : MapRender
{
    private readonly string _rowLine = "-|---|---|---|---|---|---|-";
    private readonly string _colLine = "|";
    private readonly string _marker = "x";
   
    



    public MediumMapRender(RoomType[,] mapState, PlayerPosition playerPosition, bool gamewin) : base(mapState, playerPosition, gamewin)
    {
        Render(mapState, playerPosition, gamewin);
    }

    public override void Render(RoomType[,] mapState, PlayerPosition playerPosition, bool gameWin)
    {

        OutputColour.Change(OutputType.Neutral);


        Console.Write("                          - Minimap -");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("                             North");

        for (int i = 0; i < mapState.GetLength(0); i++)
        {
            RenderRows(i);

            Console.Write($"{_colLine, 20}");

            for (int j = 0; j < mapState.GetLength(1); j++)
            {
                RenderColumn(i, j, mapState, playerPosition);
            }


            if (i == 5)
            {
                Console.WriteLine();
                Console.WriteLine($"{_rowLine,45}");
                Console.WriteLine();
                Console.WriteLine("                             South");
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
        Console.WriteLine(index == 3 ? $"           West   {_rowLine,3}   East" : $"{_rowLine,45}");
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