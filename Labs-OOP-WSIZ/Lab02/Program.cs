using Lab02.Animals;
using Lab02.Classes;
using Lab02.Workers;

namespace Lab02
{
    public class Program
    {
        public static void Main()
        {
            Animal animal = new Animal("Burek");
            Animal dog = new Dog("Reksio");
            Animal cat = new Cat("Mruczek");
            Animal snake = new Snake("Kaa");

            Animal.SaySomething(animal);
            Console.WriteLine("Object typu: " + animal.GetType().Name);

            Animal.SaySomething(dog);
            Console.WriteLine("Object typu: " + dog.GetType().Name);

            Animal.SaySomething(cat);
            Console.WriteLine("Object typu: " + cat.GetType().Name);

            Animal.SaySomething(snake);
            Console.WriteLine("Object typu: " + snake.GetType().Name);

            Worker baker = new Baker();
            baker.Work();

            ClassA classA = new ClassA();
            ClassB classB = new ClassB();
            ClassC classC = new ClassC();
        }
    }
}