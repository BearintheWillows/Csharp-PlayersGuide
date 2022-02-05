using TheLockedDoor;


TheDoor doorA = new TheDoor();
Console.WriteLine("Door is locked. What do you want to do?");
do
{   
    DoorStatus response;
    if (Enum.TryParse(Console.ReadLine(), out response))
    {
        doorA.operateDoor(response);
    }
    else
    {
        Console.WriteLine(@"Please use:
        - Unlock
        - Lock
        - Open
        - Close");
    }
} while (true);