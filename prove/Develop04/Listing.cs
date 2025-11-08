using System;

public class Listing : ActivityBase
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strength of your?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };



    public Listing() : base(
        "Listing",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }


    public override void Run()
    {
        StartActivity();

        // pick a random prompt
        Random rnd = new Random();
        string prompt = _prompts[rnd.Next(_prompts.Count)];

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:\n");
        Console.WriteLine($"---");
        Console.WriteLine(prompt);
        Console.WriteLine($"---\n");

        // Add a timer for the user to wait to enter items
        Console.Write("You may begin in: ");
        Countdown(5);
        Console.WriteLine("\nStart listing items! (Press Enter after each item)\n");

        // Add a timer for input
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string? item = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(item))
            {
                count++;
            }
        }

        Console.WriteLine($"\nYou listed {count} items!");

        EndActivity();
    }
    
    

}