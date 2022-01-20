
//Prints console line based on round number 

for (int i = 1; i < 101; i++)
{
    //Both Divisble by 3 AND divisible by 5

    if (i % 3 == 0 && i % 5 ==0)
    {
       Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write($"{i}: ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Bo");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("om\n");
    }

    //Divisible by 5 only.

    else if (i % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{i}: Electric");
    }

    //Divisible by 3 only.

    else if (i % 3 == 0 )
    {   
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{i}: Fire");
    }
}