namespace lab3;

public class Farmer
{
    
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialization { get; set; }

        private Farm farm;
        
        public void HandlePlantGrown(object sender, PlantGrownEventArgs e)
        {
                Plant grownPlant = e.Plant;
                Console.WriteLine($"Plant {grownPlant.ShortName} has grown!");

                // Если растение нужно пересаживать, вырывайте его и сажайте новое
                if (grownPlant.IsNeedRegrow)
                {
                        Farm farm = this.farm; // Получите ссылку на ферму
                        farm.DeletePlant(grownPlant);

                        // Создайте новое растение того же типа и добавьте его на ферму
                        if (grownPlant is Carrot)
                        {
                                Carrot newPlant = new Carrot(grownPlant.ShortName, grownPlant.FullName, grownPlant.GrowingTime, true);
                                farm.AddPlant(newPlant);             
                        }
                        else if (grownPlant is Potato)
                        {
                                Potato newPlant = new Potato(grownPlant.ShortName, grownPlant.FullName, grownPlant.GrowingTime, true);
                                farm.AddPlant(newPlant);
                        }
                        else if(grownPlant is TavKakomMestePLantCeZapuc)
                        {
                                TavKakomMestePLantCeZapuc newPlant = new TavKakomMestePLantCeZapuc(grownPlant.ShortName, grownPlant.FullName, grownPlant.GrowingTime, true);
                                farm.AddPlant(newPlant);
                        }
                        
                        
                }
        }
        
        public Farmer(string firstName, string lastName, string specialization)
        {
                FirstName = firstName;
                LastName = lastName;
                Specialization = specialization;
                farm = this.farm;
        }
}