namespace Packing_Inventory.Item;

public class Water : Item
{
    public Water()
    {
        Weight = 2;
        Volume = 3;
    }
    
    public override string ToString() => "Water";
}