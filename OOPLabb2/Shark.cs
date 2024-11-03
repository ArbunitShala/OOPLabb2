namespace OOPLabb2
{
    public class Shark : Animal
    {
        public bool SharpTeeth { get; set; } = true; // egenskap för shark

        public Shark()
        {
            Name = "SilverTooth";
            Species = "Shark";
            Age = 21;
            Weight = 900;
            Furry = false;
        }

        public void Swim() // Metod för shark-klassen
        {
            Console.WriteLine($"{Name} is swimming very fast!");
        }
        public override void makeSound()
        {
            Console.WriteLine($"{Name} is making biting and splashing noises!");
        }
    }
}
