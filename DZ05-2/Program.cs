using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create 2 Posetioc instances
        Posetioc posetioc1 = new Posetioc();
        Posetioc posetioc2 = new Posetioc();

        // Prepopulate data
        posetioc1.Ime = PomocnaKlasa.GenerisiRec();
        posetioc1.Prezime = PomocnaKlasa.GenerisiRec();
        posetioc1.BrojUlaznice = PomocnaKlasa.GenerisiBroj();

        posetioc2.Ime = PomocnaKlasa.GenerisiRec();
        posetioc2.Prezime = PomocnaKlasa.GenerisiRec();
        posetioc2.BrojUlaznice = PomocnaKlasa.GenerisiBroj();

        // Show results
        Console.WriteLine("Posetilac 1:");
        Console.WriteLine($"Ime: {posetioc1.Ime}, Prezime: {posetioc1.Prezime}, Broj ulaznice: {posetioc1.BrojUlaznice}");

        Console.WriteLine("\nPosetilac 2:");
        Console.WriteLine($"Ime: {posetioc2.Ime}, Prezime: {posetioc2.Prezime}, Broj ulaznice: {posetioc2.BrojUlaznice}");
    }
}
