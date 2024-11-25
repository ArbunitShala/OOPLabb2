namespace OOPLabb2
{
    public class Tiger : Animal
    {
        public bool CamoflageStripes { get; set; } // egenskap för tiger

        // Default värden för Tiger
        public Tiger(string name = "GoldTooth", string species = "Tiger", int age = 10, int weight = 200, bool furry = true
            ,bool camoflageStripes = true)
            :base(name, species, age, weight, furry)
        {
            CamoflageStripes = camoflageStripes;
        }
        //Metod för tiger-klassen
        public void Roar()
        {
            Console.WriteLine($"{Name} is roaring very loud!");
        }
        public override void makeSound()
        {
            Console.WriteLine($"{Name} the {Species} is roaring!");
        }
    }
}
