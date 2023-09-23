namespace lab3;

public class Run
{
    static void Main()
    {   
        Farm ferma = new Farm("namee", 10, new Farmer("Oleg", "Vlad", "Farmer"));
        ferma.AddPlant(new Carrot("bubulka", "bububulka", 10, true));
        for (int i = 0; i < 10; i++)
        {
            foreach (var plant in ferma.PlantsOnGrowing)
            {
                // Print information about each plant
                Console.WriteLine($"Plant Name: {plant.ShortName}");
                Console.WriteLine($"Full Name: {plant.FullName}");
                Console.WriteLine($"Growing Time: {plant.GrowingTime}");
                Console.WriteLine($"Is Need Regrow: {plant.IsNeedRegrow}");
                Console.WriteLine();
            }

            // Wait for a second (simulate the passage of time)
            System.Threading.Thread.Sleep(1000);
            
        }
        
        foreach (var plant in ferma.PlantsOnGrowing)
        {
            // Print information about each plant
            Console.WriteLine($"Plant Name: {plant.ShortName}");
            Console.WriteLine($"Full Name: {plant.FullName}");
            Console.WriteLine($"Growing Time: {plant.GrowingTime}");
            Console.WriteLine($"Is Need Regrow: {plant.IsNeedRegrow}");
            Console.WriteLine();
        }
        
    }
    
    

}