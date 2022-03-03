namespace Colored_Items;

public class ColoredItem<T> where T : new()
{
    public T            Item  { get; } = new ();
    public ConsoleColor Color { get; set; }
    
    public ColoredItem(ConsoleColor color)
    {
        Color = color;
    }

    public void Display()
    {
        Console.ForegroundColor = Color;
        Console.WriteLine(ToString());
    }
}