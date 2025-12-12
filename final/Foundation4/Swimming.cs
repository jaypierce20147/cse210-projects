using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps)
          : base(date, minutes)
    {
        _laps = laps;
    }
    public override float GetDistance()
    {
        return (_laps * 50f / 100f) * 0.62f;
    }
}