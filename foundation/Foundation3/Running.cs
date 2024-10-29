public class Running : Activity
{
    public Running(double distance, DateTime startTime, DateTime endTime) : base(distance, startTime, endTime) { }

    public override string GetActivityType() => "Running";
}