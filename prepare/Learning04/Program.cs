using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Jayden Pierce", "Fortnite");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Joyden Pierce", "Fractions", "4 and 5", "50-70");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());

    }

}