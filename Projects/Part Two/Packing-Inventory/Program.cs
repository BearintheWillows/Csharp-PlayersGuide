
using Packing_Inventory.Item;
using Packing_Inventory.Packs;

Arrow arrow = new Arrow();
Console.WriteLine(arrow.ToString());
string answer;
Pack userPack = ChoosePack();

do
{
   InventoryList(); 
   Console.WriteLine();
   Console.WriteLine("Would you like to add more?");
   answer = Console.ReadLine();
   if (answer != "yes")
   {
       Console.Clear();
       Console.WriteLine("Goodluck on your Journey - Here is your final Pack");
       Console.WriteLine();
       userPack.ReportPackState();
   }
} while (userPack.CurrentItems < userPack.MaxItems && answer == "yes");


Pack ChoosePack()
{
    Console.WriteLine("Please choose a Packsize:");
    Console.WriteLine("-*- Small  -*-");
    Console.WriteLine("-*- Medium -*-");
    string pack = Console.ReadLine().ToLower();
    Pack? packSize = null;
    switch (pack)
    {
        case "small":
            Pack smallPack = new SmallPack();
            packSize = smallPack;
            break;
        case "medium":
            Pack mediumPack = new MediumPack();
            packSize = mediumPack;
            break;
    }

    return packSize;
}

void InventoryList()
{
    Console.WriteLine("------ INVENTORY ------");
    Console.WriteLine();
    Console.WriteLine("------ Weapons ------");
    Console.WriteLine("-*-  Sword  -*-");
    Console.WriteLine("-*-  Bow    -*-");
    Console.WriteLine();
    Console.WriteLine("------ Ammo ------");
    Console.WriteLine("-*-  Arrow  -*-");
    Console.WriteLine();
    Console.WriteLine("------ Utility Items ------");
    Console.WriteLine("-*-  Food   -*-");
    Console.WriteLine("-*-  Rope   -*-");
    Console.WriteLine("-*-  Water  -*-");
    Console.WriteLine($"Please choose an item to put in {userPack.Name}:");
    ItemCreator(Console.ReadLine().ToLower());
}

 

void ItemCreator(string item)
{
    Item? newItem = null;
    switch (item)
    {
        case "sword":
            newItem = new Sword();
            break;
        case "bow":
            newItem = new Bow();
            break;
        case "arrow":
            newItem = new Arrow();
            break;
        case "rope":
            newItem = new Rope();
            break;
        case "water":
            newItem = new Water();
            break;
        case "food":
            newItem = new FoodRations();
            break;
    }

    if (userPack.AddItem(newItem))
    {
        Console.Clear();
        Console.WriteLine($"Success. {newItem} has been added to your pack");
        userPack.ReportPackState();
        userPack.ToString();
    }
    else
    {
        Console.WriteLine("Please choose another item! Either Volume or Weight limits were exceeded.");
        ItemCreator(Console.ReadLine());
    }
}