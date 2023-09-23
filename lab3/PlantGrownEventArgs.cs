namespace lab3;

public class PlantGrownEventArgs : EventArgs
{
    public Plant Plant { get; }

    public PlantGrownEventArgs(Plant plant)
    {
        Plant = plant;
    }
}