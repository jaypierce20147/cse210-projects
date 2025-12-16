using System;

public class Activity
{
    private string _date;
    private int _lengthInMinutes;

    // Store the date the the length
    public Activity(string date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    // Get the minutes
    public int GetMinutes()
    {
        return _lengthInMinutes;
    }
    
    // Get the distance
    public virtual float GetDistance()
    {
        return 0;
    }
    
    // Get the speed
    public virtual float GetSpeed()
    {
        float distance = GetDistance();
        return (distance / _lengthInMinutes) * 60;
    }

    // Get the pace
    public virtual float GetPace()
    {
        float distance = GetDistance();
        return _lengthInMinutes / distance;
    }

    // Get teh summary
    public string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_lengthInMinutes} min)" +
               $"Distance: {GetDistance():0.0} miles, " +
               $"Speed: {GetSpeed():0.0} mph, " +
               $"Pace: {GetPace():0.0} min per mile";
    }
}