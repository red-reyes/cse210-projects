using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private double totalScore;

    public GoalManager()
    {
        goals = new List<Goal>();
        totalScore = 0;
        
    }

    public void Start()
    {
       

        bool running = true;

        while (running)
        {
        Console.WriteLine($"1. Create New Goal");
        Console.WriteLine($"2. List New Task");
        Console.WriteLine($"3. Save Goal");
        Console.WriteLine($"4. Load Goal");
        Console.WriteLine($"5. Update Goal");//record event
        Console.WriteLine($"6. Display Player Info");
        Console.WriteLine($"7. Quit");
        
        if (!int.TryParse(Console.ReadLine(), out int choice))
        {
            Console.WriteLine("Invalid input. Try again");
        }

        if (choice == 1)
        {
            CreateGoal();
            Start();
        }
        else if (choice == 2)
        {
            ListNewTask();
            Start();
        }
        else if(choice == 3)
        {
            SaveGoal();
            Start();
        }
        else if(choice == 4)
        {
            LoadGoal();
            Start();
        }
        else if(choice == 5)
        {
            UpdateGoal();
            Start();
        }
        else if(choice == 6)
        {
            DisplayPlayerInfo();
        }
        else if(choice == 7)
        {
            running = false;
        }

        else
        {
            Console.WriteLine("Invalid action. Please choose from 1 to 7");
        }
        }
    }

    public void CreateGoal()
    {   
        Console.WriteLine("Select Goal Type: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Back to Main Menu");
        Console.WriteLine("5. Quit Application");
        int type = int.Parse(Console.ReadLine());

        if (type == 4) return;
        if (type == 5) Environment.Exit(0);

        Console.WriteLine("Enter the task name: ");
        string taskName = Console.ReadLine();
        Console.WriteLine("Enter task description: ");
        string taskdescription = Console.ReadLine();
        Console.WriteLine("Points to get: ");
        
        if (!double.TryParse(Console.ReadLine(), out double points))
        {
            Console.WriteLine("Invalid points. Enter numeric values: ");
        }
        Goal goal = null;
        if (type == 1)
        {
           goal = new SimpleGoal("Simple Goal", taskName, taskdescription, points);
            
        }
        else if(type == 2)
        {
            goal = new EternalGoal("Eternal Goal", taskName, taskdescription, points);
        }
        else if(type == 3)
        {
            Console.WriteLine("How many times will you do the task? ");
            int targetCount = int.Parse(Console.ReadLine());
            double bonus = 500;
            goal = new ChecklistGoal("Checklist Goal", taskName, taskdescription, points, targetCount, bonus);
        }
        else
        {
            Console.WriteLine("Invalid input. Try again.");
        }
        if (goal != null)
        {
            goals.Add(goal);
            Console.WriteLine($"Goal '{goal.GetDetailsString()}' created.");
        }
    }

    public void ListNewTask()
    {
        //add more tasks for chosen Goal Type from CreateGoal
        if (goals.Count == 0)
        {
            Console.WriteLine("No Goals Saved");
            return;
        }

        Console.WriteLine("Current Goals: ");
        for (int i = 0; i < goals.Count; i++)
        {
            var goal = goals[i];
            Console.WriteLine($"[{(goal.IsComplete() ? "✔" : " ")}] {i + 1}. {goal.GetDetailsString()}");
        }
    }
    public void SaveGoal()
    {
        //save string representation to a txt file as goal.txt
        string filePath = Path.Combine(Directory.GetCurrentDirectory(), "goal.txt");
        try
        {

        using StreamWriter writer = new StreamWriter(filePath);
        foreach (var goal in goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
            Console.WriteLine("Goals saved to goal.txt");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occured while saving the goals: {ex.Message}");
        }
    }
    public void LoadGoal()
    {
        //load goal.txt
        string filePath = Path.Combine(Directory.GetCurrentDirectory(), "goal.txt");
        if (!File.Exists("goal.txt"))
        {
            Console.WriteLine("No saved goals found.");
            return;
        }
        try
        {
        using StreamReader reader = new StreamReader(filePath);
        string line;
 
        while ((line = reader.ReadLine()) != null)
        {
            string[] parts = line.Split(',');
            if (parts.Length > 0)
            {
                string goalType = parts[0];
                if(goalType == "Simple Goal" && parts.Length == 5)
                {
                    string taskName = parts[1];
                    string taskdescription = parts [2];
                    double points = double.Parse(parts [3]);
                    bool isComplete = bool.Parse(parts[4]);
                    SimpleGoal goal = new SimpleGoal(goalType, taskName, taskdescription, points);
                    if (isComplete) goal.RecordEvent();
                    goals.Add(goal);
                }

                else if (goalType == "Eternal Goal" && parts.Length == 4)
                {
                    string taskName = parts[1];
                    string taskdescription = parts [2];
                    double points = double.Parse(parts [3]);
                    EternalGoal goal = new EternalGoal(goalType, taskName, taskdescription, points);
                    goals.Add(new EternalGoal(goalType, taskName,taskdescription, points));
                }
                else if(goalType == "Checklist Goal" && parts.Length == 7)
                {
                    string taskName = parts[1];
                    string taskdescription = parts [2];
                    double points = double.Parse(parts [3]);
                    int amountCompleted = int.Parse(parts[4]);
                    int targetCount =  int.Parse(parts[5]);
                    double bonus = double.Parse(parts[6]);
                    ChecklistGoal goal = new ChecklistGoal(goalType, taskName, taskdescription, points, targetCount, bonus);

                    for (int i = 0; i < amountCompleted; i++)goal.RecordEvent();

                    goals.Add(goal);
                }
            }
        }
        Console.WriteLine("Goals loaded from goal.txt");
        ListNewTask();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred while saving the goals: {ex.Message}");
    }
    }
    public void UpdateGoal()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals to update.");
            return;
        }
        Console.WriteLine("What task did you accomplish? ");
        ListNewTask();

        Console.WriteLine("Enter the task number you accomplished: ");

        if (!int.TryParse(Console.ReadLine(), out int taskIndex) || taskIndex < 1 || taskIndex >= goals.Count)
        {
            Console.WriteLine("Invalid task number.");

            return;
        }

        taskIndex -=1;

        var selectedGoal = goals[taskIndex];
        if (!selectedGoal.IsComplete())
        {
            selectedGoal.RecordEvent();
            totalScore += selectedGoal.GetPoints();
            Console.WriteLine($"Goal '{selectedGoal.GetDetailsString()}' has been updated.");
        }
        else
        {
            Console.WriteLine("Task is already completed.");
        }
        //updates a task that is completed
        //example
        //What task did you accomplish?
    }
    public void DisplayPlayerInfo()
    {
        //displays current accumulated points in the list
        //_score is the total points from all accomplished tasks
        Console.WriteLine($"Current Total Score: {totalScore}");
        ListNewTask();
    }
}