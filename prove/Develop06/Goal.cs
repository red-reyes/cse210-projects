using System.Net.NetworkInformation;

public abstract class Goal
{
    protected string _goalType;
    protected string _taskName;
    protected string _taskdescription;
    protected double _points;
    
    //constructor
    public Goal(string goalType, string taskName, string taskdescription, double points)
    {
        _goalType = goalType;
        _taskName = taskName;
        _taskdescription = taskdescription;
        _points = points;
    }

     public string GetGoalType()
    {
        return _goalType;
    }

    public void SetGoalType(string goalType)
    {
        _goalType = goalType;
    }

    public string GetTaskName()
    {
        return _taskName;
    }
    public void SetTaskName(string taskName)
    {
        _taskName = taskName;
    }
    public string GetTaskdescription()
    {
        return _taskdescription;
    }
    public void SetTaskdescription(string taskdescription)
    {
        _taskdescription = taskdescription;
    }
    public double GetPoints()
    {
        return _points;
    }
    public void SetPoints(double points)
    {
        _points = points;
    }
    
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        return $"{_goalType} : {_taskName} : {_taskdescription} : {_points}";
    }
    public abstract string GetStringRepresentation();//This method should provide all of the details of a goal in a way that is easy to save to a file, and then load later. 
    /*
    For example

    Current total points: 50 (current total points from completed tasks accumulates as list updates)
    [✔] 1. Wash Clothes.
    [ ] 2. Go to temple. [1/3] //if user sets 30 points, it points to get for each count is target points/taskCount such as 30/3 = 10 points each count until [3/3], user gets bonus of 500 when [3/3] or the targetCount is complete
    [ ] 3. Drink water. [3/8]
    [ ] 4. Read the sciptures.

    GetDetailsString - This method should return the details of a goal that could be shown in a list. It should include the checkbox, the short name, and description. Then in the case of the ChecklistGoal class, it should be overridden to shown the number of times the goal has been accomplished so far.
    
    GetStringRepresentation - This method should provide all of the details of a goal in a way that is easy to save to a file, and then load later.
    */
}