using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        while (playAgain == "yes")

        {
            //generate random numbers between 1 and 100 for the magic number
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            //initialize guess and count guesses
            int guess = -1;
            int guessCount = 0;

            Console.WriteLine("Hello, please try this 'Guess My Number' game.");
            Console.WriteLine("Guess the magic number between 1 and 100.");

            //loop until correct
            while (guess != magicNumber)
            {
                Console.Write("What is your guess?");

                string input = Console.ReadLine();
                bool isNumber = int.TryParse(input, out guess);

                //proceed if the number is valid
                if (isNumber)
                {
                    //guess counter
                    guessCount++;

                    //if guess is lower, higher or correct:
                    if (guess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else                    
                    {
                        Console.WriteLine($"You guessed it right! Amazing! The magic number was {magicNumber}.");
                        Console.WriteLine($"It took you {guessCount} gueeses.");
                    }
                }
                else
                {
                    Console.WriteLine("Oops! Invalid input. Please enter a valid number.");
                }
            }
            //to play again or not
            Console.Write("Do you want to play again? (Yes/No)");
            playAgain = Console.ReadLine().ToLower();
        }
        //end game
        Console.WriteLine("Thank you for playing!");
    }
}