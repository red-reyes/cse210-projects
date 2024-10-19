namespace Develop05
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity(string userName, int duration)
            : base(userName, "Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly.", duration)
        {
        }

        public override void Run()
        {
            DisplayWelcomeMessage();
            for (int i = 0; i < _duration / 6; i++)
            {
                Console.WriteLine("Breathe in...");
                DisplayCountdown(3);
                Console.WriteLine("Breathe out...");
                DisplayCountdown(3);
            }
            DisplayEndMessage();
        }
    }
}