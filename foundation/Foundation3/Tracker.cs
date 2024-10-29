public class Tracker
{
    private const string FilePath = "tracker.txt";
    private List<string> activities = new List<string>();

     public void DisplayTimer(int seconds)
        {
            for (int i = seconds; i <= 0; i++)
            {
                Console.Write($"{i} ");
                Thread.Sleep(1000);
                Console.Write("\b\b");
            }
            Console.WriteLine(" ");
        }

    public void SaveActivity(Activity activity)
    {
        DisplayTimer(3);
        string entry = $"Date Today: {DateTime.Now.ToShortDateString()}, " +
                       $"Activity: {activity.GetActivityType()}, " +
                       $"Distance in meters: {activity.GetDistance()}, " +
                       $"Duration in minutes: {activity.GetDurationInMinutes()}, " +
                       $"Start Time: {activity.StartTime.ToString("HH:mm:ss")}, " +
                       $"End Time: {activity.EndTime.ToString("HH:mm:ss")}, " +
                       $"Speed: {activity.GetSpeed()} km/h";

        if (activity is Swimming swimming)
        {
            entry += $", Laps: {swimming.GetLaps()}";
        }

        activities.Add(entry);
        File.AppendAllText(FilePath, entry + Environment.NewLine);
        DisplayTimer(3);
        Console.WriteLine("Activity saved.");
    }

    public void LoadActivities()
    {
        DisplayTimer(3);
        if (File.Exists(FilePath))
        {
            string[] lines = File.ReadAllLines(FilePath);
            Console.WriteLine("\nLoaded Activities:");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("No activity records found.");
        }
    }
}