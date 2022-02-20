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

    public string?                       Name          { get; init; }
    public int                           MaxItems      { get; }
    public int                           CurrentItems  { get; set; } = 0;
    public int                           MaxVolume     { get; }
    public double                        CurrentVolume { get; set; }
    public int                           MaxWeight     { get; }
    public double                        CurrentWeight { get; set; }
    public Packing_Inventory.Item.Item[] StoredItems   { get; set; }

    public bool AddItem(Packing_Inventory.Item.Item item)
    {
        if (CurrentItems < MaxItems &&
            CurrentWeight + item.Weight < MaxWeight &&
            CurrentVolume + item.Volume < MaxVolume)
        {
            int loop = 0;
            foreach (var index in StoredItems)
            {
                if (index == null)
                {
                    StoredItems[loop] = item;
                    CurrentVolume += item.Volume;
                    CurrentItems++;
                    CurrentWeight += item.Weight;

                    break;
                }

                loop++;
            }

            return true;
        }
        return false;
    }

    public void ReportPackState()
    {
        Console.WriteLine($"Pack Size: {Name}");
        Console.WriteLine($"Current Items {CurrentItems}/{MaxItems}");
        Console.WriteLine($"Current Wight: {CurrentWeight}/{MaxWeight}");
        Console.WriteLine($"Current Volume: {CurrentVolume}/{MaxVolume}");
        
        Console.WriteLine("Items within pack:");
        int itemNum = 1;
        foreach (var variable in StoredItems)
            if (variable != null)
            {
                Console.WriteLine($"Item {itemNum}: {variable.Name}");
                itemNum++;
            }
        
    }
}