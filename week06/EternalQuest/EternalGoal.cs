using System;
using System.Collections.Generic;
using System.IO;


public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points);
    {
        
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"{_shortName} Recorded! You earned {_points} points.");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailString()
    {
        return $"{_shortName} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}, {_description}, {_points}";
    }
}
