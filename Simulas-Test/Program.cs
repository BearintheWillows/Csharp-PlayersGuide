using Chest;

State currentState = State.locked;

string response = "";



do {
getResponse();

if (currentState.ToString() == "locked" && response == "unlock")
{
    Console.Write($"The chest is {currentState}. What do you want to do?");
    SetState(currentState);
    getResponse();
}
else if (currentState.ToString() == "unlocked" && response == "lock") 
{
    Console.Write($"The chest is {currentState}");
    SetState(currentState);
    getResponse();
}
else if (currentState.ToString() == "closed" && response == "open")
{
    Console.Write($"The chest is {currentState}. What do you want to do?");
    SetState(currentState);
    getResponse();
} 
else if (currentState.ToString() == "open" && response == "close")
{
    Console.Write($"The chest is {currentState}. What do you want to do?");
    SetState(currentState);
    getResponse();
}
else
{
    Console.WriteLine($@"Incorrect choice. The state is currently {currentState} Please choose from: 
    -unlock, 
    -lock,
    -open,
    -close,
    ");
}
    
} while (true);


State SetState (State currentState)
{
    switch (currentState)
    {
        case State.locked:
            currentState = State.unlocked;
            break;
        case State.unlocked:
            currentState = State.open;
            break;
        case State.open:
            currentState = State.close;
            break;
        case State.close:
            currentState = State.open;
            break;
    }
    return currentState;
}

void getResponse ()
{
    response = Console.ReadLine();
}