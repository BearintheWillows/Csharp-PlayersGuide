namespace Inheritance;

public class GameObject
{
    public float PositionX { get; set; }
    public float PositionY { get; set; }
    public float VelocityX { get; set; }
    public float VelocityY { get; set; }


    public GameObject()
    {
        PositionX = 2; PositionY = 4;
    }

    public void Update()
    {
        PositionX += VelocityX;
        PositionY += VelocityY;
    }
}