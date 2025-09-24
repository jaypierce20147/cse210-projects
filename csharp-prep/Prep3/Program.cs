using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        //Generate random number
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 5);
        int guess = 0;
        int guesses = 0;

        //Ask user for a guess
        while (guess != number)
        {

            Console.Write("What is your guess? ");

            //Read the number inputted from the user and turn it into a number
            string response = Console.ReadLine();
            int userGuess = int.Parse(response);
            guess = userGuess;

            if (userGuess == number)
            {
                Console.Write("You guessed it!\n");

            }
            else if (userGuess > number)
            {
                Console.Write("Lower\n");
            }
            else
            {
                Console.Write("Higher\n");
            }

            //Keep track of guesses and display when over
            guesses = guesses + 1;


        }

        Console.Write($"It took {guesses} guesses.");
        
    }
}