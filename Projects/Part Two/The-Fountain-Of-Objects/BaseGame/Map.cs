﻿using System.Globalization;
using The_Fountain_Of_Objects.BaseGame.Enums;
using The_Fountain_Of_Objects.Expansion.MapGenerator;

namespace The_Fountain_Of_Objects.BaseGame;

public class Map
{
    public RoomType[,] MapState { get; set; }
    public bool FountainActive { get; private set; }

    private int _mapSize;

    //Renders the game map 
    public MapRender? CreateMap(PlayerPosition playerPosition, bool gameWin)
    {
        string sizeOfMap = Console.ReadLine();
        switch (sizeOfMap)
        {
            case "small":
                MapState = MapGenerator.Generate(4, 4, MapState);
                _mapSize = 4;

                return new SmallMapRender(MapState, playerPosition, gameWin);
            case "medium":
                MapState = MapGenerator.Generate(6, 6, MapState);
                _mapSize = 6;
                return new MediumMapRender(MapState, playerPosition, gameWin);
            case "large":
                MapState = MapGenerator.Generate(8, 8, MapState);
                _mapSize = 8;
                return new LargeMapRender(MapState, playerPosition, gameWin);
            default:
                Console.WriteLine("Please enter a valid Size - small, medium or large");
                CreateMap(playerPosition, gameWin);
                return null;
        }
    }

    //Player can choose differing actions to perform.
    public PlayerPosition ChooseAction(string heading, PlayerPosition playerPosition)
    {
        //Creates a Culture info obj
        TextInfo myTI = new CultureInfo("en-UK", false).TextInfo;

        // Converts heading to a title case to match Enum
        heading = myTI.ToTitleCase(heading);

        //Parses heading and converts to applicable Enum.
        if (Enum.TryParse(heading, out Heading newHeading))
        {
            switch (newHeading)
            {
                case Heading.North:
                    if (playerPosition.Row > 0)
                    {
                        playerPosition =
                            new PlayerPosition(playerPosition.Row - 1, playerPosition.Column);
                    }
                    else
                    {
                        OutputColour.Change(OutputType.Warning);
                        Console.WriteLine("You can't move any further north");
                    }
                    break;

                case Heading.East:
                    if (playerPosition.Column < _mapSize - 1)
                    {
                        playerPosition =
                            new PlayerPosition(playerPosition.Row, playerPosition.Column + 1);
                    }
                    else
                    {
                        OutputColour.Change(OutputType.Warning);
                        Console.WriteLine("You can't move further East.");
                    }
                    break;

                case Heading.South:
                    if (playerPosition.Row < _mapSize - 1)
                    {
                        playerPosition =
                            new PlayerPosition(playerPosition.Row + 1, playerPosition.Column);
                    }
                    else
                    {
                        OutputColour.Change(OutputType.Warning);
                        Console.WriteLine("You can't move further South.");
                    }
                    break;

                case Heading.West:
                    if (playerPosition.Column > 0)
                    {
                        playerPosition =
                            new PlayerPosition(playerPosition.Row, playerPosition.Column - 1);
                    }
                    else
                    {
                        OutputColour.Change(OutputType.Warning);
                        Console.WriteLine("You can't move further West.");
                    }
                    break;

                default:

                    break;
            }
        }
        else if (heading == "Activate Fountain" && playerPosition.Row == 0 && playerPosition.Column == 2)
        {
            FountainActive = true;
        }
        else
        {
            OutputColour.Change(OutputType.Warning);
            Console.WriteLine("Invalid Option Typed");
            Console.WriteLine("Please Type for Navigation: North, East, South, West");
            Console.WriteLine("If you are in the Fountain Room, you can Type: Activate Fountain");
        }
        if ((playerPosition.Row == 0 && playerPosition.Column == 0) || (playerPosition.Row == 0 && playerPosition.Column == 2))
        {
            OutputColour.Change(OutputType.UniqueRoom);
        }
        return playerPosition;
    }
}