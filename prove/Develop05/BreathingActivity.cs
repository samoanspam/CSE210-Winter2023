class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        // Nothing
    }

    public BreathingActivity(int duration) : base("Breath", duration, "Welcome", "Ending", "peepeepoopoo")
    {

    }


    public void doIt()
    {
        PauseAnimation(3);
        System.Console.WriteLine("Hello");
        PauseAnimation(3);
    }
}