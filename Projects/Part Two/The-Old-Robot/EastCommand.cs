namespace The_Old_Robot;

public class EastCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.X -= 1;
        }
        
    }
}