public abstract class Activity
{
    protected double _distance;
    protected DateTime _startTime;
    protected DateTime _endTime;

    public Activity(double distance, DateTime startTime, DateTime endTime)
    {
        _distance = distance;
        _startTime = startTime;
        _endTime = endTime;
    }

    public void Start()
    {
        Console.WriteLine("Choose Action:");
        Console.WriteLine("1. Start Now");
        Console.WriteLine("2. Return to Main Menu");
        string action = Console.ReadLine();

        if (action == "1")
        {
            _startTime = DateTime.Now;
            Console.WriteLine("Timer started at: " + _startTime.ToString("HH:mm:ss"));
            Console.WriteLine("Enter '9' to stop the timer.");

            string input;
            while ((input = Console.ReadLine()) != "9")
            {
                Console.WriteLine("Invalid input. Enter '9' to stop the timer.");
            }

            _endTime = DateTime.Now;
            Console.WriteLine("Timer stopped at: " + _endTime.ToString("HH:mm:ss"));
        }
        else
        {   
            Console.WriteLine("Returning to Main Menu.");
        }
    }

    public double GetDurationInMinutes()
    {
        return Math.Round((_endTime - _startTime).TotalMinutes, 2);
    }

    public double GetSpeed()
    {
        return Math.Round((_distance / 1000) / (GetDurationInMinutes() / 60), 2); // Rounded to 2 decimals
    }

    public void SetDistance(double distance)
    {
        _distance = distance;
    }

    public double GetDistance() => _distance;
    public abstract string GetActivityType();

    // Provide access to start and end times
    public DateTime StartTime => _startTime;
    public DateTime EndTime => _endTime;
}