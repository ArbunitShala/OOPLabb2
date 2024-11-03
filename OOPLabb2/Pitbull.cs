namespace OOPLabb2
{
    public class Pitbull : Dog
    {
        public bool Scary { get; set; } = true; // egenskap för pitbull

        public Pitbull()
        {
            Name = "Cupcake";
            Age = 6;
            Weight = 60;
        }

        public void Attack() // egen metod för pitbull
        {
            Console.WriteLine($"{Name} is attacking intruder!");
        }

        public override void makeSound()
        {
            Console.WriteLine($"{Name} is barking!");
        }
    }
}
