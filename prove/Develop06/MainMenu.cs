using System.Runtime.InteropServices;

public class MainMenu
{
    private List<Goal> goals = new List<Goal>();
    private double _userScore = 0;
    private Random random = new Random();
    public void Run()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Create a New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
    private void CreateNewGoal()
    {
        Console.WriteLine("\nGoal Type Menu:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Choose a goal type: ");
        string goalType = Console.ReadLine();

        Console.Write("What is the task? ");
        string taskName = Console.ReadLine();

        Console.Write("Describe the task: ");
        string description = Console.ReadLine();

        Console.Write("How many points would you like to get for this task? ");
        int points = int.Parse(Console.ReadLine());

        if (goalType == "1")
        {
            goals.Add(new SimpleGoal(taskName, description, points));
        }
        else if (goalType == "2")
        {
            goals.Add(new EternalGoal(taskName, description, points));
        }
        else if (goalType == "3")
        {
            Console.Write("How many times would you like to do this? ");
            int targetCount = int.Parse(Console.ReadLine());
            goals.Add(new ChecklistGoal(taskName, description, points, targetCount, 0));
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }

    private void ListGoals()
    {
        Console.WriteLine("\nList of Goals:");
        foreach (Goal goal in goals)
        {
            Console.WriteLine(goal.DetailsString());
        }
        Console.WriteLine($"Total Score: {_userScore}");
    }

    private void SaveGoals()
    {
        Console.Write("Save as (file name): ");
        string fileName = Console.ReadLine();
        
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.SaveString());
            }
            writer.WriteLine(_userScore);
        }

        Console.WriteLine("Goals saved successfully.");
    }

    private void LoadGoals()
    {
        Console.Write("Open a file (enter the file name): ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("Invalid Input or File Does Not Exist.");
            return;
        }

        using (StreamReader reader = new StreamReader(fileName))
        {
            goals.Clear();
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                Goal goal = Goal.LoadGoal(parts);
                goals.Add(goal);
            }
            _userScore = int.Parse(reader.ReadLine());
        }

        Console.WriteLine("Goals loaded successfully.");
    }

    private void RecordEvent()
    {
        Console.Write("What task did you do? ");
        string taskName = Console.ReadLine();

        Goal goal = goals.Find(g => g.GetTaskName() == taskName);
        if (goal == null)
        {
            Console.WriteLine("Task not found.");
            return;
        }

        int pointsEarned = goal.RecordEvent(random);
        _userScore += pointsEarned;
        Console.WriteLine($"You earned {pointsEarned} points!");

        if (_userScore >= 1000)
        {
            Console.WriteLine("Congratulations! You got 1000 points! This could be exchanged to our store as a discount voucher!");
            _userScore -= 1000;
        }
    }
}
