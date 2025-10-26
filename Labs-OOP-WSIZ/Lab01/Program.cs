using Lab01;

public class Program
{
    private static List<Animal> animals = new List<Animal>();

    public static void Main()
    {
        Console.WriteLine("To jest cwiczenie 1");
        Console.WriteLine("Nacisnij ENTER aby kontynuowac...");
        Console.ReadLine();

        for (int i = 1; i <= 3; i++)
        {
            Animal animal = AskForAnimal();
            animals.Add(animal);
            Console.WriteLine($"Dodano zwierzaka {animal.Name} do listy.");
            Console.WriteLine("Nacisnij ENTER aby kontynuowac...");
            Console.ReadLine();
        }

        Animal copyAnimal = new Animal(animals.Last());
        copyAnimal.Name = "Hiko";
        animals.Add(copyAnimal);

        foreach (Animal animal in animals)
        {
            Console.Clear();
            Console.WriteLine($"Nazwa: {animal.Name}");
            Console.WriteLine($"Gatunek: {animal.GetSpecies()}");
            Console.WriteLine($"Liczba nóg: {animal.GetLagsCount()}");
            Console.Write("Odglos zwierzaka: ");
            animal.Speak();
            Console.WriteLine("Nacisnij ENTER aby kontynuowac...");
            Console.ReadLine();
        }

        Console.Clear();
        Console.WriteLine("Liczba zwierzaków: " + Animal.GetAnimalsCount());
    }

    private static Animal AskForAnimal()
    {
        Console.Clear();
        Console.WriteLine("Podaj nazwe zwierzaka:");
        string animalName = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Podaj gatunek zwierzaka:");
        string animalSpecies = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Podaj liczbę nóg zwierzaka:");
        string animalStringLagsCount = Console.ReadLine();

        while (!Int32.TryParse(animalStringLagsCount, out int animalLagsCount))
        {
            Console.Clear();
            Console.WriteLine("Podaj liczbę nóg zwierzaka:");
            animalStringLagsCount = Console.ReadLine();
        }

        return new Animal(animalName, animalSpecies, Int32.Parse(animalStringLagsCount));
    }
}