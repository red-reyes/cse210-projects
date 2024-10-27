using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

public class Program
{

    public static void Main()
    {
        Console.Write("Enter your username: ");
        string username = Console.ReadLine();
        Console.WriteLine($"Hello {username}, Welcome to Eternal Quest!");

        MainMenu menu = new MainMenu();
        menu.Run();
    }
}