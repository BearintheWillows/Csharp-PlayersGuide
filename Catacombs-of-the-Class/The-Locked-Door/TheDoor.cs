namespace TheLockedDoor;

public class TheDoor
{
    private DoorStatus CurrentState {get; set;} = DoorStatus.Lock;
    private string StoredPassword {get; set;}
    private bool ChangePassword {get; set;} = false;

    public TheDoor(string password)
    {
        StoredPassword = "1234";
        this.checkPassword(password);
    }


    private void checkPassword(string password)
    {
        Console.WriteLine($"{StoredPassword}");
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
    

    private void startSequence()
    {
            Console.WriteLine("Door is now closed. What next?");
            do
            {
                this.DoorAccessGranted();
            } while (CurrentState != DoorStatus.Lock);

    }

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

     private void changePassword(string newPassword)
    {
        StoredPassword = newPassword;
        Console.WriteLine("Password changed.");
        ChangePassword = false;
        Console.WriteLine("Please enter new password to unlock");
        this.checkPassword(Console.ReadLine());

    }
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