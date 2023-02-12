using System;

class Verse
{
    private List<Word> _words;
    private bool _hidden;

    public Verse()
    {
        // Blank Constructor
    }
    public Verse(string verse)
    {
        _words = new List<Word>();

        char[] delimiterchars = {' ', ',', '.', ':', '\t'};
        string[] words = verse.Split(delimiterchars);
        foreach (string wordStr in words)
        {
            Word word = new Word(wordStr);
            _words.Add(word);
        }

    }

    public int RandomIndexes()
    {
        Random random = new Random();
        int index = random.Next(_words.Count());

        return index;
    }

    public void Display()
    {
        foreach (Word word in _words)
        {
            word.Display();
            System.Console.Write(" ");
        }
        System.Console.WriteLine("");
    }
    
    public bool HideWord()
    {
        int count = 0;
        while (_hidden == true)
        {
            Word word = new Word();
            int index = RandomIndexes();
            word = _words[index];
            count += 1;

            if (word.IsHidden() == false)
            {
                word.Clear();
                return true;
            }
            // * x Amount of Words
            if (count > _words.Count() * 3)
            {
                return false;
            }
        }
        return false;
    }

    public bool IsAllHidden()
    {
        if (_hidden == true)
        {
            return true;
        } else {
            foreach (Word word in _words)
            {
                if (word.IsHidden() == false)
                {
                    return false;
                }
                _hidden = true;

                return _hidden;
            }
        }

        return false;
    }
}