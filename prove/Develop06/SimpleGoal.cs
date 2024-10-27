public class SimpleGoal : Goal
{
    public SimpleGoal(string taskName, string description, int points) : base(taskName, description, points) { }

    public override string DetailsString()
    {
        return $"{(_isCompleted ? "[✔]" : "[ ]")} Simple Goal - {_taskName}: {_description} ({_points} points)";
    }

    public override string SaveString()
    {
        return $"SimpleGoal|{_taskName}|{_description}|{_points}";
    }

    public override int RecordEvent(Random random)
    {
        if (!_isCompleted)
        {
            _isCompleted = true;
            return _points;
        }
        return 0;
    }
}