using System;
using System.Collections.Generic;
using System.Globalization;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        string ActivityType = this.GetType().Name;
        string formattedDated = _date.ToString("dd MMM yyy", CultureInfo.InvariantCulture);
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        return $"{formattedDated} {ActivityType}({_minutes} min) - Distance {distance:F1} miles, Speed {speed}";
    }
}



