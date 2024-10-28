using System.Net.NetworkInformation;

public abstract class Goal
{
    protected string _goalType;
    protected string _taskName;
    protected string _taskdescription;
    protected double _points;
    protected bool isComplete;
    
    //constructor
    public Goal(string goalType, string taskName, string taskdescription, double points)
    {
        _goalType = goalType;
        _taskName = taskName;
        _taskdescription = taskdescription;
        _points = points;
        isComplete = false;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        return $"{_goalType} : {_taskName} : {_taskdescription} : {_points}";
    }
    public abstract string GetStringRepresentation();//This method should provide all of the details of a goal in a way that is easy to save to a file, and then load later. 
    public double GetPoints()
    {
        return _points;
    }
}