public class Cycling : Activity
{
    public Cycling(double distance, DateTime startTime, DateTime endTime) : base(distance, startTime, endTime) { }

    public override string GetActivityType() => "Cycling";
}