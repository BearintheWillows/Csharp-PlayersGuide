
namespace Room_Coordinates;

public struct Coordinate
{
    public int Row    { get; init; }
    public int Column { get; init; }
    
    public Coordinate(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public static bool CheckCoord(Coordinate coordinate1, Coordinate coordinate2)
    {
        bool response = coordinate1.Row == coordinate2.Row + 1 
                        || coordinate1.Row == coordinate2.Row - 1 
                        || coordinate1.Column == coordinate2.Column + 1 
                        || coordinate1.Column == coordinate2.Column - 1;

        return response;
    }
}