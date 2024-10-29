using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your username: ");
        string username = Console.ReadLine();
        Console.WriteLine($"Hello {username}. Welcome to Activity Tracker. What would you like to do?");

        Tracker tracker = new Tracker();

        while (true)
        {
            Console.WriteLine("\nMain Menu");
            Console.WriteLine("1. Create Activity");
            Console.WriteLine("2. Load Activity");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateActivity(tracker);
                    break;
                case "2":
                    tracker.LoadActivities();
                    break;
                case "3":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void CreateActivity(Tracker tracker)
    {
        Console.WriteLine("\nChoose Activity Type:");
        Console.WriteLine("1. Running");
        Console.WriteLine("2. Cycling");
        Console.WriteLine("3. Swimming");
        Console.Write("Choose an option: ");
        string activityType = Console.ReadLine();

        Activity activity = null;

        switch (activityType)
        {
            case "1":
                activity = new Running(0, DateTime.Now, DateTime.Now);
                break;
            case "2":
                activity = new Cycling(0, DateTime.Now, DateTime.Now);
                break;
            case "3":
                activity = new Swimming(0, DateTime.Now, DateTime.Now);
                break;
            default:
                Console.WriteLine("Invalid choice. Returning to Main Menu.");
                return;
        }

        activity.Start();

        Console.Write("How long did you complete the activity in meters? ");
        if (double.TryParse(Console.ReadLine(), out double distance))
        {
            // Update distance based on user input
            activity.SetDistance(distance);
            tracker.SaveActivity(activity);
        }
        else
        {
            Console.WriteLine("Invalid distance entered. Activity not saved.");
        }
    }
}