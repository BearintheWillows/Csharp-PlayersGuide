string pilotInput;
int pilotNumber;
string hunterInput;
int hunterNumber;

Console.WriteLine("User 1, enter a number between 0 and 100:");
do
{
    pilotInput = Console.ReadLine();
    pilotNumber = int.Parse(pilotInput);
    if (pilotNumber > 100 || pilotNumber < 0)
    {
      Console.WriteLine($"{pilotNumber} is too high/low. Try again");  
    }
    else
    {
        Console.WriteLine("Succes");
        Console.Clear();
    }
    
} while (pilotNumber > 100 || pilotNumber < 0);

Console.WriteLine("User 2, your turn!");
Console.WriteLine("Guess User 1s number:");

do
{
    hunterInput = Console.ReadLine();
    hunterNumber = int.Parse(hunterInput);

    if (hunterNumber > pilotNumber)
    {
        Console.WriteLine("Too high. Try again");
    }
    else if (hunterNumber < pilotNumber)
    {
        Console.WriteLine("Too low. Try again");
    }
    else
    {
        Console.WriteLine("Congrats! You've guessed correctly!");
    }
} while (hunterNumber != pilotNumber);