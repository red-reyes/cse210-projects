public class Swimming : Activity
{
    public int PoolSize { get; private set; }

    public Swimming(double distance, DateTime startTime, DateTime endTime) : base(distance, startTime, endTime) { }

    public void SetPoolSize()
    {
        Console.WriteLine("What pool area will you swim?");
        Console.WriteLine("1. Pool 1 (25 meters)");
        Console.WriteLine("2. Pool 2 (50 meters)");
        Console.WriteLine("3. Pool 3 (100 meters)");
        Console.Write("Choose pool area: ");
        string poolChoice = Console.ReadLine();

        PoolSize = poolChoice switch
        {
            "1" => 25,
            "2" => 50,
            "3" => 100,
            _ => 0
        };

        if (PoolSize == 0)
        {
            Console.WriteLine("Invalid pool choice. Returning to Main Menu.");
        }
        else
        {
            Console.WriteLine($"You chose Pool {poolChoice} which is {PoolSize} meters.");
        }
    }

    public override string GetActivityType() => "Swimming";

    public double GetLaps()
    {
        return _distance / PoolSize;
    }
}