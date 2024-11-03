namespace OOPLabb2
{
    public class Chihuahua : Dog
    {
        public bool BarkAtPostman { get; set; } = true; // ny egenskap för chihuahua

        public Chihuahua()
        {
            Name = "Bob";
            Age = 1;
            Weight = 6;
        }

        public void Pose() // egen metod för chihuahua
        {
            Console.WriteLine($"{Name} is posing for the camera!");
        }
        public override void makeSound()
        {
            Console.WriteLine($"{Name} is barking!");
        }
    }
}
