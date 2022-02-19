using System.Linq;

namespace Packing_Inventory.Packs;

public class Pack
{
    public Pack(int maxItems, int maxWeight, int maxVolume)
    {
        MaxItems = maxItems;
        MaxWeight = maxWeight;
        MaxVolume = maxVolume;
        StoredItems = new Item.Item[MaxItems];
    }

    public int                           MaxItems    { get; }
    public int                           MaxWeight   { get; set; }
    public int                           MaxVolume   { get; set; }
    public Packing_Inventory.Item.Item[] StoredItems { get; set; }

    public bool AddItem(Packing_Inventory.Item.Item item)
    {
        if (StoredItems.Count(s => s != null) < MaxItems &&
            MaxWeight - item.Weight >= 0 &&
            MaxVolume - item.Volume >= 0)
        {
            int loop = 0;
            foreach (var index in StoredItems)
            {
                if (index == null)
                {
                    StoredItems[loop] = item;
                    break;
                }

                loop++;
            }
        }
        Console.WriteLine(StoredItems.Count(s => s != null));
        return false;
        
    }
}