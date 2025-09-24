using System;
using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics;
class Program
{
    static void Main(string[] args)
    {
        //Ask the user for a series of numbers
        Console.Write("Enter a list of numbers, type 0 when finished.\n");

        List<int> numbers = new List<int>();
        int number = 1;
        int biggestNumber = 1;

        //Add the numbers to the list
        while (number != 0)
        {
            //Ask user to enter a number
            Console.Write("Enter a number: \n");
            string numberAdd = Console.ReadLine();
            int numbertoAdd = int.Parse(numberAdd);
            number = numbertoAdd;

            //Stop when they type 0
            if (number == 0)
            {
                Console.Write("Finished.\n");
            }
            else
            {
                numbers.Add(number);

                //Find the biggest number
                if (number > biggestNumber)
                {
                    biggestNumber = number;
                }
            }
        }


        //Compute and print the sum of the list
        int totalSum = 0;
        foreach (int whole in numbers)
        {
            totalSum += whole;
        }
        Console.Write($"The sum is {totalSum}.\n");

        //Compute and print the average of the list
        double sum = 0;
        int count = 0;
        double average = 0;
        foreach (int eachNumber in numbers)
        {
            sum += eachNumber;
            count++;
        }
        average = sum / count;
        Console.Write($"The average is {average}.\n");

        //Print the maximum of the list
        Console.Write($"The biggest number is {biggestNumber}");

    }
}