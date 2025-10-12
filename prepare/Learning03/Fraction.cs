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
        _numerator = bigNumber;
        _denominator = 1;
    }
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }
    public string GetFractionString()
    {
        string _fraction = $"{_numerator}/{_denominator}";
        return _fraction;
    }
    public double GetDecimalValue()
    {
        
        return (double)_numerator / (double)_denominator;   
    }
}