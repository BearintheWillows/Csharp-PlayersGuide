﻿using The_Fountain_Of_Objects.BaseGame.Enums;
using The_Fountain_Of_Objects.Expansion.Help;
using The_Fountain_Of_Objects.Expansion.MapGenerator;

namespace The_Fountain_Of_Objects.BaseGame
{
    public class GameManager : IPlayerHelp
    {
        public Map Map { get; set; } = new();
        public PlayerPosition PlayerPosition { get; set; } = new(0, 0);
        public bool GameWin = false;
        public MapRender? CurrentMap { get; private set; }

        public GameManager()
        {
        }

        public void Run()
        {
            Story.Intro();
            CurrentMap = Map.CreateMap(PlayerPosition, GameWin);

            do
            {
                Console.Clear();
                CurrentMap.Render(Map.MapState, PlayerPosition,GameWin);
                Console.WriteLine();
                OutputColour.Change(OutputType.Story);
                Story.RoomScene(PlayerPosition);
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
                string response = Console.ReadLine();
                if (response.ToLower() == "help")
                {
                    Story.Help();
                }
                else
                {
                   PlayerPosition = Map.ChooseAction(response.ToLower(), PlayerPosition); 
                }
                
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

        public void GetHelp(string help)
        {
            switch (help)
            {
                
            }
        }
    }
}