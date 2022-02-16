namespace Arrows;

public class Arrows
{
    public ArrowHead Head {get; set;}
    private double Length {get; set;}
    private Fletching Fletching {get; set;}

    public Arrows(ArrowHead head,Fletching fletching,int length)
    {
        Head = head;
        Fletching = fletching;
        Length = length;
    }
    public static Arrows CreateEliteArrow() => new Arrows(ArrowHead.steel, Fletching.plastic, 95);
    public static Arrows CreateBeginnerArrow() => new Arrows(ArrowHead.wood, Fletching.gooseFeather, 75);
    public static Arrows CreateMarksmanArrow() => new Arrows(ArrowHead.steel, Fletching.gooseFeather, 65);

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


    
   