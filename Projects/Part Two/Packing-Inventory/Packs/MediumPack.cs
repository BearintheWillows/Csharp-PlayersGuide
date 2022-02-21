namespace Packing_Inventory.Packs;

public class MediumPack : Pack
{
    public MediumPack() : base (7, 15, 17) { }
    
    public override string? ToString()
    {
        Console.WriteLine("Pack Size: Medium");
        Console.WriteLine("Pack Contains: ");
        foreach (var item in StoredItems)
        {
            Console.WriteLine(item.ToString());
        }

        return null;
    }
}