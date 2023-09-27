namespace lab3;

public record Cibulya : Plant
{
    
    
    public Cibulya(string shortName, string fullName, int growingTime, bool isNeedRegrow, bool isRipe)
        : base(shortName, fullName, growingTime, isNeedRegrow, isRipe)
    {
        
    }
}