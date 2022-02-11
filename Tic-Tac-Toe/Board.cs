namespace Csharp_PlayersGuide.Tic_Tac_Toe;

public class Board{
     public BoardSquare[,] Board { get; private set; }
     public Board(BoardSquare[] board)
     {
          Board = new BoardSquare[];
     }

     
}

/** Board Squares. Visualised as:
 *         Nw = 0  | N = 1  | Ne = 2
 *        --------------------------
 *         W = 5   | C = 4  | E = 3
 *        --------------------------
 *         E = 6   | s = 7  | Se = 8         
 */

enum BoardSquare
{
     Nw,
     N,
     Ne,
     E,
     C,
     W,
     Sw,
     S,
     Se
}





