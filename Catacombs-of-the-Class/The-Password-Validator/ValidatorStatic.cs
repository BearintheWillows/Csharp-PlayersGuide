namespace Password;
public static class Validator
{

    private static string Password { get; set; }
    private static bool EndSession { get; set; } = false;
    private static bool Result { get; set; }
    private static bool IsUpper { get; set; }
    private static bool IsLower { get; set; }
    private static bool IsNumber { get; set; }
    private static bool InvalidChar {get; set;}

    public static void passwordValidator()
    {
        do
        {
            Console.WriteLine("Please enter a password to be validated:");
            string input = Console.ReadLine();
            if (input == "end")
            {
                EndSession = true;
            }
            else
            {
                checkPassword(input);
            }


        } while (EndSession != true);
    }

    private static void checkPassword(string Password)
    {
        if (Password.Length > 5 && Password.Length < 14)
        {
            foreach (var letter in Password)
            {
                if (char.IsLower(letter))
                {
                    IsLower = true;
                }
                if (char.IsUpper(letter))
                {
                    IsUpper = true;
                }
                if (char.IsNumber(letter))
                {
                    IsNumber = true;
                }
                if (letter.Equals('T') || letter.Equals('&'))
                {
                    InvalidChar = true;
                }
                
            }
            if (InvalidChar == false && IsUpper == true && IsLower == true && IsNumber == true)
            {
                Console.WriteLine($"Password: {Password} is valid.");
            }
            else
            {
                Console.WriteLine($"Password: {Password} is NOT valid.");
            }

            IsUpper = false;
            IsLower = false;
            IsNumber = false;
            InvalidChar = false;
            Password = "";

        }

    }
}