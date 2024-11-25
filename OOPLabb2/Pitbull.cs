namespace OOPLabb2
{
    public class Pitbull : Dog
    {
        public bool Scary { get; set; } // egenskap för pitbull

        // Default värden för Pitbull
        public Pitbull(string name = "Cupcake", string species = "Pitbull", int age = 6, int weight = 60, bool furry = true
            , bool friendly = false, bool scary = true)
            :base(name, species, age, weight, furry, friendly)
        {
            Scary = scary;
        }

        public void Attack() // egen metod för pitbull
        {
            Console.WriteLine($"{Name} is attacking intruder!");
        }

        public override void makeSound()
        {
            Console.WriteLine($"{Name} the {Species} is barking!");
        }
    }
}
