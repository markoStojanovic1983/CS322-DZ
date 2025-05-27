using System;

public static class PomocnaKlasa
{
    private static Random random = new Random();

    // Method that returns 8 random chars
    public static string GenerisiRec()
    {
        char prvoSlovo = (char)random.Next('A', 'Z' + 1); 
        string ostalaSlova = string.Empty;

        for (int i = 0; i < 7; i++)
        {
            ostalaSlova += (char)random.Next('a', 'z' + 1); 
        }

        return prvoSlovo + ostalaSlova;
    }

    // Method that return random number 1-200 interval
    public static int GenerisiBroj()
    {
        return random.Next(1, 201); 
    }
}
