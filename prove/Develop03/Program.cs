using System;


class Program
{

    static void Main()
    {
         // Example verse I chose was Proverbs 3:5-6
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. " +
                      "In all thy ways acknowledge him, and he shall direct thy paths.";

        // Create new instance of the scripture class
        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            // Clear console and display the scripture
            Console.Clear();
            scripture.Display();

            Console.Write("Press Enter to hide words or type 'quit' to exit: ");
            string input = Console.ReadLine()?.Trim().ToLower();
            // Question mark means it could or could not have a value


            if (input == "quit")
                break;

            // This is where you choose to hide and how many you want to hide per enter
            scripture.HideRandomWords(3);

            // Check to see if completely hidden
            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                scripture.Display();
                Console.WriteLine("All words are hidden! Program quitting..........");
                break;
            }

        }

    }
}