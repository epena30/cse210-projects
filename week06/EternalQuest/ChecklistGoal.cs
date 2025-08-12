using System;
using System.Collections.Generic;
using System.IO;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, IntPtr points, int target, int bonus) : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        _amountCompleted++;
        _points += _bonus;
        Console.WriteLine($"{_shortName} completed! You eanred {_points} points this time.");

    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailString()
    {
        string check = IsComplete() ? "[X]" : "[]";
        return $"{check} {_shortName} ({_description}) -- Completed {-_amountCompleted} / {_target} times";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}|{_description} | {_points}| {_target}| {_bonus}| {_amountCompleted}";
    }

}
