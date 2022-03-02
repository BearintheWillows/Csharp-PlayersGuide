using The_Fountain_Of_Objects.BaseGame;

Console.WriteLine(Senses.See(false));

Board newBoard = new Board();

foreach (var VARIABLE in newBoard.BoardState)
{
    Console.WriteLine(VARIABLE);
}