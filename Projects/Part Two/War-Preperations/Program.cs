

using War_Preperations;

Sword ironSword = new Sword(Material.iron, Gem.none, 12, 5);

Console.WriteLine(ironSword.ToString());

Sword emeraldSword = ironSword with {gem = Gem.emerald};
Sword amberSword = ironSword with {gem = Gem.amber};

Console.WriteLine(emeraldSword.ToString());
Console.WriteLine(amberSword.ToString());