//change done: added Stretching Activity
namespace Develop05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string userName = Console.ReadLine();

            bool running = true;

            while (running)
            {
                Console.WriteLine("Choose an activity:");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Stretching Activity");
                Console.WriteLine("5. Meditating Activity");
                Console.WriteLine("6. Exit");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 6) running = false;
                else
                {
                    Console.WriteLine("Enter duration in seconds:");
                    int duration = int.Parse(Console.ReadLine());

                    Activity task = choice switch 
                    {
                        1 => new BreathingActivity(userName, duration),
                        2 => new ReflectionActivity(userName, duration),
                        3 => new ListingActivity(userName, duration),
                        4 => new StretchingActivity(userName, duration),
                        5 => new MeditatingActivity(userName, duration),
                        _ => null
                    };
                    task?.Run();//'?'calls method/accessing property of what's inside the bracket
                }
            }
        }
    }
}