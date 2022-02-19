using Packing_Inventory.Item;
using Packing_Inventory.Item.Weapon;
using Packing_Inventory.Packs;

var newPack = new SmallPack();

Console.WriteLine(newPack.StoredItems);


Sword Sword1 = new Sword();
Console.WriteLine(newPack.AddItem(Sword1));

Console.WriteLine(newPack.MaxItems);

foreach (var VARIABLE in newPack.StoredItems)
{
    Console.WriteLine($"Item: {VARIABLE}");
}