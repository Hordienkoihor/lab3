namespace lab3;

public record Potato : Plant
{
    public bool FaynaKartoplya { get; set;}
    public Potato(string shortName, string fullName, int growingTime, bool isNeedRegrow, bool isRipe, bool faynaKartoplya)
        : base(shortName, fullName, growingTime, isNeedRegrow, isRipe)
    {
        FaynaKartoplya = faynaKartoplya;
    }

    public override bool CanHarvest()
    {
        return FaynaKartoplya && base.CanHarvest();
        
    }
}