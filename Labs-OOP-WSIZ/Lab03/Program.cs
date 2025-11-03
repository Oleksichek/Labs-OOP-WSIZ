using Lab03;

public class Program
{
    private static void Main(string[] args)
    {
        ComplexNumber c1 = new ComplexNumber(2, 3);
        ComplexNumber c2 = new ComplexNumber(6, 7);
        ComplexNumber c3 = new ComplexNumber(8, 9);
        ComplexNumber c4 = new ComplexNumber(4, 5);
        ComplexNumber c5 = new ComplexNumber(4, 5);

        if (c1 == c2) Console.WriteLine($"c1 = {c1} not equal c2 = {c2}");
        else Console.WriteLine($"c1 = {c1} equal c2 = {c2}");

        if (c4 != c5) Console.WriteLine($"c4 = {c4} equal c5 = {c5}");
        else Console.WriteLine($"c4 = {c4} not equal c5 = {c5}");

        ComplexNumber sum = c1 + c2;
        Console.WriteLine($"Sum: {sum}");
        ComplexNumber difference = c3 - c4;
        Console.WriteLine($"Difference: {difference}");
        ComplexNumber multiply = c1 * c2;
        Console.WriteLine($"Multiply: {multiply}");
        Console.WriteLine($"c3: {c3}; -c3: {-c3}");
        Console.WriteLine($"Modulus of C4: {c4.Modulus()}");
    }
}