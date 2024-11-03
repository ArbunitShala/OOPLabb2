namespace OOPLabb2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // skapar olika djur
            Tiger tiger = new Tiger();
            Shark shark = new Shark();
            Dog dog = new Dog();
            Pitbull pitbull = new Pitbull();
            Chihuahua chihuahua = new Chihuahua();

            // djuren gör ljud
            tiger.makeSound();
            shark.makeSound();
            dog.makeSound();
            pitbull.makeSound();
            chihuahua.makeSound();

            Console.WriteLine("------------------------");

            // djuren gör sina egna metoder
            tiger.Roar();
            shark.Swim();
            dog.Bark();
            pitbull.Attack();
            chihuahua.Pose();
        }
    }
}
