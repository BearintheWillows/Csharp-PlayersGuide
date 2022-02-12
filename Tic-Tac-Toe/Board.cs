namespace Csharp_PlayersGuide.Tic_Tac_Toe;

public class Board
{
    public BoardSquare?[,] _boardState;


    public Board()
    {
        BoardSquare[,] _boardState = new BoardSquare[3, 3];
        _boardState[0, 0] = BoardSquare.X;
        BoardSquare response;
        string blank = " ";
        for (var index0 = 0; index0 < _boardState.GetLength(0); index0++)
        {
            Console.WriteLine();
            Console.WriteLine("-----|-----------|-------");
            for (var index1 = 0; index1 < _boardState.GetLength(1); index1++)
            {
                Console.Write($"{_boardState[index0, index1]} - ");
                if (_boardState[index0, index1] == BoardSquare.Empty)
                {
                    if (Enum.TryParse(blank, out response))
                    {
                        _boardState[index0, index1] = BoardSquare.X;
                    }
                }

                
                Console.Write($"{_boardState[index0, index1]} | ");
            }
        }
    }
}