namespace OOPLabb2
{
    public class Chihuahua : Dog
    {
        public bool BarkAtPostman { get; set; } // ny egenskap för chihuahua

        // Default värden för Chihuahua
        public Chihuahua(string name = "Bob", string species = "Chihuahua", int age = 1, int weight = 6, bool furry = true, 
            bool friendly = true, bool barkAtPostman = true)
            :base(name, species, age, weight, furry, friendly)
        {
            BarkAtPostman = barkAtPostman;
        }

        public void Pose() // egen metod för chihuahua
        {
            Console.WriteLine($"{Name} is posing for the camera!");
        }
        public override void makeSound()
        {
            Console.WriteLine($"{Name} the {Species} is barking!");
        }
    }
}
