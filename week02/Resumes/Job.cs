using System;
using System.Diagnostics.Contracts;

public class Job
{
    public string _JobTitle;
    public string _company;
    public int _StartYear;
    public int _endYear;

    public void Display()
    {
        Console.Write($"{_JobTitle} ({_company}) {_StartYear}-{_endYear})");

    }
}
