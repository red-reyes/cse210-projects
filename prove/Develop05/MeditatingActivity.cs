using System.Security.Cryptography.X509Certificates;

namespace Develop05
{
    public class MeditatingActivity : Activity
    {
   //make a list of instructions
        private List<string>instructions;
        public MeditatingActivity(string userName, int duration)
        : base(userName, "Meditating Activity", "This activity will help you relax your mind along with a good breathing exercise.", duration)
        {
            instructions = new List<string>
            {
                "1. Sit upright comfortably.",
                "2. Close your eyes.",
                "3. Breathe deeply.",
                "4. Slowly scan your body.",
                "5. Be aware of any thoughts you are having.",
                "6. When your mind wanders, focus on your breath.",
                "7. Gently open your eyes when you are ready.",
            };
        }

        public void StartMeditate(List<string>instructions)
        {
            foreach (var instruction in instructions)
            {
                Console.Write(instruction);
                DisplayCountdown(10);
            }
        }
        public override void Run()
        {
            Console.WriteLine($"{_userName} please Enter your music title: ");
            string music = Console.ReadLine();
            DisplayWelcomeMessage();
            Console.WriteLine($"Now start playing {music}");
            Console.Write(instructions);
            DisplayEndMessage();
        }
    }
}