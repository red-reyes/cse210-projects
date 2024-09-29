using System;
class Program
{
    static void Main(string[]args)
    {
        Journal journal = new Journal();
        string filename = "myjournal.txt";
        Console.WriteLine($"Using file: {filename}");

        while (true)
        {
            Console.WriteLine("\nJournal Menu: ");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display All Entries");
            Console.WriteLine("3. Save Journal to File");
            Console.WriteLine("4. Load Journal from File");
            Console.WriteLine("5. Exit Journal");
            Console.WriteLine("Select an option");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.AddEntry();
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    journal.SaveToFile(filename);
                    break;
                case "4":
                    journal.LoadfromFile(filename);
                    break;
                case "5":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.\n");
                    break;
            }
        }
    }
}