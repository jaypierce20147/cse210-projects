using System;
using System.Collections.Generic;

public class Reflection : ActivityBase
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    // Constructor
    public Reflection() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    private readonly List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    // Required override
    public override void Run()
    {
        StartActivity();
        Random rnd = new Random(); // create random generator

        string prompt = _prompts[rnd.Next(_prompts.Count)]; // pick random
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"---\n{prompt}\n---\n");
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        Countdown(5); // uses Activity Base
        Console.WriteLine();

        // Keep more questions goind while the duration is on
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string q = _questions[rnd.Next(_questions.Count)];
            Console.WriteLine($"> {q}");
            ShowSpinner(6);
            Console.WriteLine();
        }

        EndActivity();
    }

}