using System;

public class Running : Activity
{
    private float _distance;

    // Store the distance
    public Running(string date, int minutes, float distance)
        : base(date, minutes)
    {
        _distance = distance;
    }

    // Return the distance
    public override float GetDistance()
    {
        return _distance;
    }

}