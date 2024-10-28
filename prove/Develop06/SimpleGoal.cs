using System;
public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal (string goalType, string taskName, string taskdescription, double points) : base (goalType, taskName, taskdescription, points)
    {

    }

    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override string GetDetailsString()
    {
         return $" {_taskName} : {_taskdescription} : {_points}";
    }
    public override string GetStringRepresentation()
    {
        return $"{_goalType},{_taskName} : {_taskdescription}, {_points}, {_isComplete}";
    }
}