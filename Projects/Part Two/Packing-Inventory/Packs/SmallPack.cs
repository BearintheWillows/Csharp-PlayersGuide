namespace Packing_Inventory.Packs;

public class SmallPack : Pack
{
    public SmallPack() : base(5, 10, 12)
    {
    }

    public override string? ToString()
    {
        Console.WriteLine("Pack Size: Small");
        Console.WriteLine("Pack Contains: ");
        foreach (var item in StoredItems)
        {
            if (item != null)
            {
                Console.Write($" {item.ToString()}");
            }
        }

        return null;
    }
}