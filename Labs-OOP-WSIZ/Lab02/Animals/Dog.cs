namespace Lab02.Animals
{
    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"{_name} robi woof woof!");
        }
    }
}
