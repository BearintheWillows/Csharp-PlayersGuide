namespace Scores;


class Score
{
    //Fields or instance variables
    public string name;
    public int points;
    public int level;

    //Constructor

    public Score()
    {
        name = "Unknown";
        points = 0;
        level = 1;
    }

    public Score(string name, int points,int level)
    {
        this.name = name;
        this.points = points;
        this.level = level;
    }


    // Methods

    public bool GetEarnedStar()
    {
        return (points / level) > 1000;
    }
}