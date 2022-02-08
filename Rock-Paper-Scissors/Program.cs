using Csharp_PlayersGuide.Rock_Paper_Scissors;
using Action = Csharp_PlayersGuide.Rock_Paper_Scissors.Action;

Player a = new Player();
Player b = new Player();

Game aVSb = new Game(a, b);

Player.ChooseAction();