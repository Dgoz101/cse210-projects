using System;

class Word
{
    private string _text;
    private bool _Hidden;


    public Word(string text)
    {
        _text = text;
        _Hidden = false;
    }


    public void Hide()
    {
        _Hidden = true;
    }


    public void Show()
    {
        _Hidden = false;
    }


    public bool IsHidden()
    {
        return _Hidden;
    }


    public string GetDisplayText()
    {
        if (_Hidden)
        {
            return new string('_', _text.Length);
        }
        return _text;
    }

    
}