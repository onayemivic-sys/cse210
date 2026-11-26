using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        // Tracks completed activities during this session.
        // This is an additional feature beyond the core requirements.
        int completedActivities = 0;

        while (choice != 4)
        {
            Console.Clear();

            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine();

            Console.Write("Select a choice from the menu: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                Console.WriteLine("Press Enter to continue.");
                Console.ReadLine();
                continue;
            }

            switch (choice)
            {
                case 1:
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    completedActivities++;
                    break;

                case 2:
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    completedActivities++;
                    break;

                case 3:
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    completedActivities++;
                    break;

                case 4:
                    Console.WriteLine();
                    Console.WriteLine("Thank you for using the Mindfulness Program!");
                    Console.WriteLine($"You completed {completedActivities} activities during this session.");
                    Console.WriteLine("Have a peaceful day!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select 1, 2, 3, or 4.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    break;
            }

            if (choice >= 1 && choice <= 3)
            {
                Console.WriteLine();
                Console.WriteLine("Press Enter to return to the main menu.");
                Console.ReadLine();
            }
        }
    }
}