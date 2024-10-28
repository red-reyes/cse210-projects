using System;

public class EternalGoal : Goal
{
    public EternalGoal (string goalType, string taskName, string taskdescription, double points) : base (goalType, taskName, taskdescription, points)
    {
        
    }

    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
         return $" {_taskName} : {_taskdescription} : {_points}";
    }
    public override string GetStringRepresentation()
    {
        return $"{_goalType},{_taskName} : {_taskdescription}, {_points}";
    }
}