using System;
using System.Diagnostics;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }
    public Fraction(int bigNumber)
    {
        //Get variable from main program and set it to the numerator
        _numerator = bigNumber;
        _denominator = 1;
    }
    //Make fractions out of the set numbers from the main program
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }
    //Set the fraction as a string so it works
    public string GetFractionString()
    {
        //Grab Numerator and Denominator from beginning and write out as text
        string _fraction = $"{_numerator}/{_denominator}";
        // When you use anything besides the class Fraction, you have to use the return
        return _fraction;
    }
    //Use double to get the decimal values like 0.553
    public double GetDecimalValue()
    {
        //This turns the numerator and denominator into point like 0.553 and divides them
        return (double)_numerator / (double)_denominator;   
    }
}