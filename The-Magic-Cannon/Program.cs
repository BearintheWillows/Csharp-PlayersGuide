for (int i = 1; i < 101; i++)
{
    if (i % 3 == 0 && i % 5 ==0)
    {
       Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write($"{i}: ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Bo");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("om\n");
       
        
    }
    else if (i % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{i}: Electric");
    }
    else if (i % 3 == 0 )
    {   
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{i}: Fire");
    }
}