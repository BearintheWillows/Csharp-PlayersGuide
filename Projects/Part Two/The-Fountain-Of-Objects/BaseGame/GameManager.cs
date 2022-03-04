using The_Fountain_Of_Objects.BaseGame.Enums;

namespace The_Fountain_Of_Objects.BaseGame
{
    public class GameManager
    {
        public Board Board { get; set; } = new();
        public PlayerPosition PlayerPosition { get; set; } = new(0, 0);
        private bool _gameWin = false;
        private BoardRender _boardRender = new BoardRender();

        public void Run()
        {
            do
            {
                _boardRender.Render(Board.BoardState, PlayerPosition);
                Console.WriteLine("!- - - - - - - - - - - - - ************ - - - - - - - - - - - - - -!");
                OutputColour.Change(OutputType.Story);
                Console.WriteLine($"You are in the room at {PlayerPosition.ToString().Remove(0, 15)}");
                if (GetSense() != null)
                {
                    Console.WriteLine(GetSense());
                }
                OutputColour.Change(OutputType.Neutral);

                if (PlayerPosition.Row == 0 && PlayerPosition.Column == 2)
                {
                    Console.WriteLine("What do you wish to do?");
                }
                else
                {
                    Console.Write("Where are you moving to? ");
                }

                PlayerPosition = Board.ChooseAction(Console.ReadLine().ToLower(), PlayerPosition);
                OutputColour.Change(OutputType.Neutral);
                CheckWin();
            } while (!_gameWin);
        }

        public string? GetSense()
        {
            if (PlayerPosition.Column == 0 && PlayerPosition.Row == 0)
            {
                return Sense.See(true);
            }
            else if (PlayerPosition.Column == 2 && PlayerPosition.Row == 0)
            {
                return Sense.Hear(Board.FountainActive);
            }
            else if ((PlayerPosition.Row == 0 && PlayerPosition.Column == 1) || (PlayerPosition.Column == 0 && PlayerPosition.Column == 1))
            {
                return Sense.See(false);
            }
            return null;
        }

        private void CheckWin()
        {
            if (PlayerPosition.Row == 0 && PlayerPosition.Column == 0 && Board.FountainActive )
            {
                OutputColour.Change(OutputType.Winner);
                _gameWin = true;
                Console.WriteLine("!- - - - - - - - - - - - - - WINNER - - - - - - - - - - - - - - - -!");
                Console.WriteLine($"You are in the room at {PlayerPosition.ToString().Remove(0, 15)}");
                Console.WriteLine("You have escaped with your life and the fountain is finally activated!");
                Console.WriteLine("You Win!")

        ;
            }
        }
    }
}