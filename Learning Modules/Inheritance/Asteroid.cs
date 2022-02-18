namespace Inheritance;

public class Asteroid : GameObject
{

    public Asteroid()
    {
        RotationAngle = -1;
    }

    public float Size          { get; }
    public float RotationAngle { get; }
}