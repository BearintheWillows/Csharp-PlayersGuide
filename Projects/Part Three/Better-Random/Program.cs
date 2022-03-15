
double thisDouble = 10.3;

thisDouble.NextDouble();

public static class DoubleExtentions
{
    public static void NextDouble(this double maxVal)
    {
        Random newRandom = new Random();
        double resp = newRandom.Next(0,(int)maxVal);
        Console.WriteLine((double)resp);
    }f
}

