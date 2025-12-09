using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _list = new List<Activity>();

        _list.Add(new Running("09 December 2025", 30, 3.0));
        _list.Add(new Cycling("10 December 2025", 48, 52.6));
        _list.Add(new Swimming("11 December 2025",27, 4));

        foreach (Activity input in _list)
    {
        Console.WriteLine(input.GetSummary());
    }

    }
}