using System;

public class Job
{
    public string _position;
    public string _company;
    public int _startYr;
    public int _endYr;

    public void Display()
    {
        Console.WriteLine($"{_position} {_company} {_startYr}-{_endYr}");
    }
}