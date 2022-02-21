namespace Packing_Inventory.Item;

public class Sword : Item
{
    public Sword()
    {
        Weight = 5;
        Volume = 3;
    }

    public override string ToString() => "Sword";
    
}