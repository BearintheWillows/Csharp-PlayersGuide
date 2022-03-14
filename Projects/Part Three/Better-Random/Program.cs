

10.0.NextDouble();

public static class StringRandom
{
    public static void NextDouble(this double maxVal)
    {
        Random newRandom = new Random();
        double resp = newRandom.Next(0,(int)maxVal);
        Console.WriteLine((double)resp);
    }
}

