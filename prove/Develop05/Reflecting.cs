using System;

public class ReflectingActivity : Activity 
{

    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    public ReflectingActivity()
    {
        SetName("Reflecting");
        SetDescription("This activity will help you reflect on your life to find special moments.");
        
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");      
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        int runTime = int.Parse(Console.ReadLine());

        SetTime(runTime);
       
        Console.Clear();

        Console.WriteLine("Get Ready...");

        ShowSpinner(5);

        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();
        Console.WriteLine("When you have thought of something, press the space bar to begin.");
        
                
        if (Console.ReadKey().Key == ConsoleKey.Spacebar)
        {
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in: ");
            ShowCountDown(3);

            Console.Clear();

            DateTime time3 = DateTime.Now;
            DateTime time4 = time3.AddSeconds(runTime);

            while (DateTime.Now < time4)
            {                          
            DisplayQuestions();
            ShowSpinner(4);
            }

            DisplayEndingMessage();
            ShowSpinner(5);

        } 
        
        else 
        { 
        DisplayEndingMessage();
        ShowSpinner(3);
        }
    }

    public string GetRandomPrompt()
    {
        Random prompt = new Random();
        int numb = prompt.Next(0, _prompts.Count);

        string promp = _prompts[numb];
        return promp;
    }

    public string GetRandomQuestion()
    {
        Random quest = new Random();
        int numb = quest.Next(0, _questions.Count);
        
        string question = _questions[numb];
        
        _questions.RemoveAt(numb);

        if (_questions.Count < 1)
        {
            Console.WriteLine("End of questions.");
        }
        return question;
    }

    public void DisplayPrompt()
    {
        string reflection = GetRandomPrompt();
        Console.WriteLine($"---{reflection}---");
    }

    public void DisplayQuestions()
    {
        string ask = GetRandomQuestion();
        Console.Write($"\n{ask}");
    }
}