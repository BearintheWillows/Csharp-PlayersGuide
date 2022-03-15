

try
{
    number = Convert.ToInt32(response);
}
catch (FormatException)
{
    number = -1;
    Console.WriteLine($"I do not understand {response}");
}
catch (OverflowException)
{
    number = -1;
    Console.WriteLine("That number ws too big!");
}