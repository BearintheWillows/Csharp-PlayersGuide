using Chest;

State currentState = State.locked;
int i = 1;

do
{
    Console.Write($"The chest is {currentState}. What do you want to do? ");
    SetState(Console.ReadLine());
} while (i == 1);


void SetState (string response)
{
    switch (response)
    {
        case "unlock" when currentState == State.locked:
            currentState = State.closed;
            break;
        case "lock" when currentState == State.closed:
            currentState = State.locked;
            break;
        case "close" when currentState == State.open:
            currentState = State.closed;
            break;
        case "open" when currentState == State.closed:
            currentState = State.open;
            break;
        default: 
            Console.WriteLine(@"Available commands:
            - unlock if locked
            - lock if closed or unlocked
            - open if closed
            - close if open");
            break;
    }
}