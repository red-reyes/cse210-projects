using System;

class Program
{
    static void Main(string[] args)
    {
        //create scripture verses
        Reference reference1 = new Reference ("Psalm", 37, 3,9);
        Scripture scripture1 = new Scripture (reference1,  "3. Trust in the Lord, and do good; so shalt thou dwell in the land, and verily thou shalt be fed.\n" +
            "4. Delight thyself also in the Lord; and he shall give thee the desires of thine heart.\n" +
            "5. Commit thy way unto the Lord; trust also in him; and he shall bring it to pass.\n" +
            "6. And he shall bring forth thy righteousness as the light, and thy judgment as the noonday.\n" +
            "7. Rest in the Lord, and wait patiently for him: fret not thyself because of him who prospereth in his way, because of the man who bringeth wicked devices to pass.\n" +
            "8. Cease from anger, and forsake wrath: fret not thyself in any wise to do evil.\n" +
            "9. For evildoers shall be cut off: but those that wait upon the Lord, they shall inherit the earth.");
        
        Reference reference2 = new Reference("Doctrine and Covenants", 101, 15);
        Scripture scripture2 = new Scripture(reference2,"15. And all they who have given their lives for my name shall be crowned.");

        Reference reference3 = new Reference("Isaiah", 60, 1,3);
        Scripture scripture3 = new Scripture (reference3,"1. Arise, shine; for thy light is come, and the glory of the Lord is risen upon thee.\n" +
            "2. For, behold, the darkness shall cover the earth, and gross darkness the people: but the Lord shall arise upon thee, and his glory shall be seen upon thee.\n" +
            "3. And the Gentiles shall come to thy light, and kings to the brightness of thy rising.");

    //Store scriptures in an array or list to choose from
    Scripture[] scriptures = {scripture1, scripture2, scripture3};

    //random select a scripture
    Random rand = new Random();
    Scripture selectedScripture = scriptures[rand.Next(scriptures.Length)];

    //loop until the entire scripture is hidden
    while (!selectedScripture.IsCompletelyHidden())
    {
        //clear the console
        Console.Clear();

        //display the scripture
        Console.WriteLine(selectedScripture.GetDisplayText());

        //prompt enter or quit
        Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit.");
        string userInput = Console.ReadLine();

        if (userInput.ToLower() == "quit")
        {
            break;
        }
        //hide random words in the scriptures
        selectedScripture.HideRandomWords(3); //hide 3 words each time
    }

    //final message
    if (selectedScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine("All words are hidden.");
        }
    }
}