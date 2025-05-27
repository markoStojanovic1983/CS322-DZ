using System;

class DZ04
{
    static void Main()
    {
        // Main program loop that continues until user chooses to exit
        while (true)
        {
            // Display menu options for the user
            Console.WriteLine("\nOdaberite domaci zadatak za izvrsavanje:");
            Console.WriteLine("1. Zbir neparnih brojeva od 1 do n");
            Console.WriteLine("2. Dvostruke vrednosti brojeva od 8 do 16 unazad");
            Console.WriteLine("3. Provera da li cifre broja obrazuju strogo rastuci niz");
            Console.WriteLine("4. Izlaz iz programa");
            Console.Write("Izaberite domaci: ");
            string? choice = Console.ReadLine();

            // Read user choice with null handling
            if (string.IsNullOrEmpty(choice))
            {
                Console.WriteLine("Pogresan unos, pokusajte ponovo");
                continue;
            }

            // Process the user's selection
            switch (choice)
            {
                case "1":
                    Task1();
                    break;
                case "2":
                    Task2();
                    break;
                case "3":
                    Task3();
                    break;
                case "4":
                    Console.WriteLine("Zatvaram program...");
                    return;
                default:
                    Console.WriteLine("Pogresan unos, pokusajte ponovo");
                    break;
            }
        }
    }

    // DZ01
    static void Task1()
    {
        try
        {
            // Prompt user for input
            Console.WriteLine("Unesite broj (n):");
            string? input = Console.ReadLine();

            // Check for null or empty input
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Pogresan unos! Unos mora biti prirodan broj!");
                return;
            }

            // Parse the input to an integer
            int n = int.Parse(input);

            // Validate the input to ensure it's a natural number
            if (n < 1)
            {
                Console.WriteLine("Unos mora biti prirodan broj (n >= 1).");
                return;
            }

            // Calculate the sum of odd numbers
            int sum = 0;
            for (int i = 1; i <= n; i += 2)
            {
                sum += i;
            }

            Console.WriteLine($"Zbir neparnih brojeva od 1 do {n} je: {sum}");
        }
        catch
        {
            Console.WriteLine($"Pogresan unos! Unos mora biti prirodan broj!");
        }
    }

    // DZ02
    static void Task2()
    {
        Console.WriteLine("Dvostruke vrednosti prirodnih brojeva od 8 do 16 unazad: ");

        // Loop through numbers from 16 down to 8
        for (int i = 16; i >= 8; i--)
        {
            Console.WriteLine(i * 2);
        }
    }

    // DZ03
    static void Task3()
    {
        try
        {
            // Prompt user for input
            Console.WriteLine("Unesi prirodan broj manji od milijarde:");
            string? input = Console.ReadLine();

            // Check for null or empty input
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Pogresan unos! Unos mora biti prirodan broj manji od 1 000 000 000!");
                return;
            }

            // Parse the input to a long integer
            long number = long.Parse(input);

            // Validate the number range
            if (number < 0 || number >= 1_000_000_000)
            {
                Console.WriteLine("Broj mora biti prirodan i manji od 1 000 000 000.");
                return;
            }

            // Check if the digits form a strictly increasing sequence
            bool isStrictlyIncreasing = true;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] >= input[i + 1])
                {
                    isStrictlyIncreasing = false;
                    break;
                }
            }

            if (isStrictlyIncreasing)
            {
                Console.WriteLine($"Cifre broja {input} obrazuju strogo rastuci niz.");
            }
            else
            {
                Console.WriteLine($"Cifre broja {input} ne obrazuju strogo rastuci niz.");
            }
        }
        catch
        {
            Console.WriteLine($"Pogresan unos! Unos mora biti prirodan broj manji od 1 000 000 000!");
        }
    }
}
