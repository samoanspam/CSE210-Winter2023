using System;
using System.Collections.Generic;

class Activity
{
    private string name = "";
    private string descripiton = "";
    private string welcomeMessage = "";
    private string endingMessage = "";
    private int duration = 0;

    public Activity()
    {
        // nothing to do here since arguements/variables are declared above.
    }

    public Activity(string name, string descripiton, string welcomeMessage, string endingMessage, int duration)
    {
        _name = name;
        _description = descripiton;
        _welcome = welcome;
        _ending = ending;
        _duration = duration;
    }
}