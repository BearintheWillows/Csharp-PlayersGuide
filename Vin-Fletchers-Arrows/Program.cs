using Arrows;

string headType = Console.ReadLine();
string fletchType = Console.ReadLine();
int length = int.Parse(Console.ReadLine());


Arrows.Arrows set1 = new Arrows.Arrows(headType, fletchType, length);

set1.getCost();

