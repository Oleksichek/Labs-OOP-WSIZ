using Lab04;
using System.Collections.Generic;

public class Program
{
    private static List<ComplexNumber> ComplexNumbers = new List<ComplexNumber>()
    {
        new ComplexNumber(1, 2),
        new ComplexNumber(3, 4),
        new ComplexNumber(5, 6),
        new ComplexNumber(7, 8),
        new ComplexNumber(9, 10)
    };

    private static List<ComplexNumber> ComplexNumbersTwo = new List<ComplexNumber>()
    {
        new ComplexNumber(2, 3),
        new ComplexNumber(3, 5),
        new ComplexNumber(4, 7),
        new ComplexNumber(6, 7),
        new ComplexNumber(7, 9),
        new ComplexNumber(9, 10)
    };

    private static HashSet<ComplexNumber> ComplexNumberSet = new HashSet<ComplexNumber>()
    {
        new ComplexNumber(6, 7),
        new ComplexNumber(1, 2),
        new ComplexNumber(6, 7),
        new ComplexNumber(1, -2),
        new ComplexNumber(-5, 9)
    };

    private static Dictionary<string, ComplexNumber> ComplexNumberDictionary = new Dictionary<string, ComplexNumber>()
    {
        { "z1", new ComplexNumber(1, 2) },
        { "z2", new ComplexNumber(3, 4) },
        { "z3", new ComplexNumber(5, 6) },
        { "z4", new ComplexNumber(7, 8) },
        { "z5", new ComplexNumber(9, 10) }
    };

    private static void Main(string[] args)
    {
        ShowPart01();
        Console.WriteLine();
        Console.WriteLine();
        ShowPart02();
    }

    private static void ShowPart01()
    {
        Console.WriteLine("Default complex numbers:");
        ShowComplexNumberList(ComplexNumbers);

        ComplexNumbers.Sort();

        Console.WriteLine("Sorted complex numbers:");
        ShowComplexNumberList(ComplexNumbers);

        Console.WriteLine("Min value: " + ComplexNumbers.Min());
        Console.WriteLine("Max value: " + ComplexNumbers.Max());

        ShowComplexNumberList(ComplexNumbersTwo.Where(x => x.Im > 0).ToList());
    }

    private static void ShowPart02()
    {
        Console.WriteLine("Default complex numbers:");
        ShowComplexNumberList(ComplexNumbersTwo);

        ComplexNumbersTwo.Sort();

        Console.WriteLine("Sorted complex numbers:");
        ShowComplexNumberList(ComplexNumbersTwo);

        Console.WriteLine("Min value: " + ComplexNumbersTwo.Min());
        Console.WriteLine("Max value: " + ComplexNumbersTwo.Max());

        ShowComplexNumberList(ComplexNumbersTwo.Where(x => x.Im > 0).ToList());

        ComplexNumbersTwo.RemoveAt(1);
        ShowComplexNumberList(ComplexNumbersTwo);

        ComplexNumbersTwo.Remove(ComplexNumbersTwo.Min());
        ShowComplexNumberList(ComplexNumbersTwo);

        ComplexNumbersTwo.Clear();
        ShowComplexNumberList(ComplexNumbersTwo);
    }

    private static void ShowPart03()
    {
        Console.WriteLine("Complex number set:");
        ShowComplexNumberList(ComplexNumbersTwo);

        ComplexNumbersTwo.Sort();

        Console.WriteLine("Sorted complex numbers set:");
        ShowComplexNumberList(ComplexNumbersTwo);

        Console.WriteLine("Min value: " + ComplexNumbersTwo.Min());
        Console.WriteLine("Max value: " + ComplexNumbersTwo.Max());

        ShowComplexNumberList(ComplexNumbersTwo.Where(x => x.Im > 0).ToList());
    }

    private static void ShowPart04()
    {
        Console.WriteLine("Complex number dictionary:");
        ShowComplexNumberList(ComplexNumberDictionary);

        Console.WriteLine("Accessing elements by key:");
        Console.WriteLine("z1 " + ComplexNumberDictionary["z1"]);
        Console.WriteLine("z2 " + ComplexNumberDictionary["z2"]);
        Console.WriteLine("z3 " + ComplexNumberDictionary["z3"]);
        Console.WriteLine("z4 " + ComplexNumberDictionary["z4"]);
        Console.WriteLine("z5 " + ComplexNumberDictionary["z5"]);

        Console.WriteLine("Check z6 ContainsKey status: " + ComplexNumberDictionary.ContainsKey("z6"));

        Console.WriteLine("Answer to z");

        ComplexNumberDictionary.Remove("z3");

        ShowComplexNumberList(ComplexNumberDictionary);

        ComplexNumberDictionary.Remove(ComplexNumberDictionary.ElementAt(1).Key);

        ShowComplexNumberList(ComplexNumberDictionary);

        ComplexNumberDictionary.Clear();

        ShowComplexNumberList(ComplexNumberDictionary);
    }

    private static void ShowComplexNumberList(List<ComplexNumber> complexNumbers)
    {
        foreach (var compNum in ComplexNumbers)
            Console.WriteLine(compNum);
    }

    private static void ShowComplexNumberList(HashSet<ComplexNumber> complexNumberSet)
    {
        foreach (var compNum in complexNumberSet)
            Console.WriteLine(compNum);
    }

    private static void ShowComplexNumberList(Dictionary<string, ComplexNumber> complexNumberDictionary)
    {
        foreach (var kvp in complexNumberDictionary)
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
    }
}