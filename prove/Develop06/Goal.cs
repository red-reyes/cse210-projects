public abstract class Goal
{
    protected string _taskName;
    protected string _description;
    protected int _points;
    protected bool _isCompleted;

    public Goal(string taskName, string description, int points)
    {
        _taskName = taskName;
        _description = description;
        _points = points;
        _isCompleted = false; 
    }

    public string GetTaskName()
    {
        return _taskName;
    }

    public abstract string DetailsString();
    public abstract string SaveString();
    public abstract int RecordEvent(Random random);

     public static Goal LoadGoal(string[] parts)
    {
        string goalType = parts[0];
        string name = parts[1];
        string description = parts[2];
        int points = int.Parse(parts[3]);

        // Check the type of goal to instantiate the correct subclass
        switch (goalType)
        {
            case "SimpleGoal":
                return new SimpleGoal(name, description, points);
            case "EternalGoal":
                return new EternalGoal(name, description, points);
            case "ChecklistGoal":
                int targetCount = int.Parse(parts[4]);
                int completedCount = int.Parse(parts[5]);
                return new ChecklistGoal(name, description, points, targetCount, completedCount);
            default:
                throw new Exception("Unknown goal type");
        }
    }
}