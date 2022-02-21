namespace Packing_Inventory.Item;

public class Arrow : Item
{
    public Arrow()
    {
        Weight = 0.1;
        Volume = 0.05;
    }

    public override string ToString() => "Arrow";
}