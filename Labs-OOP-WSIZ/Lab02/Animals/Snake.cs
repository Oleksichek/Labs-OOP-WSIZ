namespace Lab02.Animals
{
    public class Snake : Animal
    {
        public Snake(string name) : base(name)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"{_name} robi ssssssss!");
        }
    }
}
