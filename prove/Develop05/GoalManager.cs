using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private int _score = 0;
    private List<Goal> _goals = new List<Goal>();


    // Allow the program to add a goal to the list
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);


    }

    // Shows goals in a list
    public void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

    }

    // Record the points and goals completed
    public void RecordEvent(int goalNumber)
    {
        Goal goal = _goals[goalNumber];
        int pointsEarned = goal.RecordEvent();
        _score += pointsEarned;

        Console.WriteLine($"You earned {pointsEarned} points!");
    }
    public void ShowScore()
    {
        Console.WriteLine($"Your score is: {_score}");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter output = new StreamWriter(filename))
        {   // Save the score of the user
            output.WriteLine(_score);

            // Save each goal
            foreach (Goal g in _goals)
            {
                if (g is SimpleGoal sg)
                {   // 
                    output.WriteLine($"Simple|{sg.GetName()}|{sg.GetDescription()}|{sg.GetPoints()}|{sg.IsComplete()}");
                }

                else if (g is EternalGoal eg)
                {   // Check correct formatting
                    output.WriteLine($"Eternal|{eg.GetName()}|{eg.GetDescription()}|{eg.GetPoints()}");
                }

                else if (g is ChecklistGoal cg)
                {   // This is to access the private variables in other files
                    output.WriteLine($"Checklist|{cg.GetName()}|{cg.GetDescription()}|{cg.GetPoints()}|" +
                                     $"{cg.GetTargetCount()}|{cg.GetCompletedCount()}|{cg.GetBonusPoints()}|{cg.IsComplete()}");
                }

            }
        }

    }


    public void LoadGoals(string filename)
    {
        // Read the file
        string[] lines = File.ReadAllLines(filename);

        // Read in the score
        _score = int.Parse(lines[0]);

        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {   // Iterrate through the lines of the goals
            string line = lines[i];
            string[] parts = line.Split('|');
            string goalType = parts[0];

            if (goalType == "Simple")
            {   // Gives the program the necessary information to load the goals
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);
                // Initialize the simple goal
                SimpleGoal g = new SimpleGoal(name, description, points);

                // So i dont give extra points
                if (isComplete)
                {
                    g.ForceComplete();
                }
                _goals.Add(g);
            }
            else if (goalType == "Eternal")
            {   // Formatting for Eternal goal
                string name = parts[1];
                string description = parts.Length > 4
                    ? string.Join("|", parts, 2, parts.Length - 3)
                    : parts[2];
                int points = int.Parse(parts[parts.Length - 1]);

                EternalGoal g = new EternalGoal(name, description, points);
                _goals.Add(g);
            }
            else if (goalType == "Checklist")
            {   // Logic for the goals
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int target = int.Parse(parts[4]);
                int completed = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);
                bool isComplete = bool.Parse(parts[7]);

                ChecklistGoal cg = new ChecklistGoal(name, description, points, target, bonus);

                cg.ForceSetCompletedCount(completed);

                if (isComplete)
                {
                    cg.ForceComplete();
                }

                _goals.Add(cg);
            }
        }
    }
}