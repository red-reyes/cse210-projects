public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _completedCount;

    public ChecklistGoal(string taskName, string description, int points, int targetCount, int completedCount) : base(taskName, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _completedCount = completedCount;
    }

    public override string DetailsString()
    {
        return $"[ ] Checklist Goal - {_taskName}: {_description} ({_points} points, Completed {_currentCount}/{_targetCount} times)";
    }

    public override string SaveString()
    {
        return $"ChecklistGoal|{_taskName}|{_description}|{_points}|{_targetCount} |{_completedCount}";
    }

    public override int RecordEvent(Random random)
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            if (_currentCount == _targetCount)
            {
                _isCompleted = true;
                return _points + random.Next(1, 6) * 200; // add bonus points
            }
            return _points / _targetCount;
        }
        return 0;
    }
}