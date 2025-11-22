using System;

public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _completedCount;
    private int _bonusPoints;

    public int GetTargetCount()
    {
        return _targetCount;
    }
    public int GetCompletedCount()
    {
        return _completedCount;
    }
    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    //Constructor
    public ChecklistGoal(
        string name, 
        string description,
        int points,
        int targetCount,
        int bonusPoints
    ) : base(name, description, points)
    {
        _targetCount = targetCount;
        _completedCount = 0;
        _bonusPoints = bonusPoints;
    }

    // Method overrides
    public override int RecordEvent()
    {
        if (IsComplete())
        {
            return 0;
        }

        // Earn points per complete
        _completedCount++;

        int earnedPoints = GetPoints();

        // Mark complete and earn bonus points when completed
        if (_completedCount >= _targetCount)
        {
            SetComplete(true);
            earnedPoints += _bonusPoints;
        }
        return earnedPoints;
    }

    public override string GetDetailsString()
    {   // Check if the goal is completed
        string status = IsComplete() ? "[x]" : "[ ]";
        return $"{status} {GetName()} ({GetDescription()}) -- Completed {_completedCount}/{_targetCount}";
    }

    public void ForceSetCompletedCount(int count)
    {   // Check for set completion
        _completedCount = count;

        if (_completedCount >= _targetCount)
        {
            SetComplete(true);
        }
    }

}