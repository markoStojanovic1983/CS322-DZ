using System;

namespace HoroscopeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask for user information
            Console.WriteLine("Horoscope App");
            Console.WriteLine("--------------");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your surname: ");
            string surname = Console.ReadLine();

            Console.Write("Enter your birth date (DD/MM/YYYY): ");
            string dateInput = Console.ReadLine();

            // Try to parse the date
            try
            {
                string[] dateParts = dateInput.Split('/');
                int day = int.Parse(dateParts[0]);
                int month = int.Parse(dateParts[1]);
                int year = int.Parse(dateParts[2]);

                // Find zodiac sign
                string zodiacSign = FindZodiacSign(day, month);

                // Print results
                Console.WriteLine($"\nHello {name} {surname}!");
                Console.WriteLine($"Your birth date is: {day}/{month}/{year}");
                Console.WriteLine($"Your zodiac sign is: {zodiacSign}");
            }
            catch
            {
                Console.WriteLine("Error: Please enter a valid date in format DD/MM/YYYY.");
            }

            // Wait for user input before closing
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static string FindZodiacSign(int day, int month)
        {
            if ((month == 3 && day >= 21) || (month == 4 && day <= 19))
                return "Aries";
            else if ((month == 4 && day >= 20) || (month == 5 && day <= 20))
                return "Taurus";
            else if ((month == 5 && day >= 21) || (month == 6 && day <= 20))
                return "Gemini";
            else if ((month == 6 && day >= 21) || (month == 7 && day <= 22))
                return "Cancer";
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
                return "Leo";
            else if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
                return "Virgo";
            else if ((month == 9 && day >= 23) || (month == 10 && day <= 22))
                return "Libra";
            else if ((month == 10 && day >= 23) || (month == 11 && day <= 21))
                return "Scorpio";
            else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
                return "Sagittarius";
            else if ((month == 12 && day >= 22) || (month == 1 && day <= 19))
                return "Capricorn";
            else if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
                return "Aquarius";
            else
                return "Pisces";
        }
    }
}