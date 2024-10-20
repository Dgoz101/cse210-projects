using System;

public class ListingActitivity : Activity 
{
    private List<string> _prompts = new List<string>();

    private List<string> _responses = new List<string>();

    public ListingActitivity()
    {
        SetName("Listing");
        SetDescription("This activity will help you reflect on the good things in your life by having list as many thing as you can in a certain area.");
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        int runTime = int.Parse(Console.ReadLine());

        SetTime(runTime);

        Console.Clear();

        Console.WriteLine("Get Ready...");
        ShowSpinner(8);

        Console.WriteLine("\nList as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in...");
        ShowCountDown(5);
        Console.WriteLine("");
        List<string> list = new List<string>();

        int clock = GetDuration();

        DateTime time = DateTime.Now;
        DateTime timeEnd = time.AddSeconds(clock);

        while (DateTime.Now < timeEnd)
        {
            if (DateTime.Now < timeEnd)
            {
                list = GetListFromUser();
            }               
        }

        Console.WriteLine($"You listed {list.Count} items!");
        DisplayEndingMessage();
        ShowSpinner(5);
    }

    public void GetRandomPrompt()
    {
        Random prompt = new Random();
        int numb = prompt.Next(0, _prompts.Count);
        
        Console.WriteLine($"---{_prompts[numb]}---");
    }

    public List<string> GetListFromUser()
    {
        
        string answer = Console.ReadLine();
        _responses.Add(answer);
        
        return _responses;       
    }
}