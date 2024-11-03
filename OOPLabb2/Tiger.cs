namespace OOPLabb2
{
    public class Tiger : Animal
    {
        public bool CamoflageStripes { get; set; } = true; // egenskap för tiger
        public Tiger()
        {
            Name = "GoldTooth";
            Species = "Tiger";
            Age = 10;
            Weight = 200;
            Furry = true;

        }
        //Metod för tiger-klassen
        public void Roar()
        {
            Console.WriteLine($"{Name} is roaring very loud!");
        }
        public override void makeSound()
        {
            Console.WriteLine($"{Name} is roaring!");
        }
    }
}
