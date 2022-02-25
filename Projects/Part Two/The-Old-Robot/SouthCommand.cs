namespace The_Old_Robot;

public class SouthCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.Y += 1; 
        }
        
    }
    
}