using System;

class Program
{
       static void Main(string[] args)
       {
              Console.WriteLine("Enter user name: ");
              string username = Console.ReadLine();
              Console.WriteLine($"Hello {username}, welcome to Eternal Quest!\nSelect a number to perform action: ");
              GoalManager goalManager = new GoalManager();
              goalManager.Start();
       }
}