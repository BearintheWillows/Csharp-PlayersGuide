using Colored_Items;

ColoredItem<Sword> coloredSword = new ColoredItem<Sword>( ConsoleColor.Blue);
ColoredItem<Axe> coloredAxe = new ColoredItem<Axe>(ConsoleColor.Green);
ColoredItem<Bow> coloredBow = new ColoredItem<Bow>(ConsoleColor.Red);


coloredSword.Display();
coloredAxe.Display();
coloredBow.Display();

Console.WriteLine(coloredBow);
