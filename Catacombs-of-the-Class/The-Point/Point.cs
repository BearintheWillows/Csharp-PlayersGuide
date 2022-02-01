namespace Point;

public class Point
{
    private double x {get; set;}
    private double y {get; set;} 

    public Point (double x, double y)
    {
        (double, double) newPoint = (x, y);
        Console.WriteLine($"New point has been created at {newPoint}");
    }

    public Point() 
    {
        x = 0;
        y = 0;
        (double, double) newPoint = (x, y);
        Console.WriteLine($"Default point created: {newPoint}");
    }
}