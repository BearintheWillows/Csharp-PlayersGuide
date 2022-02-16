int pilotNumber;
int hunterNumber;

Console.WriteLine("User 1, enter a number between 0 and 100:");
do
{
    //Requests number from user
    //If condition met warning shown to user as outofbounds
    //Else Success and Console clear

    pilotNumber = int.Parse(Console.ReadLine());
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
    //Requests input form user and sets variable hunterNumber
    hunterNumber = int.Parse(Console.ReadLine());

    //Response in console based on condition

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