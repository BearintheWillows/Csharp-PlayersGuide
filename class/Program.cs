using Scores;
using static System.Console;

Score best = new Score();

best.name = "R2-D2";
best.points = 1400;
best.level = 15;

Score newBest = new Score();

Score secondBest = new Score("Stuart", 13_000, 99);

WriteLine(best.name);
WriteLine(newBest.name);
WriteLine(secondBest.name + " " + secondBest.points);