using System;

public class Cycling : Activity
{
    private float _speed;

    // Store the speed
    public Cycling(string date, int minutes, float speed)
          : base(date, minutes)
    {
        _speed = speed;
    }

    // Calculate the distance
    public override float GetDistance()
    {
        return (_speed * GetMinutes()) / 60f;
    }
    
    // Return the speed
    public override float GetSpeed()
    {
        return _speed;
    }
}