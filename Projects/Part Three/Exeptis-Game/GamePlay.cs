namespace Exeptis_Game;

public enum Cookie
{
    OatmealRaisin, ChocolateChip
}

public record Player(string Name);


public class GamePlay
{
    public int OatmealCookie { get; init; }
    public List<int> UsedNums { get; set; } = new List<int>();
    public Player PlayerOne { get; } = new Player("Player One");
    public Player PlayerTwo { get; } = new Player("Player Two");
    private Player _activePlayer;
    

    public GamePlay()
    {
        OatmealCookie = RandomCookie();
        RandomPlayer();

    }

    public void Run()
    {
        
        do
        {
            Console.WriteLine($"{_activePlayer} pick a number: ");
            int currentNum = ChooseNumber();
            UsedNums.Add(currentNum);
            try
            {
                if (currentNum == OatmealCookie)
                {
                    throw new NotSupportedException("CORRECT");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                Console.WriteLine($"List of used Numbers: ");
                foreach (var VARIABLE in UsedNums)
                {
                    Console.WriteLine(VARIABLE);
                }
                Console.WriteLine($"Oatmeal cookie = {OatmealCookie}");
            }

            _activePlayer = _activePlayer == PlayerOne ? PlayerTwo : PlayerOne;
        } while (true);
    }

    public int ChooseNumber()
    {
        return Convert.ToInt32(Console.ReadLine());
    }
    private static int RandomCookie()
    {
        Random randomNum = new Random();
        int oatmealRaisinNum = randomNum.Next(0, 10);
        return oatmealRaisinNum;
    }

    private void RandomPlayer()
    {
        Random randomNum = new Random();
        int rndNum = randomNum.Next(0, 2);
        if (rndNum == 1)
        {
            _activePlayer = PlayerOne;
        }
        else
        {
            _activePlayer = PlayerTwo;
        }

    }
}