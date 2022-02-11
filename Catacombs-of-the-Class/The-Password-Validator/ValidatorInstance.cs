namespace PasswordInstance;

public class Validator
{
    public Validator()
    {
        bool endSession = false;
        do
        {
            Console.WriteLine("Please enter a password to be validated:");
            string input = Console.ReadLine();
            if (input == "end")
            {
                endSession = true;
            }
            else
            {
                CheckPassword(input);
            }
        } while (!endSession);
    }

    private static void CheckPassword(string password)
    {
        bool isUpper = false;
        bool isLower = false;
        bool isNumber = false;
        bool invalidChar = false;
        if (password.Length is > 5 and < 14)
        {
            foreach (var letter in password)
            {
                if (char.IsLower(letter))
                {
                    isLower = true;
                }

                if (char.IsUpper(letter))
                {
                    isUpper = true;
                }

                if (char.IsNumber(letter))
                {
                    isNumber = true;
                }

                if (letter is 'T' or '&') invalidChar = true;
            }

            if (!invalidChar && (isUpper == true && isLower == true && isNumber == true))
                Console.WriteLine($"Password: {password} is valid.");
            else
                Console.WriteLine($"Password: {password} is NOT valid.");
        }
    }
}