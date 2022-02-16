namespace Card;
using Cards;
public class Card
{
    private CardRank Rank {get; set;}
    private CardColor Color {get; set;}
    public string RankString
    {
        get
        {
            var result = Rank switch
            {
                CardRank.One => "1",
                CardRank.Two => "2",
                CardRank.Three => "3",
                CardRank.Four => "4",
                CardRank.Five => "5",
                CardRank.Six => "6",
                CardRank.Seven => "7",
                CardRank.Eight => "8",
                CardRank.Nine => "9",
                CardRank.Ten => "10",
                CardRank.Dollarsign => "$",
                CardRank.Percent => "%",
                CardRank.Carat => "^",
                CardRank.Ampersand => "&",
                _ => throw new NotImplementedException()
            };
            return result;
        }
    }

    public string ColorString 
    {
        get
        {
            var result = Color switch
            {
                CardColor.Blue => "Blue",
                CardColor.Green => "Green",
                CardColor.Red => "Red",
                CardColor.Orange => "Orange",
                _ => throw new NotImplementedException()
            };
            return result;
        }
    }

    public Card(CardRank rank, CardColor color)
    {
        Rank = rank;
        Color = color;
        getCardRank();
    }

    public void getCardRank() 
    {
        if (Rank == CardRank.Ampersand || Rank == CardRank.Carat || Rank == CardRank.Dollarsign || Rank == CardRank.Percent)
        {
            Console.WriteLine($"Card {RankString}{Color} is a Symbol Card");
        }
        else
        {
            Console.WriteLine($"Card '{RankString}{Color}' is a Number Card");
        }
    }

    public static void createDeck()
    {
        foreach (string item in Enum.GetNames(typeof(CardColor)))
        {
            CardColor color = Enum.Parse<CardColor>(item);
            foreach (var rankItem in Enum.GetNames(typeof(CardRank)))
            {
                CardRank rank = Enum.Parse<CardRank>(rankItem);
                Card newCard = new Card(rank, color);
                Console.WriteLine($@"Card created: The {newCard.Color} {newCard.RankString}
                ");
            }
        }
    }
    
}