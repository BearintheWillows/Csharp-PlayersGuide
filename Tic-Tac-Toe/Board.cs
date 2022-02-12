namespace Csharp_PlayersGuide.Tic_Tac_Toe;

public class Board
{
    private Symbols?[,] BoardState = new Symbols?[3, 3];


    public void ChangeState(Symbols symbol, int row, int column)
    {
        BoardState[row, column] = symbol;

        foreach (var VARIABLE in BoardState)
        {
            Console.WriteLine(VARIABLE);
        }

        RenderBoard();
    }

    //Renders the board in console based on contents of BoardState Array
    private void RenderBoard()
    {
        // Create the layout of the horizontal lines and spaces between each row
        for (var index0 = 0; index0 < BoardState.GetLength(0); index0++)
        {
            if (index0 >= 1)
            {
                Console.WriteLine();
                Console.WriteLine("---|---|---");
            }
            
            //Loops between each column item.
            for (var index1 = 0; index1 < BoardState.GetLength(1); index1++)
            {
                if (index1 == 0)
                {
                    Console.Write(" ");
                }
                
                //Sets the item to an empty string if Boarsquare.Empty is detected.
                //Sets the blank spaces
                if (BoardState[index0, index1] == Symbols.Empty)
                {
                    BoardState[index0, index1] = null;
                }
                
                Console.Write(BoardState[index0, index1]);
                
                //Sets the vertical layout lines depending on whether 
                // the item is empty or has a symbol ( X or O )
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