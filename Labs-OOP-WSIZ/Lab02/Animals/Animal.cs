namespace Lab02.Animals
{
    public class Animal
    {
        protected string _name;

        public Animal(string name) => _name = name;

        public virtual void Speak() => Console.WriteLine("Bark!");

        public static void SaySomething(Animal animal) => animal.Speak();
    }
}
