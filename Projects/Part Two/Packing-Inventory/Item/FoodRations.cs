namespace Packing_Inventory.Item;

public class FoodRations : Item
{
    public FoodRations()
    {
        Weight = 1;
        Volume = 0.5;
    }
    
    public override string ToString() => "Food";
}