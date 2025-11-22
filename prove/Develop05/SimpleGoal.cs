using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        
    }

    // This overrides basic behaviors in the Record Event method
    public override int RecordEvent()
    {
        if (IsComplete())
        {
            return 0;
        }
        SetComplete(true);

        // Award points
        return GetPoints();
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[x]" : "[ ]";
        // Shows name and description and status
        return $"{status} {GetName()} ({GetDescription()})";
    }
}