
using static System.Console;



SomeClass aClass = new SomeClass();

WriteLine(aClass.Number);

SomeClass bClass = SomeClass.CreateClass();

WriteLine(bClass.Number);
// Normal Class

public class SomeClass
{
    private int _number; //Own number field
    public int Number {get;} = 5;//Property

    public static SomeClass CreateClass() => new SomeClass();
};

public static class Utilities
{
    public static int Helper() => 4;
    public static double HealperProp => 4.0;
    public static int AddNumber(int a, int b) => a + b;
}

