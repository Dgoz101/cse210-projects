using System;

class Reference
{
    private string _title;
    private int _chapter;
    private int _verse;
    private int _endVerse;


    public Reference(string title, int chapter, int verse)
    {
        _title = title;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string title, int chapter, int startVerse, int endVerse)
    {
        _title = title;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }


    public string GetDisplayText()
    {
        if (_endVerse > 0)
        {
            return $"{_title} {_chapter}:{_verse}-{_endVerse} ";
        }
        else
        {
            return $"{_title} {_chapter}:{_verse} ";
        }
    }


}