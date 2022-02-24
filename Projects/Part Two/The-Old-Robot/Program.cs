
using The_Old_Robot;

Robot robot1 = new Robot();

Console.WriteLine("Beep Boop. Power on?");
if (Console.ReadLine().ToLower() == "yes")
{
    RobotCommand commandOn = new OnCommand();
    commandOn.Run(robot1);
}

Console.WriteLine("Boop Beep. Working. Where to go?");

for (int i = 0; i < 3; i++)
{
    string input = Console.ReadLine();
    RobotCommand? command = null;
    switch (input.ToLower())
    {
        case "East":
            command = new EastCommand();
            break;
        case "North":
            command = new NorthCommand();
            Console.WriteLine(command);
            break;
        case "West":
            command = new WestCommand();
            break;
        case "South":
            command = new SouthCommand();
            break;
    }

    robot1.Commands[i] = command;
}


robot1.Run();