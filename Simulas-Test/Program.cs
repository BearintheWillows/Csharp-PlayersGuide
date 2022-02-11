// using Chest;

// State currentState = State.locked;
// int i = 1;

// do
// {
//     Console.Write($"The chest is {currentState}. What do you want to do? ");
//     SetState(Console.ReadLine());
// } while (i == 1);


// void SetState (string response)
// {
//     switch (response)
//     {
//         case "unlock" when currentState == State.locked:
//             currentState = State.closed;
//             break;
//         case "lock" when currentState == State.closed:
//             currentState = State.locked;
//             break;
//         case "close" when currentState == State.open:
//             currentState = State.closed;
//             break;
//         case "open" when currentState == State.closed:
//             currentState = State.open;
//             break;
//         default: 
//             Console.WriteLine(@"Available commands:
//             - unlock if locked
//             - lock if closed or unlocked
//             - open if closed
//             - close if open");
//             break;
//     }
// }

using System;

Pack pack = new Pack(5, 5f, 5f);
Console.WriteLine($"{pack.MaxAmount},{pack.MaxWeight},{pack.MaxVolume}");

class Pack
{
    public float MaxWeight { get; }
    public float MaxVolume { get; }
    public float Weight { get; private set; }
    public float Volume { get; private set; }

    public int MaxAmount { get; private set; }

    public InventoryItem[] Contents { get; }

    public Pack(int maxAmount, float maxWeight, float maxVolume)
    {
        MaxWeight = maxWeight;
        MaxVolume = maxVolume;
        MaxAmount = maxAmount;
        Contents = new InventoryItem[maxAmount];
    }
}

class InventoryItem
{
    public float Weight { get; set; }
    public float Volume { get; set; }

    public InventoryItem(float weight, float volume)
    {
        Weight = weight;
        Volume = volume;
    }
}