namespace lab3;

public class Farm
{
    private int _plantsLimit;
    public string Name { get; set; }
    public int PlantsLimit => _plantsLimit;
    public List<Plant> PlantsOnGrowing { get; }
    public Farmer? Farmer { get; private set; }
    
    public Farm() : this("Farm")
    {}
    public Farm(string name) : this(name, 20)
    {}

    public Farm(string name, int limit) : this(name, limit, null)
    { }
    public Farm(string name, int limit, Farmer? farmer)
    {
        _plantsLimit = limit;
        PlantsOnGrowing = new List<Plant>(20);
        Farmer = farmer;
    }
    
    public bool AddPlant(Plant plant)
    {
        if (PlantsOnGrowing.Count == PlantsLimit)
        {
            return false;
        }
        
        PlantsOnGrowing.Add(plant);
        PlantsOnGrowing.Add(plant);
        plant.PlantGrown += Farmer.HandlePlantGrown;
        Timer timer = null;
        timer = new Timer(_ =>
        {
            var index = PlantsOnGrowing.IndexOf(plant);
            if (index != -1)
            {
                var grownPlant = PlantsOnGrowing[index];
            
                
                grownPlant.OnPlantGrown();
            
                Console.WriteLine($"Plant {grownPlant.ShortName} has grown!");
                
                timer?.Dispose();
            }
        }, null, plant.GrowingTime * 1000, Timeout.Infinite);

        return true;
    
        
    }
    
    public Plant? FindByPlantName(string name)
    {
        return PlantsOnGrowing.Find(x => x.ShortName == name || x.FullName == name);
    }
    public bool DeletePlant(Plant plant)
    {
        return PlantsOnGrowing.Remove(plant);
    }

    public void SetNewFarmer(string firstName, string lastName, string specialization)
    {
        this.Farmer = new Farmer(firstName, lastName, specialization);
    }
}

