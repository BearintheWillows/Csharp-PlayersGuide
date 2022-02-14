namespace Csharp_PlayersGuide.Tic_Tac_Toe;

public class Board
{
    public Symbols?[,] BoardState       = new Symbols?[3, 3];
    private int[,]      BoardNumberState = new int[3, 3];

    //Changes the corresponding Array value to the ActivePlayers symbol
    public void ChangeState(ConsoleKey squareNumber, Player activePlayer)
    {
        switch (squareNumber)
        {
            case ConsoleKey.D0:
                if (CheckSquare(activePlayer, 0, 0))
                {
                    BoardState[0, 0] = activePlayer.Symbol;
                } 
                break;
            case ConsoleKey.D1:
                if (CheckSquare(activePlayer, 0, 1))
                {
                   BoardState[0, 1] = activePlayer.Symbol; 
                }
                break;
            case ConsoleKey.D2:
                if (CheckSquare(activePlayer, 0, 2))
                {
                  BoardState[0, 2] = activePlayer.Symbol;  
                }
                break;
            case ConsoleKey.D3:
                if (CheckSquare(activePlayer, 1, 0))
                {
                  BoardState[1, 0] = activePlayer.Symbol;  
                }
                break;
            case ConsoleKey.D4:
                if (CheckSquare(activePlayer, 1, 1))
                {
                    BoardState[1, 1] = activePlayer.Symbol;
                }
                break;
            case ConsoleKey.D5:
                if (CheckSquare(activePlayer, 1, 2))
                {
                   BoardState[1, 2] = activePlayer.Symbol; 
                }
                break;
            case ConsoleKey.D6:
                if (CheckSquare(activePlayer, 2, 0))
                {
                   BoardState[2, 0] = activePlayer.Symbol; 
                }
                break;
            case ConsoleKey.D7:
                if (CheckSquare(activePlayer, 2, 1)  )
                {
                  BoardState[2, 1] = activePlayer.Symbol;
                }
                break;
            case ConsoleKey.D8:
                if (CheckSquare(activePlayer, 2, 2))
                {
                  BoardState[2, 2] = activePlayer.Symbol;  
                }
                break;
        }
    }

    //Checks to see if the elected square already has a value != null
    private bool CheckSquare(Player activePlayer, int column, int row)
    {
        if (BoardState[column, row] != Symbols.Empty && BoardState[column, row] != null)
        {
            Console.WriteLine("Square occupied. Please choose again");
            ChangeState(Console.ReadKey(true).Key, activePlayer);
            return false;
        }

        return true;
    }

    //Renders the board in console based on contents of BoardState Array.
    /** Board Squares. Visualised as:
 *         Nw = 0  | N = 1  | Ne = 2
 *        --------------------------
 *         W = 3   | C = 4  | E = 5
 *        --------------------------
 *         E = 6   | s = 7  | Se = 8         
 */

    public void RenderBoard(BoardRender renderType)
    {
        int boardNumber = 0;
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

                //Sets the item to an empty string if BoardSquare.Empty is detected.
                //Sets the blank spaces

                if (renderType == BoardRender.DisplayNumbers)
                {
                    BoardNumberState[index0, index1] = boardNumber;
                    if (BoardState[index0, index1] == Symbols.Empty || BoardState[index0, index1] == null)
                    {
                        boardNumber++;

                        Console.Write(BoardNumberState[index0, index1]);
                    }
                }
                else if (renderType == BoardRender.CurrentState)
                {
                    if (BoardState[index0, index1] == Symbols.Empty)
                    {
                        BoardState[index0, index1] = null;
                        Console.Write(BoardState[index0, index1]);
                    }
                }

                Console.Write(BoardState[index0, index1]);
                //Sets the vertical layout lines depending on whether 
                // the item is empty or has a symbol ( X or O )
                if (index1 < 2 && BoardState[index0, index1] == null)
                {
                    Console.Write("  | ");
                }
                else if (index1 < 2 || index1 < 2 && BoardNumberState[index0, index1] == boardNumber)
                {
                    Console.Write(" | ");
                }
            }
        }
    }
}