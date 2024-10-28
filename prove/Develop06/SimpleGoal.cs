using System;
public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal (string goalType, string taskName, string taskdescription, double points) : base (goalType, taskName, taskdescription, points)
    {
        _isComplete = false;
    }


    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"'{_taskName}' completed! You've earned {_points} points.");
        //this method should work with "Update Goal" in the menu
        /*
        it should update the list with a check if task is complete
        Current Score: 0
        */
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
         return $"{(_isComplete ? "[✔]" : "[ ]")} {_taskName} - {_taskdescription}";
    }
    public override string GetStringRepresentation()
    {
        return $"{_goalType},{_taskName} : {_taskdescription}, {_points}, {_isComplete}";
    }
}