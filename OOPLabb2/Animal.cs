namespace OOPLabb2
{
    public class Animal
    {
        // Egenskaper för alla djur
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; } 
        public int Weight { get; set; }
        public bool Furry { get; set; }

        // Default värden för animal nedanför
        // Constructor för att skapa nya djur
        public Animal(string name = "Okänt namn",string species = "Okänd art",int age = 0,int weight = 0,bool furry = false)
        {
            Name = name;
            Species = species;
            Age = age;
            Weight = weight;
            Furry = furry;
        }

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
