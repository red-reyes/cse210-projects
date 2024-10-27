using System;
using System.Runtime.CompilerServices;

public class GoalManager
{
    private List<Goal> _goals;
    private double _totalPoints;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalPoints = 0;
    }

    public void Start()
    {

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current points: {_totalPoints} points");
    }

    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
        
        }
    }

    public void RecordEvent()
    {

    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {

    }

}