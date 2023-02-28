using System;

class Activity
{
    private string _name = "";
    private int _duration = 0;
    private string _description = "";
    private string _welcomeMessage = "";
    private string _goodbyeMessage = "";

    public Activity()
    {
        // Nothing
    }
    public Activity(string name, int duration, string description, string welcomeMessge, string goodbyeMessage)
    {
        _name = name;
        _duration = duration;
        _description = description;
        _welcomeMessage = welcomeMessge;
        _goodbyeMessage = goodbyeMessage;
    }

    public void DisplayBeginning()
    {
        System.Console.WriteLine(_welcomeMessage);
    }

    public void DisplayEnding()
    {
        System.Console.WriteLine(_goodbyeMessage);
    }
    public void DisplayPrompt()
    {
        System.Console.WriteLine(_description);
    }

    public void PauseAnimation()
    {
        int count = 0;
        while (count < 10)
            Console.Write("+");

            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("x");
            count++;
    }
}