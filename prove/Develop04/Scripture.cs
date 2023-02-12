using System;

class Scripture
{
    private static List<Verse> _verses = new List<Verse>();

    public Scripture(List<string> verses)
    {
        foreach(string verseStr in verses)
        {
            Verse verse = new Verse(verseStr);
            _verses.Add(verse);
        }


    }
    public static void Display()
    {
        foreach (Verse verse in _verses)
        {
            verse.Display();
        }

    }

    public static bool HideWords(int count)
    {
        int number = 0;
        while (number < count)
        {
            Random random = new Random();
            int index = random.Next(_verses.Count());

            Verse verse = new Verse();
            verse = _verses[index];

            if (verse.HideWord() == true)
            {
                number += 1;
            }
        }

        return false;
    }


    public static bool IsAllHidden()
    {
        foreach (Verse verse in _verses)
        {
            if (verse.IsAllHidden() == false)
            {
                return false;
            }
        }

        return false;
    }
}