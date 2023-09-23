namespace lab3;

public class Farmer
{
    
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialization { get; set; }

        private Farm farm;
        
        public void HandlePlantGrown(object sender, PlantGrownEventArgs e)
        {
                if (e.Plant is Carrot grownCarrot)
                {     
                        
                        Console.WriteLine($"Carrot {grownCarrot.ShortName} has grown!");
                        if (grownCarrot.IsNeedRegrow)
                        {       
                                Farm farm = this.farm;
                                farm.DeletePlant(grownCarrot);
                                Carrot newCarrot = new Carrot(grownCarrot.ShortName, grownCarrot.FullName, grownCarrot.GrowingTime, true);
                                farm.AddPlant(newCarrot);
                        }
                }
                else if (e.Plant is Potato grownPotato)
                {
                        Console.WriteLine($"Potato {grownPotato.ShortName} has grown!");
                        if (grownPotato.IsNeedRegrow)
                        {
                                Farm farm = this.farm;
                                farm.DeletePlant(grownPotato);
                                // Potato newPotato = new Potato(grownPotato.ShortName, grownPotato.FullName, grownPotato.GrowingTime, true);
                                farm.AddPlant(grownPotato with{IsNeedRegrow = false});
                        }
                }
                else if (e.Plant is Cibulya grownCibulya)
                {
                        Console.WriteLine($"Cibulya {grownCibulya.ShortName} has grown!");
                        if (grownCibulya.IsNeedRegrow)
                        {
                                Farm farm = this.farm;
                                farm.DeletePlant(grownCibulya);
                                Cibulya newCibulya = new Cibulya(grownCibulya.ShortName, grownCibulya.FullName, grownCibulya.GrowingTime, true);
                                farm.AddPlant(newCibulya);
                                
                        }
                }
                
        }
        
        public Farmer(string firstName, string lastName, string specialization, Farm farm)
        {
                FirstName = firstName;
                LastName = lastName;
                Specialization = specialization;
                this.farm = farm;
        }
}