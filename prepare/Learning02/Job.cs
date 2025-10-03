//responsibilities: keeps track of the company, job title, and end year.
using System;

public class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    public void DisplayDetails() { }
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
//Behaviors: displays the information in job title (company), start-endyear, format.
