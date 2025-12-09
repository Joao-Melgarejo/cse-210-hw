using System;

public abstract class Activity
{
    private string _date;
    protected double _length;
    
    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }

    public abstract double Distance();

    public abstract double Speed();

    public abstract double Pace();

    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_length} min)- Distance {Distance()} miles, Speed {Speed()} mph, Pace: {Pace()} min per mile";
    }

}