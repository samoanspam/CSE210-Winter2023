using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity();
        ReflectionActivity RA = new ReflectionActivity();
        ListeningActivity LA = new ListeningActivity();
        BreathingActivity BA = new BreathingActivity();
        RA.doIt();
        LA.doIt();
        BA.doIt();
    }
}