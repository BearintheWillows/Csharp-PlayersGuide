using Arrows;

string headType = Console.ReadLine();
string fletchType = Console.ReadLine();
int length = int.Parse(Console.ReadLine());

Arrows.Arrows set1 = new Arrows.Arrows((ArrowHead) Enum.Parse(typeof(ArrowHead), headType, true), (Fletching) Enum.Parse(typeof(Fletching), fletchType, true), length);

set1.getCost();

Arrows.Arrows elite = Arrows.Arrows.CreateEliteArrow();


Console.WriteLine(elite);
