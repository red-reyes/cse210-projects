using System;

class Program
{
    static void Main(string[] args)
    {
        //first name
        Console.Write("What is your first name?");
        string firstName = Console.ReadLine();
        //last name
        Console.Write("What is your last name?");
        string lastName = Console.ReadLine();
        //display full name
        Console.WriteLine($"Your name is {firstName} {lastName}.");
    }
}