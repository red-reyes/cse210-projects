using System.Collections.Generic;

namespace Develop05
{
    public class ReflectionActivity : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private List<string> _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you feel when it was complete?",
            "What did you learn about yourself through this experience?"
        };

        public ReflectionActivity(string userName, int duration)
            : base(userName, "Reflection Activity", "This activity will help you reflect on times of strength and resilience.", duration)
        {
        }

        public override void Run()
        {
            DisplayWelcomeMessage();
            Random random = new Random();
            Console.WriteLine(_prompts[random.Next(_prompts.Count)]);

            for (int i = 0; i < _duration / 5; i++)
            {
                Console.WriteLine(_questions[random.Next(_questions.Count)]);
                DisplaySpinner(5);
            }
            DisplayEndMessage();
        }
    }
}