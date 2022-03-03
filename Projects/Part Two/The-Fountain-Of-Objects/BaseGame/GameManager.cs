using The_Fountain_Of_Objects.BaseGame.Enums;

namespace The_Fountain_Of_Objects.BaseGame
{
    public class GameManager
    {

        public Board Board { get; set; } = new();
        public PlayerPosition PlayerPosition { get; set; } = new(0,0);
        private bool _gameWin = false;

        public void Run()
        {
            do
            {
                Console.WriteLine("!- - - - - - - - - - - - - ************ - - - - - - - - - - - - - -!");
                Console.WriteLine($"You are in the room at {PlayerPosition.ToString().Remove(0, 15)}");
                Console.WriteLine(GetSense());
                Console.Write("Where are you moving to? ");
                PlayerPosition = Board.SetCurrentPosition(Console.ReadLine(), PlayerPosition);
                OutputColour.Change(OutputType.Neutral);
                
            } while (!_gameWin);

        }

        public string GetSense()
        {
            if (PlayerPosition.Column == 0 && PlayerPosition.Row == 0)
            {
                return Sense.See(true);
            }
            return Sense.See(false);
        }

    }
}