namespace Password;
public static class Validator
{

    private static string Password { get; set; }
    private static bool EndSession { get; set; } = false;
    private static bool Result { get; set; }
    private static bool IsUpper {get; set;}
    private static bool isLower {get; set;}
    private static bool isNumber {get; set;}

    public static void passwordValidator()
    {
        do
        {
            Console.WriteLine("Please enter a password to be validated:");

            if (Console.ReadLine() == "end")
            {
                EndSession = true;
            }
            else
            {
                Password = Console.ReadLine();
                checkPassword(Password);
            }


        } while (EndSession != true);
    }

    private static void checkPassword(string Password)
    {
        if (Password.Length > 5 && Password.Length < 14)
        {
            foreach (var letter in Password)
            {
            IsUpper = char.IsUpper(letter);
            Console.WriteLine($"char is upper? {IsUpper}");
            IsUpper = false;
            }
        }

    }
}