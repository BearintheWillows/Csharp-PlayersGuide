public enum TerrainType
{
    Desert, Forests, Mountains, Pastures, Fields, Hills
}

public class Level
{
    public int Width  { get; }
    public int Height { get; }

    public TerrainType GetTerrainAt(int row, int column)
    {
        
    }
}

public interface ILevelBuilder
{
    public Level buildLevel(int levelNumber);
}

public class FixedLevelBuilder : ILevelBuilder
{
    public Level BuildLevel(int levelNumber)
    {
        Level level = new Level(10, 10, TerrainType.Forests);

        level.SetTerrainAt(2, 4, TerrainType.Mountains);
        level.SetTerrainAt(2, 5, TerrainType.Mountains);
        level.SetTerrainAt(6, 1, TerrainType.Desert);

        return level;
    }
}

