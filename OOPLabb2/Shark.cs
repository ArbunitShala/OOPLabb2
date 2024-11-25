namespace OOPLabb2
{
    public class Shark : Animal
    {
        public bool SharpTeeth { get; set; } // egenskap för shark

        // Default värden för Shark
        public Shark(string name = "SilverTooth", string species = "Shark", int age = 21, int weight = 900, bool furry = false
            , bool sharpTeeth = true)
            :base(name, species, age, weight, furry)
        {
            SharpTeeth = sharpTeeth;
        }

        public void Swim() // Metod för shark-klassen
        {
            Console.WriteLine($"{Name} is swimming very fast!");
        }
        public override void makeSound()
        {
            Console.WriteLine($"{Name} the {Species} is making biting and splashing noises!");
        }
    }
}
