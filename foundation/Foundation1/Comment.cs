using System;

public class Comment 
{
   public string _name;
   public string _text;

    public Comment()
    {
    }

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public void GetComment()
    {
        Console.WriteLine($"{_name} says: {_text}");
    }
}