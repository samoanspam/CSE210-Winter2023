class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        // Nothing
    }

    public BreathingActivity(int duration) : base("Breath", duration, "welcome the B", "endding B", "peepeepoopoo")
    {

    }


    public void doIt()
    {
        PauseAnimation(3);
        System.Console.WriteLine("Hello");
        PauseAnimation(3);
    }
}