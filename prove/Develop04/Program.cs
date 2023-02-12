using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> verses = new List<string>
        {
            "Mosiah Chapter 3 Verse 19",
            "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth ", 
            "off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all ",
            "things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father"
        };
        
        Scripture scripture = new Scripture(verses);
        Scripture.Display();
        Scripture.HideWords(3);
        Scripture.IsAllHidden();
    }
}