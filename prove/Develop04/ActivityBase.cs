using System;
using System.Threading;
public abstract class ActivityBase
{
    //Shared behaviors are the timer and spinner
    // finishing message, 
    private string _name;
    private string _description;
    protected int _duration;
    public ActivityBase(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity!\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your session? ");

        // Read the duration from the user input
        string? input = Console.ReadLine();
        while (!int.TryParse(input, out _duration) || _duration <= 0)
        {
            Console.Write("Please enter a valid positive number: ");
            input = Console.ReadLine();
        }

        Console.WriteLine("\nPrepare to begin...");
        ShowSpinner(3);


    }

    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(250); // Wait 1/4 second
            Console.Write("\b \b"); // Erase the spinner character
            i = (i + 1) % spinner.Length; // Cycle through spinner symbols
        }

    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000); // Wait 1 second
            Console.Write("\b \b"); // Erase the number
        }
    }

    public void EndActivity()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(2);
        Console.WriteLine($"\nYou have completed this activity for {_duration} seconds.");
        ShowSpinner(3);
    }

    public abstract void Run();

}