namespace lab3;

public class Run
{
    static void Main()
    {   
        Farm ferma = new Farm("namee", 10);
        ferma.SetNewFarmer("Oleg", "Vlad", "Farmer", ferma);
        ferma.AddPlant(new Carrot("bubulka", "bububulka", 10, true, true));
        Console.WriteLine($"Farmers name {ferma.Farmer.FirstName}");
        Console.WriteLine("Ovochi:");
            foreach (var plant in ferma.PlantsOnGrowing)
            {
                
                
                Console.WriteLine($"Plant Name: {plant.ShortName}");
                Console.WriteLine($"Full Name: {plant.FullName}");
                Console.WriteLine($"Growing Time: {plant.GrowingTime}");
                Console.WriteLine($"Is Need Regrow: {plant.IsNeedRegrow}");
                Console.WriteLine();
            }

            Console.WriteLine("Rezultaty rosty: ");
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
        Console.WriteLine($"New farmers name {ferma.Farmer.FirstName}");
        Console.WriteLine("Test metoda na urojai(expected true: ");
        Console.WriteLine(ferma.PlantsOnGrowing[0].CanHarvest());
    }
    
    

}