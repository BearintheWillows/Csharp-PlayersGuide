using The_Fountain_Of_Objects.BaseGame.Enums;
using The_Fountain_Of_Objects.Expansion.MapGenerator;

namespace The_Fountain_Of_Objects.BaseGame
{
    public class GameManager
    {
        public Map Map { get; set; } = new();
        public PlayerPosition PlayerPosition { get; set; } = new(0, 0);
        public bool GameWin = false;
        public MapRender? CurrentMap { get; init; }

        public GameManager()
        {
            CurrentMap = Map.CreateMap(PlayerPosition, GameWin);
        }

        public void Run()
        {
           
            do
            {
                Console.Clear();
                CurrentMap.Render(Map.MapState, PlayerPosition, GameWin);
                
                Console.WriteLine();
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

                PlayerPosition = Map.ChooseAction(Console.ReadLine().ToLower(), PlayerPosition);
                OutputColour.Change(OutputType.Neutral);
                CheckWin();
            } while (!GameWin);
        }

        public string? GetSense()
        {
            if (PlayerPosition.Column == 0 && PlayerPosition.Row == 0)
            {
                return Sense.See(true);
            }
            else if (PlayerPosition.Column == 2 && PlayerPosition.Row == 0)
            {
                return Sense.Hear(Map.FountainActive);
            }
            else if ((PlayerPosition.Row == 0 && PlayerPosition.Column == 1) || (PlayerPosition.Column == 0 && PlayerPosition.Column == 1))
            {
                return Sense.See(false);
            }
            return null;
        }

        private void CheckWin()
        {
            if (PlayerPosition.Row == 0 && PlayerPosition.Column == 0 && Map.FountainActive)
            {
                Console.Clear();
                OutputColour.Change(OutputType.Winner);
                GameWin = true;
                Console.WriteLine("!- - - - - - - - - - - - - - WINNER - - - - - - - - - - - - - - - -!");
                Console.WriteLine();
                CurrentMap.Render(Map.MapState, PlayerPosition, GameWin);
                Console.WriteLine($"You are in the room at {PlayerPosition.ToString().Remove(0, 15)}");
                Console.WriteLine("You have escaped with your life and the fountain is finally activated!");
                Console.WriteLine("You Win!")

        ;
            }
        }
    }
}