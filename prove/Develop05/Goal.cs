using System;

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _isComplete;

    // Constructor
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }
    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    // Is for making sure extra points not awarded
    public bool IsComplete()
    {
        return _isComplete;
    }

    protected void SetComplete(bool complete)
    {
        _isComplete = complete;
    }

    public void ForceComplete()
    {
        SetComplete(true);
    }

    // Polymorphism
    public abstract int RecordEvent();
    public abstract string GetDetailsString();
    

}