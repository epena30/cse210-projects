using System;
using System.Collections.Generic;
using System.IO;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete = false) : base (name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"{_shortName} completed! You earned {_points} points.");
    }
    
    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailString()
    {
        string completionStatus = _isComplete ? "[x]" : "[ ]";
        return $"{completionStatus} {_shortName} - {_description}";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal {_shortName}, {_description}, {_points}, {_isComplete}";
    }

}