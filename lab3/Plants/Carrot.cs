namespace lab3;

public record Carrot : Plant
{
    public int Size { get; set; }
    public Carrot(string shortName, string fullName, int growingTime, bool isNeedRegrow, bool isRipe)
        : base(shortName, fullName, growingTime, isNeedRegrow,isRipe)
    {
        Size = growingTime * 2;
    }

    public override bool CanHarvest()
    {   
        return Size >= 10 && base.CanHarvest();
    }
}