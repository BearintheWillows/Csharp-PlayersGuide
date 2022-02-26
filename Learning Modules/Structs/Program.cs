//Creating struct almost same as class 

public struct Point
{
    public float X { get; }
    public float Y { get; }

    public Point(float x, float y)
    {
        X = x;
        Y = y;
    }
}

//Using struct very similar to a class

Point p1 = new Point(2, 4);
