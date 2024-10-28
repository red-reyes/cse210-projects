using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _targetCount;
    private double _bonus = 500;

    public ChecklistGoal(string goalType, string taskName, string taskdescription, double points, int targetCount, double bonus) : base(goalType, taskName, taskdescription, points)
    {
        _amountCompleted = 0;
        _targetCount = targetCount;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
       if (_amountCompleted < _targetCount)
       {
        _amountCompleted++;
       }
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _targetCount;
    }

    public override string GetDetailsString()
    {
       return $"{base.GetDetailsString()} [{_amountCompleted}/{_targetCount}]";
    }

    public override string GetStringRepresentation()
    {
        return $"{_goalType} : {_taskName} : {_taskdescription}, {_points}, {_amountCompleted}/{_targetCount}, {_bonus}";
    }
}