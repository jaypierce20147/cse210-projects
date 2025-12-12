using System;

public class Activity
{
    private string _date;
    private int _lengthInMinutes;

    public Activity(string date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public int GetMinutes()
    {
        return _lengthInMinutes;
    }

    public virtual float GetDistance()
    {
        return 0;
    }
    
    public virtual float GetSpeed()
    {
        float distance = GetDistance();
        return (distance / _lengthInMinutes) * 60;
    }

    public virtual float GetPace()
    {
        float distance = GetDistance();
        return _lengthInMinutes / distance;
    }

    public string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_lengthInMinutes} min)" +
               $"Distance: {GetDistance():0.0} miles, " +
               $"Speed: {GetSpeed():0.0} mph, " +
               $"Pace: {GetPace():0.0} min per mile";
    }
}