using System;

public class BreathingActivity : Activity 
{
    public BreathingActivity()
    {
        SetName("Breathing");
        SetDescription("This activity will help you relax by walking you through your breathing. Clear your mind and focus on your breathing. Breathe in and out with the timer.");
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        int runTime = int.Parse(Console.ReadLine());

        SetTime(runTime);

        DateTime time1 = DateTime.Now;
        DateTime time2 = time1.AddSeconds(runTime);

        Console.Clear();
        
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);

        while (DateTime.Now < time2)
        {
        Console.Write("\nBreathe in...");
        ShowCountDown(2);
        Console.Write("\nNow breathe out...");
        ShowCountDown(3);
        Console.Write("\nBreathe in...");
        ShowCountDown(3);
        Console.Write("\nBreath out...");
        ShowCountDown(4);
        }
        
        DisplayEndingMessage();
        ShowSpinner(5);
    }
}