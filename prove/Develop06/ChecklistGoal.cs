using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _targetAmount;
    private double _bonus = 500;

    public ChecklistGoal(string goalType, string taskName, string taskdescription, double points, int targetAmount, double bonus) : base(goalType, taskName, taskdescription, points)
    {
        _amountCompleted = 0;
        _targetAmount = targetAmount;
        _bonus = bonus;
    }

    public int GetTargetAmount()
    {
        return _targetAmount;
    }
    public void SetTargetAmount(int targetAmount)
    {
        _targetAmount = targetAmount;
    }
    public double GetBonus()
    {
        return _bonus;
    }
    public void SetBonus(double bonus)
    {
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
       if (_amountCompleted < _targetAmount)
       {
        _amountCompleted++;
       }
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _targetAmount;
    }

    public override string GetDetailsString()
    {
       return $"{(_amountCompleted >= _targetAmount ? "[✔]" : "[ ]")} {_taskName} - {_taskdescription} [{_amountCompleted}/{_targetAmount}]";
    }

    public override string GetStringRepresentation()
    {
        return $"{_goalType} : {_taskName} : {_taskdescription}, {_points}, {_amountCompleted}/{_targetAmount}, {_bonus}";
    }
}