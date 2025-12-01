using Lab05;
using System.Text.Json;
using System.Xml.Serialization;

public class Program
{
    private static void Main(string[] args)
    {
        SumLinesFromCSVIrisFile();
    }

    #region Text File Operations

    private static void SingleTextSaver()
    {
        List<string> tempTextList = new List<string>();

        for (int i = 0; i < 4; i++)
        {
            Console.Clear();
            Console.Write("Enter text: ");
            string inputText = Console.ReadLine();
            tempTextList.Add(inputText);
        }

        File.WriteAllLines("savedText.txt", tempTextList);
    }

    private static void TextLoader()
    {
        string filePath = "savedText.txt";
        if (File.Exists(filePath))
        {
            string[] loadedTextList = File.ReadAllLines(filePath);
            Console.Clear();
            Console.WriteLine("Loaded Texts:");

            foreach (var line in loadedTextList)
                Console.WriteLine(line);
        }
        else Console.WriteLine("No saved text file found.");
    }

    private static void AddTextToFile()
    {
        Console.Clear();
        Console.Write("Enter text to add: ");
        string inputText = Console.ReadLine();
        using (StreamWriter sw = File.AppendText("savedText.txt"))
        {
            sw.WriteLine(inputText);
        }
    }

    #endregion

    #region JSON File Operations

    private static void SaveJsonStudentsToFile()
    {
        List<Student> studentList = new List<Student>()
        {
            new Student() { Imie = "Jan", Nazwisko = "Kowalski", Oceny = new List<int>() {5, 4, 3} },
            new Student() { Imie = "Anna", Nazwisko = "Nowak", Oceny = new List<int>() {4, 4, 5} },
            new Student() { Imie = "Piotr", Nazwisko = "Zielinski", Oceny = new List<int>() {3, 2, 4} }
        };

        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(studentList, options);
        File.WriteAllText("students.json", jsonString);
    }

    private static void LoadJsonStudentsFromFile()
    {
        string filePath = "students.json";
        if (File.Exists(filePath))
        {
            string jsonString = File.ReadAllText(filePath);
            List<Student>? studentList = JsonSerializer.Deserialize<List<Student>>(jsonString);
            if (studentList != null)
            {
                Console.Clear();
                Console.WriteLine("Loaded Students:");
                foreach (var student in studentList)
                    Console.WriteLine($"Name: {student.Imie} {student.Nazwisko}, Grades: {string.Join(", ", student.Oceny)}");
            }
        }
        else Console.WriteLine("No students.json file found.");
    }

    #endregion

    #region XML File Operations

    private static void SaveXMLStudentsToFile()
    {
        List<Student> studentList = new List<Student>()
        {
            new Student() { Imie = "Jan", Nazwisko = "Kowalski", Oceny = new List<int>() {5, 4, 3} },
            new Student() { Imie = "Anna", Nazwisko = "Nowak", Oceny = new List<int>() {4, 4, 5} },
            new Student() { Imie = "Piotr", Nazwisko = "Zielinski", Oceny = new List<int>() {3, 2, 4} }
        };
        var serializer = new XmlSerializer(typeof(List<Student>));
        using (var writer = new StreamWriter("students.xml"))
        {
            serializer.Serialize(writer, studentList);
        }
    }

    private static void LoadXMLStudentsFromFile()
    {
        string filePath = "students.xml";
        if (File.Exists(filePath))
        {
            var serializer = new XmlSerializer(typeof(List<Student>));
            using (var reader = new StreamReader(filePath))
            {
                List<Student>? studentList = (List<Student>?)serializer.Deserialize(reader);
                if (studentList != null)
                {
                    Console.Clear();
                    Console.WriteLine("Loaded Students:");
                    foreach (var student in studentList)
                        Console.WriteLine($"Name: {student.Imie} {student.Nazwisko}, Grades: {string.Join(", ", student.Oceny)}");
                }
            }
        }
        else Console.WriteLine("No students.xml file found.");
    }

    #endregion

    private static void ReadCSVIrisFile()
    {
        string filePath = "iris.csv";
        if (File.Exists(filePath))
        {
            var lines = File.ReadAllLines(filePath);
            Console.Clear();
            Console.WriteLine("Iris Dataset:");
            foreach (var line in lines)
                Console.WriteLine(line);
        }
        else Console.WriteLine("No iris.csv file found.");
    }

    private static void SumLinesFromCSVIrisFile()
    {
        string filePath = "iris.csv";
        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            for (int i = 1; i < lines.Length-1; i++)
            {
                float sum = 0;
                string[] parts = lines[i].Split(',');
                foreach (var part in parts)
                {
                    string tempPart = part.Replace('.', ',');
                    if (float.TryParse(tempPart, out float value))
                        sum += value;
                }
                Console.WriteLine($"Sum of first column values: {sum}");
            }
        }
        else Console.WriteLine("No iris.csv file found.");
    }
}