

using System.Collections.Generic;

namespace Develop05
{
    public class StretchingActivity : Activity
    {
        private List<string> _fullBody;
        private List<string> _hip;
        private List<string> _running;

        public StretchingActivity (string userName, int duration) : base(userName, "Stretching Activity", "This activity will help you stretch different parts of your body and release tension and stress.", duration)
        {
            _fullBody = new List<string>
            {
                 "1. Neck roll: Stand up straight with the feet shoulder-width apart and the arms loose...",
            "2. Shoulder roll: Stand up straight with the arms loose...",
            "3. Behind-head tricep stretch: Extend the left arm straight upward...",
            "4. Standing hip rotation: Stand with the feet shoulder-width apart...",
            "5. Standing hamstring stretch: Stand up straight. Keeping the right foot flat on the ground...",
            "6. Quadriceps stretch: Stand upright. For balance, hold onto a solid structure...",
            "7. Ankle roll: Stand with the left foot flat on the ground...",
            "8. Child's Pose: Kneel with the toes pointed back..."
            };

            _hip = new List<string>
            {
                "1. Knee-to-chest stretch: Lie flat on the back with the legs straight...",
            "2. Hip abduction: Lie down on the left side of the body...",
            "3. Standing iliotibial (IT) band stretch: Begin by standing upright..."
            };

            _running = new List<string>
            {
            "1. Supine hamstring stretch: Lie flat on the floor with both knees bent...",
            "2. Quadriceps stretch: See the full body routine...",
            "3. Side lunge: Stand with the feet hip-width wide apart...",
            "4. Cobra stretch: Lie on the front with the tops of the feet flat on the floor..."
            };
        }

        public void RunExercise(List<string>exercises)
        {
            int totalDuration = _duration;
            int exerciseDuration = 10; // Each exercise runs for 10 seconds
            int exerciseCount = totalDuration / exerciseDuration; 

           for (int i = 0; i < exerciseCount; i++)
           {
                Console.WriteLine(exercises[i]);
                DisplayCountdown(exerciseDuration);
                
           }
           Console.WriteLine("Activity Complete!");
           DisplayEndMessage();
        }
        public override void Run()
        {
            DisplayWelcomeMessage();
            Console.WriteLine("Choose your target: ");
            Console.WriteLine("1. Full Body");
            Console.WriteLine("2. Hip");
            Console.WriteLine("3. Stretches Before Running");
            Console.WriteLine("4. Quit");
            int target = int.Parse(Console.ReadLine());
            {
                List<string> exercises = target switch
                {
                    1 => _fullBody,
                    2 => _hip,
                    3 => _running,
                    _ => new List<string>()
                };

                if (exercises.Count > 0)
                {
                    RunExercise(exercises);
                }
                else if (target == 4 )
                {
                    Console.WriteLine("Quitting activity...");
                }
                else
                {
                    Console.WriteLine("Invalid Choice.");
                    DisplaySpinner(3);
                }
            }
            
        }

    }
}