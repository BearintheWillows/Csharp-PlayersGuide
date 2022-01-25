namespace Arrows;

public class Arrows
{
    private ArrowHead _head;
    private int _length;
    private Fletching _fletching;

    public Arrows(string head,string fletching,int length)
    {
        _head = (ArrowHead) Enum.Parse(typeof(ArrowHead), head, true);
        _fletching = (Fletching) Enum.Parse(typeof(Fletching), fletching, true);
        _length = length;
    }


    public void getCost()
    {
    
    int headNum = (int) _head;
    int fletchNum = (int) _fletching;


    
    
    decimal headCost = headNum switch
                    {
                        0 => 10,
                        1 => 3,
                        2 => 5,
                        _ => 0
                    };
            
    decimal fletchCost = fletchNum switch
                {
                    0 => 3,
                    1 => 5,
                    2 => 10,
                    _ => 0
                };
            
    decimal lengthCost = _length * (decimal)0.05;
    
    decimal totalCost = headCost + fletchCost + lengthCost;
        
    Console.WriteLine($@"Your arrow is as follows:
    {_head} - {headCost} gold
    {_fletching} - {fletchCost} gold
    {_length} centimetres - {lengthCost} gold
    Total cost per arrow: {totalCost} gold");

}}
