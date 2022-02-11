namespace TheLockedDoor;

public class TheDoor
{
    private DoorStatus CurrentState { get; set; } = DoorStatus.Lock;
    private string StoredPassword { get; set; }
    private bool ChangePassword { get; set; } = false;

    public TheDoor(string password)
    {
        StoredPassword = "1234";
        this.checkPassword(password);
    }

    //Check user input against StorePassword.
    //Then checks if password is being changed
    private void checkPassword(string password)
    {
        if (password == StoredPassword)
        {
            if (ChangePassword == true)
            {
                Console.WriteLine("Now enter new password");
                this.changePassword(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Access Granted");
                CurrentState = DoorStatus.Close;
                this.startSequence();
            }
        }
        else
        {
            Console.WriteLine("Access Denied.");
            Console.WriteLine("Door is Locked. Password?");
            this.checkPassword(Console.ReadLine());
        }
    }

    //Starts main loop of program while CurrentState != DoorStatus.Lock
    private void startSequence()
    {
        Console.WriteLine("Door is now closed. What next?");
        do
        {
            this.DoorAccessGranted();
        } while (CurrentState != DoorStatus.Lock);

    }
    //Checks user input matches an Enum or password change. 

    private void DoorAccessGranted()
    {

        string input = Console.ReadLine();
        DoorStatus response;
        if (Enum.TryParse(input, out response))
        {
            this.operateDoor(response);
        }
        else if (input == "change password")
        {
            ChangePassword = true;
            Console.Write("Please enter current password: ");
            this.checkPassword(Console.ReadLine());
        }
        else
        {
            Console.WriteLine(@"Please use:
                        - Unlock
                        - Lock
                        - Open
                        - Close");
        }
    }

    // Changes StoredPassword based on user input
    private void changePassword(string newPassword)
    {
        StoredPassword = newPassword;
        Console.WriteLine("Password changed.");
        ChangePassword = false;
        Console.WriteLine("Please enter new password to unlock");
        this.checkPassword(Console.ReadLine());

    }

    //Controls the door oepration loop
    private void operateDoor(DoorStatus setState)
    {

        switch (setState)
        {

            case DoorStatus.Lock when CurrentState == DoorStatus.Close:
                CurrentState = DoorStatus.Lock;
                Console.WriteLine("Door is now Locked. Password?");
                this.checkPassword(Console.ReadLine());
                break;

            case DoorStatus.Open when CurrentState == DoorStatus.Close:
                CurrentState = DoorStatus.Open;
                Console.WriteLine("Door now Open.");
                break;

            case DoorStatus.Close when CurrentState == DoorStatus.Open:
                CurrentState = DoorStatus.Close;
                Console.WriteLine("Door now Closed.");
                break;

            default:
                Console.WriteLine(@"Incorrect command. Try again.
                    - You might need to close the door before locking it.
                    - Close the door before opening it.
                    ");
                break;
        }
    }
}
