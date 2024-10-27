public class EternalGoal : Goal
{
    public EternalGoal(string taskName, string description, int points) : base(taskName, description, points) 
    {
        
    }

    public override string DetailsString()
    {
        return $"[ ] Eternal Goal - {_taskName}: {_description} (Random points)";
    }

    public override string SaveString()
    {
        return $"EternalGoal|{_taskName}|{_description}|{_points}";
    }

    public override int RecordEvent(Random random)
    {
        return random.Next(1, 11) * 50; // random points between 50 and 500
    }
}