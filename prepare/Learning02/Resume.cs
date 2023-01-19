public class Resume
{
    public string _name = "";
    public List<Job> _jobs = new List<Job>();
    
// I tried adding a "constructor" here but it gave me errors that I didn't undertand.
    public void Display()
    {
        System.Console.WriteLine($"Name: {_name} ");
        System.Console.WriteLine("Jobs: ");

        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}