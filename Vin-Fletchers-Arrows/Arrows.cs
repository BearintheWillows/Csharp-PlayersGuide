namespace Arrows;

public class Arrows
{
    private ArrowHead _head;
    private double _length;
    private Fletching _fletching;

    public Arrows(string head,string fletching,int length)
    {
        _head = (ArrowHead) Enum.Parse(typeof(ArrowHead), head, true);
        _fletching = (Fletching) Enum.Parse(typeof(Fletching), fletching, true);
        _length = length;
    }
    
    public ArrowHead getHead() => _head;
    public double getLength() => _length;
    public Fletching getFletching() => _fletching;
    public void getCost()
    {

    double headCost = _head.ToString() switch
                    {
                        "Steel" => 10,
                        "wood" => 3,
                        "obsidian" => 5,
                        _ => 0
                    };
            
    double fletchCost = _fletching.ToString() switch
                {
                    "plastic" => 3,
                    "turkeyFeather" => 5,
                    "gooseFeather" => 10,
                    _ => 0
                };
            
    double lengthCost = _length * 0.05;
    
    double totalCost = headCost + fletchCost + lengthCost;
        
    Console.WriteLine($@"Your arrow is as follows:
    {_head} - {headCost} gold
    {_fletching} - {fletchCost} gold
    {_length} centimetres - {lengthCost} gold
    Total cost per arrow: {totalCost} gold");
}
}
