using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        //Get the name of the person and read it to the variable

        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();

        //Print the name of the person back to them
        Console.WriteLine($"Your name is  {last_name}, {first_name} {last_name}.");



    }
}