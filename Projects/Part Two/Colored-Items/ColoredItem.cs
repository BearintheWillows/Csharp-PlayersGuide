namespace Colored_Items;

public class ColoredItem<T>
{
    public T            Item  { get; }
    public ConsoleColor Color { get; set; }
    
    public ColoredItem(T item,ConsoleColor color)
    {
        Color = color;
        Item = item;
    }

    public void Display()
    {
        Console.ForegroundColor = Color;
        Console.WriteLine(ToString());
    }
}