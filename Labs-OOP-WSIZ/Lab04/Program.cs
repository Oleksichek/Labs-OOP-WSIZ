using Lab04;

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

    private static void ShowComplexNumberList(List<ComplexNumber> complexNumbers)
    {
        foreach (var compNum in ComplexNumbers)
            Console.WriteLine(compNum);
    }
}