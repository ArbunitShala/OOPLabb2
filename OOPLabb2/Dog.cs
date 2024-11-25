namespace OOPLabb2
{
    public class Dog : Animal
    {
        public bool Friendly { get; set; } // egenskap för Dog


        // Default värden för Dog
        public Dog(string name = "Blixten", string species = "Dog", int age = 3, int weight = 50, bool furry = true,
            bool friendly = true)
            :base(name, species, age, weight, furry)
        {
            Friendly = friendly;
        }
        public void Bark() // egen metod för 'Dog'
        {
            Console.WriteLine($"{Name} is barking loudly!");
        }
        public override void makeSound()
        {
            Console.WriteLine($"{Name} the {Species} is barking!");
        }
    }
}
