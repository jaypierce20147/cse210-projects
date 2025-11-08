using System;

public class Breathing : ActivityBase
{
    public Breathing()
        : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }
    // Override Run method
    public override void Run()
    {
        StartActivity(); // Calls the base class method

        int inhaleTime = 3;
        int exhaleTime = 3;

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            
            Console.Write("Breathe in... ");
            Countdown(inhaleTime); // base class method
            
            Console.Write("Breathe out... ");
            Countdown(exhaleTime); // base classs method

            Console.WriteLine();
            
            ShowSpinner(1); // rest before next cycle
        }

        EndActivity(); // calls the base class method

    }
    

}