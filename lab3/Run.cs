namespace lab3;

public class Run
{
    static void Main()
    {   
        Farm ferma = new Farm("namee", 10);
        ferma.SetNewFarmer("Oleg", "Vlad", "Farmer", ferma);
        ferma.AddPlant(new Carrot("bubulka", "bububulka", 10, true, true));
        
            foreach (var plant in ferma.PlantsOnGrowing)
            {
                
                
                Console.WriteLine($"Plant Name: {plant.ShortName}");
                Console.WriteLine($"Full Name: {plant.FullName}");
                Console.WriteLine($"Growing Time: {plant.GrowingTime}");
                Console.WriteLine($"Is Need Regrow: {plant.IsNeedRegrow}");
                Console.WriteLine();
            }

            
            System.Threading.Thread.Sleep(10000);
            
        
        
        foreach (var plant in ferma.PlantsOnGrowing)
        {
            
            Console.WriteLine($"Plant Name: {plant.ShortName}");
            Console.WriteLine($"Full Name: {plant.FullName}");
            Console.WriteLine($"Growing Time: {plant.GrowingTime}");
            Console.WriteLine($"Is Need Regrow: {plant.IsNeedRegrow}");
            Console.WriteLine();
        }
        ferma.SetNewFarmer("buba", "boba", "megakrut", ferma);
        Console.WriteLine(ferma.Farmer.FirstName);
        Console.WriteLine(ferma.PlantsOnGrowing[0].CanHarvest());
    }
    
    

}