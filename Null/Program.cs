string? name = Console.ReadLine(); // "?" Means can return Null

if (name != null)
{
    Console.WriteLine("The name is not null"); //null check
}

// null coalescing operator

public string GetTopPlayerName() 
{
    string? name = _scoreManager?.GetScores()?[0]?.Name;
    name ??= "(not found)";
    return name; //No compiler warning. '??=' makes sure value present.

}

//null forigiving operator

string message = MightReturnNullIfNegative(+10)!;