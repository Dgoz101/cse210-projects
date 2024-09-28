
public class PromptGenerator
{

    public List<string> _MyPrompts = new List<string>
    {
     "Who was the most interesting person I interacted with today?",
     "What was the best part of my day?",
     "How did I see the hand of the Lord in my life today?",
     "What was the strongest emotion I felt today?",
     "If I had one thing I could do over today, what would it be?"
    };

    public string Generator()
    {
        Random Prompt = new Random();
        int x = Prompt.Next(_MyPrompts.Count);
        string y = _MyPrompts[x];
        Console.WriteLine($"{y}");
        return y;
    }
}