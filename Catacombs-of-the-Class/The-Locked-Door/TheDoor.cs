namespace TheLockedDoor;

public class TheDoor
{
    private DoorStatus CurrentState {get; set;} = DoorStatus.Lock;

     public void operateDoor(DoorStatus setState)
    {
        if (CurrentState != DoorStatus.Lock)
        {
            
            switch (setState)
            {
                
                case DoorStatus.Lock when CurrentState == DoorStatus.Close:
                CurrentState = DoorStatus.Lock;
                Console.WriteLine("Door now locked");
                break;

                case DoorStatus.Open when CurrentState == DoorStatus.Close:
                CurrentState = DoorStatus.Open;
                Console.WriteLine("Door now Open.");
                break;

                case DoorStatus.Close when CurrentState == DoorStatus.Open:
                CurrentState = DoorStatus.Close;
                Console.WriteLine("Door now Close.");
                break;

                default:
                Console.WriteLine(@"Incorrect command. Try again.
                - You might need to close the door before locking it.
                - Close the door before opening it.
                ");
                break;
            }
        }
        else
        {
            switch (setState)
            {
                case DoorStatus.Unlock:
                CurrentState = DoorStatus.Close;
                Console.WriteLine("Door unlocked");
                break;

                default:
                Console.WriteLine("Door locked. Please Unlock first.");
                break;
            }
        }
    }
}