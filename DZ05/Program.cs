using System;

class PowerCalculator
{
    static void Main()
    {
        // Prompt user for input
        Console.WriteLine("Unesite vrednost broja (x) koji treba da se stepenuje:");
        string? xInput = Console.ReadLine();
        if (string.IsNullOrEmpty(xInput))
        {
            Console.WriteLine("Greška: Morate uneti vrednost za broj (x)!");
            return;
        }

        // Prompt user for input
        Console.WriteLine("Unesite vrednost stepena (n):");
        string? nInput = Console.ReadLine();
        if (string.IsNullOrEmpty(nInput))
        {
            Console.WriteLine("Greška: Morate uneti vrednost za stepen (n)!");
            return;
        }

        try
        {
            // Parse inputs
            double x = double.Parse(xInput);
            int n = int.Parse(nInput);

            // Validation checks
            if (x == 0)
            {
                Console.WriteLine("Greška: Vrednost broja (x) ne sme biti 0!");
                return;
            }

            if (n < 0)
            {
                Console.WriteLine("Greška: Vrednost stepena (n) mora biti veća ili jednaka 0!");
                return;
            }

            // Call the power function
            double result = CalculatePower(x, n);

            Console.WriteLine($"Rezultat stepenovanja {x}^{n} je: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Greška: Molimo unesite ispravne numeričke vrednosti za x i n.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Neočekivana greška: {ex.Message}");
        }
    }

    // Function to calculate power
    static double CalculatePower(double x, int n)
    {
        return Math.Pow(x, n);
    }
}
