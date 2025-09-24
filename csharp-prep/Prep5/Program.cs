using System;
using System.Xml.XPath;

class Program
{


    static void TestPassByReferenceUsingOut(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        string yearBirth = Console.ReadLine();
        int birth = int.Parse(yearBirth);
        birthYear = birth;
    }
    static void SquareNumber(ref int number)
    {
        number = number * number;
        

        
    }
    static void Result(ref string name, int number, int birthYear)
    {

        Console.Write($"{name}, the square of your number is {number}.\n");
        birthYear = 2025 - birthYear;
        Console.Write($"{name}, you will turn {birthYear} this year.");
        

        
    }

    static void Main(string[] args)
    {
        //Say welcome to the program
        Console.Write("Welcome to the Program!\n");

        //Ask for the users name
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        //Ask for the users favorite number
        Console.Write("Please enter your favorite number: ");
        string favoriteNumber = Console.ReadLine();
        int number = int.Parse(favoriteNumber);


        //Ask the user for when they were born accepts out integer parameter
        //out parameter is set to their birth year
        int birthYear;
        TestPassByReferenceUsingOut(out birthYear);

        //Square a number using an inter as a parameter
        SquareNumber(ref number);

        //Accepts the name the squared number, and the users birth year
        Result(ref name, number, birthYear);

    }
}