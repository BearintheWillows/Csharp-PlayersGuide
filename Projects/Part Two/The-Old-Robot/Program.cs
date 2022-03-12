
using The_Old_Robot;

Robot robot1 = new Robot();

Console.WriteLine("Beep Boop. Power on?");
if (Console.ReadLine().ToLower() == "yes")
{
    IRobotCommand commandOn = new OnCommand();
    commandOn.Run(robot1);
}

Console.WriteLine("Boop Beep. Working. Where to go?");
string input;
do
{
     input = Console.ReadLine();
    
    IRobotCommand? command = null;
    switch (input.ToLower())
    {
        case "east":
            command = new EastCommand();
            break;
        case "north":
            command = new NorthCommand();
            break;
        case "west":
            command = new WestCommand();
            break;
        case "south":
            command = new SouthCommand();
            break;
    }

    robot1.Commands.Add(command);
} while (input != "stop");
    



robot1.Run();