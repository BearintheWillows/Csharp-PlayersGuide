using Colored_Items;

ColoredItem<Sword> coloredSword = new ColoredItem<Sword>(new Sword(), ConsoleColor.Blue);
ColoredItem<Axe> coloredAxe = new ColoredItem<Axe>(new Axe(), ConsoleColor.Green);
ColoredItem<Bow> coloredBow = new ColoredItem<Bow>(new Bow(), ConsoleColor.Red);


coloredSword.Display();
coloredAxe.Display();
coloredBow.Display();