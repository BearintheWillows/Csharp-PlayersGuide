namespace Packing_Inventory.Item;

public class Rope : Item
{
	public Rope()
    {
        Weight = 1;
        Volume = 1.5;
    }
    
    public override string ToString() => "Rope";
}