namespace Arrows;

public class Arrows
{
    ArrowHead head;
    int length;
    Fletching fletching;

    public Arrows(ArrowHead head,Fletching fletching,int length)
    {
        this.head = head;
        this.fletching = fletching;
        this.length = length;
    }


    public void getCost()
    {
    
    int headNum = (int) this.head;
    int fletchNum = (int) this.fletching;


    
    
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
            
    decimal lengthCost = length * (decimal)0.05;
    
    decimal totalCost = headCost + fletchCost + lengthCost;
        
    Console.WriteLine($@"Your arrow is as follows:
    {this.head} - {headCost} gold
    {this.fletching} - {fletchCost} gold
    {this.length} centimetres - {lengthCost} gold
    Total cost per arrow: {totalCost} gold");

}}
