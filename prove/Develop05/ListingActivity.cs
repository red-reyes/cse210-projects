using System.Collections.Generic;

namespace Develop05
{
    public class ListingActivity : Activity
    {

        public ListingActivity(string userName, int duration)
            : base(userName, "Listing Activity", "This activity will help you reflect on the good things in your life by listing as many things as you can.", duration)
        {
        }
                private List<string> _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "What are moments when you felt peace this month?"
        };
        
        public override void Run()
        {
            DisplayWelcomeMessage();
            Random random = new Random();
            Console.WriteLine(_prompts[random.Next(_prompts.Count)]);

            List<string> userEntries = new List<string>();
            Console.WriteLine("Start listing items (press Enter after each one, type 'end' to finish early):");

            for (int i = 0; i < _duration / 10; i++)
            {
                string entry = Console.ReadLine();
                if (entry.ToLower() == "end") break;
                userEntries.Add(entry);
            }

            Console.WriteLine($"You listed {userEntries.Count} items.");
            DisplayEndMessage();
            DisplaySpinner(5);
        }
    }
}
