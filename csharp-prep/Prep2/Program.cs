using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        // Ask the user for their percentage grade and convert to int
        Console.Write("What is your grade percentage? ");
        string gradePer = Console.ReadLine();
        int number = int.Parse(gradePer);
        string letter = "";


        //Re assign the letter to the correct number
        if (number >= 90)
        {
            letter = "A";

        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else if (number < 60)
        {
            letter = "F";
        }

        //Print the letter grade
        Console.WriteLine($"Your grade is {letter}");
        if (number >= 70)
        {
            Console.WriteLine("You pass!");
        }
        else
        {
            Console.WriteLine("You shall not pass!!!!");
        }

    }
}