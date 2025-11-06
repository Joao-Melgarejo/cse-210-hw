using System;

public class Job
{
    public string _jobTitle;
    public string _factory;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} {_factory} {_startYear}-{_endYear}");
    }
}