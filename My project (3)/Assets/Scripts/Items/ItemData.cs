public enum ItemType
{
    Good,
    Bomb
}

public struct ItemData
{
    public ItemType Type;
    public int Points;

    public ItemData(ItemType type, int points)
    {
        Type = type;
        Points = points;
    }
}