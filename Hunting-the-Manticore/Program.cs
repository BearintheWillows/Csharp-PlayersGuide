int manticoreHealth = 10;
int cityHealth = 15;
int round = 1;
int damage = 1;
int shotRange;

Console.WriteLine("Commander, set Manticore distance:");
int cityDistance = int.Parse(Console.ReadLine());
Console.Clear();

void MagicCannon (int roundNum) {
    if (shotRange == cityDistance)
    {
        
    if (roundNum % 3 == 0 && roundNum % 5 ==0)
        {
            damage = 10;
            manticoreHealth -= 10;
        }
        else if (roundNum % 5 == 0)
        {
            damage = 3;
            manticoreHealth -= damage;
        }
        else if (roundNum % 3 == 0 )
        {   
            damage = 3;
            manticoreHealth -= damage;
        }
        else
        {
            damage = 3;
            manticoreHealth -= damage;
        }
    }
}

string CannonHitDetect (int range) {
    string response;
    shotRange = range; 
    if (range > cityDistance)
    {
        response = "That round was OVERSHOT the target";

    }
    else if (range < cityDistance)
    {
        response = "That round FELL SHORT of the target";
    }
    else 
    {
        response = "That round was a DIRECT HIT!";
    }
    return response;
}

string loserDetect () {
    string response;
    if (cityHealth == 0)
    {
        response = "Game over. Manticore wins!";
    }
    else
    {
        response = "Game over. City Wins!";
    }
    return response;
}

do
{
    //Setting game status per round
    Console.WriteLine("------------------------------------------------------");
    Console.Write($"STATUS: Round {round}  ");
    Console.Write($"City: {cityHealth} / 15  ");
    Console.WriteLine($"Manticore: {manticoreHealth} / 10");
    Console.WriteLine($"The cannon is expected to deal {damage} this round.");
    Console.Write("Enter desire cannon range: ");
    Console.WriteLine(CannonHitDetect(int.Parse(Console.ReadLine())));
    Console.WriteLine("------------------------------------------------------");
    

    MagicCannon(round);
    cityHealth--;
    Console.WriteLine("**********************************");
    Console.WriteLine(loserDetect());
    Console.WriteLine("**********************************");
    round++;
    
} while (cityHealth > 0 && manticoreHealth > 0);
