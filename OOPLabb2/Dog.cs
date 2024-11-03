namespace OOPLabb2
{
    public class Dog : Animal
    {
        public bool Friendly { get; set; } = true; // egenskap för Dog

        public Dog()
        {
            Name = "Blixten";
            Species = "Dog";
            Age = 3;
            Weight = 50;
            Furry = true;
        }
        public void Bark() // egen metod för 'Dog'
        {
            Console.WriteLine($"{Name} is barking loudly!");
        }
        public override void makeSound()
        {
            Console.WriteLine($"{Name} is barking!");
        }
    }
}
