namespace OOPLabb2
{
    public class Animal
    {
        // Egenskaper för alla djur med default värden
        public string Name { get; set; } = "Okänt namn";
        public string Species { get; set; } = "Okänd art";
        public int Age { get; set; } = 0;
        public int Weight { get; set; } = 0;
        public bool Furry { get; set; } = false;

        //Metoder som dom delar
        public virtual void makeSound()
        {
            Console.WriteLine($"{Name} is making a sound!");
        }
        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping lika a baby!");
        }
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating hamburgers and pizzas!");
        }

    }
}
