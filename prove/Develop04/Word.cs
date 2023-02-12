using System;

class Word
{
    private string _text = "";
    private bool _hidden = false;

    public Word()
    {
        // Blank Constructor
    }
    public Word(string text)
    {
        _text = text;
    }

    public void Display()
    {
        if (_hidden)
        {
            foreach (char c in _text)
            {
                Console.Write('_');
            }
            
        } else {
            Console.Write(_text);
        }
        
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public bool Clear()
    {
        _hidden = true;
        
        return _hidden;
    }
}