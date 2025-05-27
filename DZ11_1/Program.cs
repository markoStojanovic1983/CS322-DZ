using DZ11_1;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of courses
        List<Kurs> courses = new List<Kurs>
        {
        new Kurs("Programiranje C#", 30, 35),
            new Kurs("Web Dizajn", 35, 25),
            new Kurs("Baze Podataka", 55, 40),
            new Kurs("Matematika", 90, 30)
        };

        Console.WriteLine("Before sorting:");
        foreach (var course in courses)
        {
            Console.WriteLine(course);
        }

        // Sort the list using the implemented CompareTo method
        courses.Sort();

        Console.WriteLine("\nAfter sorting by maximum registrations (descending):");
        foreach (var course in courses)
        {
            Console.WriteLine(course);
        }
    }
}