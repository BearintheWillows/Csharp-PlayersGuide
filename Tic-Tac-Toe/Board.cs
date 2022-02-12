namespace Csharp_PlayersGuide.Tic_Tac_Toe;

public class Board
{
    private BoardSquare?[,] BoardState = new BoardSquare?[3,3];
    

    public void ChangeState(BoardSquare symbol,int row, int column)
    {
        BoardState[row, column] = symbol;
        RenderBoard();
    }

    public void RenderBoard()
    {
        for (var index0 = 0; index0 < BoardState.GetLength(0); index0++)
        {
            if (index0 >= 1)
            {
                Console.WriteLine();
                Console.WriteLine("---|---|---");
            }
            
            for (var index1 = 0; index1 < BoardState.GetLength(1); index1++)
            {
                if (index1 == 0)
                {
                    Console.Write(" ");
                }

                BoardState[index0, index1] = null;
                
                Console.Write(BoardState[index0, index1]);
                if (index1 < 2 && BoardState[index0, index1] == null)
                {
                    Console.Write("  | ");
                }
                else if (index1 < 2)
                {
                    Console.Write(" | ");
                }
                
            }
        }
    }
}