namespace Lab02.Animals
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"{_name} robi miau miau!");
        }
    }
}
