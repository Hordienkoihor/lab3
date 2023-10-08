namespace lab3;

public record Dub : Plant
{
    public Dub(string shortName, string fullName, int growingTime, bool isRipe)
        : base( shortName,  fullName,  growingTime,false,  isRipe)
    {
        
        
    }
}