
namespace The_Fountain_Of_Objects.BaseGame
{
    public static class Story
    {

        public static void Intro()
        {
            Console.WriteLine("You enter the cavern of Objects...");
            Console.WriteLine("Light is visible only in the entrance, qnd no other light is seen anywhere in the caverns...");
            Console.WriteLine("You must navigate the Caverns with other senses...");
            Console.WriteLine("Find the Fountain of Objects, activate it, and return to the entrance.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("First, you must choose a Map Size.");
            Console.WriteLine("Your choices:");
            Console.WriteLine("Small - 4x4 squares");
            Console.WriteLine("Medium - 6x6 squares");
            Console.WriteLine("Large - 8x8 squares");
            Console.WriteLine();
        }

        public static void RoomScene(PlayerPosition playerPosition)
        {
            Console.WriteLine($"You are in the room at {playerPosition.ToString().Remove(0, 15)}");
        }

        public static void Help()
        {
            Console.Clear();
            Console.WriteLine("------------ HELP ------------");
            Console.WriteLine("Movement:");
            Console.WriteLine();
            Console.WriteLine("North - Move you upwards");
            Console.WriteLine("East - Moves you right");
            Console.WriteLine("South - Moves you down");
            Console.WriteLine("West - Moves you left.");
            Console.WriteLine();
            Console.WriteLine("Fountain:");
            Console.WriteLine();
            Console.WriteLine("Activate Fountain - Activates the fountain of Objects. ");
            Console.WriteLine();
            Console.WriteLine("Rules:");
            Console.WriteLine("- You cannot move further than the grid boundary.");
            Console.WriteLine("- The Fountain can only be activated when in the correct square.");
            Console.WriteLine();
            Console.WriteLine("Win Condition:");
            Console.WriteLine("You must activate the fountain and return to the entrance to win.");
            Console.WriteLine();
            Console.WriteLine("Please click any key to continue...");
            Console.ReadKey();
        }
    }
}
