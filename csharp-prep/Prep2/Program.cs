using System;

class Program
{
    static void Main(string[] args)
    {
        //enter grade percentage
        Console.Write("Grade Percentage: ");
        int grade = int.Parse(Console.ReadLine());

        //letter grade and sign variables
        string letter = "";
        string sign = "";

        // letter grade based on percentage/ condition statements:
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else{
            letter = "F";
        }

        //if grade is not an "F"
        if (letter != "F")
        {
            int lastDigit = grade % 10;

            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }

        // special cases (+/-)
        if (letter == "A" && sign == "+")
        {
            sign = "";
        }
        if (letter == "F" && sign == "F")
        {
            sign = "";
        }
        
        //Display letter grade with the sign
        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        //if user passed
        if (grade >= 70)
        {
            Console.WriteLine("Great work! You passed.");
        }
        else{
            Console.WriteLine("Oh, my goodness. Did I really fail?");
        }
    }
}