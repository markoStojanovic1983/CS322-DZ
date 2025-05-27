using DZ11_2;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of concrete classes
        Student student = new Student("Marko", "Stojanovic", 2014, "1983", 8.75);
        Professor professor = new Professor("Dr Aleksandar", "Jovanovic", 2010, "Full Professor",
            new string[] { "C# Programming", "Databases", "Algorithms" });

        // Demonstrate polymorphism using interface type
        IAcademicMember[] members = { student, professor };

        // Display information for all academic members
        Console.WriteLine("Information about academic members:\n");
        foreach (var member in members)
        {
            Console.WriteLine($"Status: {member.GetAcademicStatus()}");
            member.DisplayInformation();
            Console.WriteLine();
        }
    }
}