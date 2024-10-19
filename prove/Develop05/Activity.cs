using System;
using System.Threading;

namespace Develop05
{
    public abstract class Activity
    {
        protected string _userName;
        protected string _activityName;
        protected string _description;
        protected int _duration;

        public Activity(string userName, string activityName, string description, int duration)
        {
            _userName = userName;
            _activityName = activityName;
            _description = description;
            _duration = duration;
        }

        public void DisplayWelcomeMessage()
        {
            Console.WriteLine($"Hello, {_userName}! Welcome to the {_activityName}.");
            Console.WriteLine($"{_description}");
            Console.WriteLine("Get ready...");
            DisplayCountdown(3);
        }

        public void DisplayEndMessage()
        {
            Console.WriteLine($"Congratulations! You completed the {_activityName} for {_duration} seconds. Great job!");
            DisplaySpinner(3);
        }

        public void DisplaySpinner(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write("|");
                Thread.Sleep(500);
                Console.Write("\b \b");
                Console.Write("/");
                Thread.Sleep(500);
                Console.Write("\b \b");
                Console.Write("—");
                 Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }

        public void DisplayCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"{i} ");
                Thread.Sleep(1000);
                Console.Write("\b\b");
            }
            Console.WriteLine();
        }

        public abstract void Run();
    }
}