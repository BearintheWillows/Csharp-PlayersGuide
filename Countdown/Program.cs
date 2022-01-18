// int Factorial(int number)
// {
//     if (number == 1) return 1;
//     return number * Factorial(number - 1);
// }

/* Objectives:
• Write code that counts down from 10 to 1 using a recursive method.
• Hint: Remember that you must have a base case that ends the recursion and that every time you
call the method recursively, you must be getting closer and closer to that base case.*/

int Countdown (int number)
{
    if (number == 0) return 1;
    Console.WriteLine(number);
    return Countdown(number - 1);
    
}

Countdown(10);