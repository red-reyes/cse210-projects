namespace Develop05
{
    public class MeditatingActivity : Activity
    {
        
        private List<string> instructions = new List<string>
        {
                "1. Sit upright comfortably.",
                "2. Close your eyes.",
                "3. Breathe deeply.",
                "4. Slowly scan your body.",
                "5. Be aware of any thoughts you are having.",
                "6. When your mind wanders, focus on your breath.",
                "7. Gently open your eyes when you are ready.",
        };

        private string music;

        public MeditatingActivity(string userName, int duration) : base(userName, "Meditation Activity", "This activity will help you find calmnes and reduce anxiety.", duration)
        {
        }

        public void DisplayInstructions()
        {
            Console.WriteLine("Choose & Enter your meditation music: ");
            string music=Console.ReadLine();

            foreach (var instruction in instructions)
            {
                Console.WriteLine(instruction);
                Thread.Sleep(3000);
            }
            Console.WriteLine($"Now playing {music}");
            Console.WriteLine("Let's start in...");
            DisplayCountdown(3);
        }
        public void RunMusic()
        {
        Console.WriteLine("Start meditating...");
        DisplaySpinner(_duration); // to play music within the user's chosen duration
        }
        public override void Run()
        {
            DisplayWelcomeMessage();
            DisplayInstructions();
            RunMusic();
            DisplayEndMessage();
        }
    }

}