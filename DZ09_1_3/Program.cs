namespace DZ09_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Choose a task to run:");
                Console.WriteLine("1. Task 1: Counter up to 3000 with Sum");
                Console.WriteLine("2. Task 2: Sum of First 100 Even Numbers");
                Console.WriteLine("3. Task 3: Sum of Even Numbers Between 21 and 99");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice (0-3): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RunTask1();
                        break;
                    case "2":
                        RunTask2();
                        break;
                    case "3":
                        RunTask3();
                        break;
                    case "0":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 0 and 3.");
                        break;
                }

                if (running)
                {
                    Console.WriteLine("\nPress any key to return to the main menu...");
                    Console.ReadKey();
                    Console.Clear(); // Clear the console for a cleaner menu
                }
            }
        }

        static void RunTask1()
        {
            int sum = 0;
            for (int i = 1; i <= 3000; i++)
            {
                sum += i;
            }
            Console.WriteLine("Task 1: The sum of numbers from 1 to 3000 is: " + sum);
        }

        static void RunTask2()
        {
            int sum = 0;
            int count = 0;

            for (int i = 2; count <=100; i += 2)
            {
                sum += i;
                count++;
            }
            

            Console.WriteLine("Task 2: The sum of the first 100 even numbers is: " + sum);
        }

        static void RunTask3()
        {
            int sum = 0;
            for (int i = 22; i <= 98; i += 2)
            {
                sum += i;
            }
            Console.WriteLine("Task 3: The sum of even numbers between 21 and 99 is: " + sum);
        }
    }
}