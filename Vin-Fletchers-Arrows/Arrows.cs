namespace Arrows;

public class Arrows
{
    private ArrowHead Head {get; set;}
    private double Length {get; set;}
    private Fletching Fletching {get; set;}

    public Arrows(ArrowHead head,Fletching fletching,int length)
    {
        Head = head;
        Fletching = fletching;
        Length = length;
    }

    public void getCost()
    {

    double headCost = Head.ToString() switch
                    {
                        "steel" => 10,
                        "wood" => 3,
                        "obsidian" => 5,
                        _ => 0
                    };
            
    double fletchCost = Fletching.ToString() switch
                {
                    "plastic" => 3,
                    "turkeyFeather" => 5,
                    "gooseFeather" => 10,
                    _ => 0
                };
            
    double lengthCost = Length * 0.05;
    
    double totalCost = headCost + fletchCost + lengthCost;
        
    Console.WriteLine($@"Your arrow is as follows:
    {Head} - {headCost} gold
    {Fletching} - {fletchCost} gold
    {Length} centimetres - {lengthCost} gold
    Total cost per arrow: {totalCost} gold");
}
}
