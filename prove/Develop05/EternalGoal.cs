using System;

public class EternalGoal : Goal
{
    // Inheritance used
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    // Award points every time completed
    public override int RecordEvent()
    {
        return GetPoints();
    }

    // Formatting for the goals
    public override string GetDetailsString()
    {
        return $"[ ] {GetName()} ({GetDescription()})";
    }
}