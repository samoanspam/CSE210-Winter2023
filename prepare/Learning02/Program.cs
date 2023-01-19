using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Boss";

        Job job2 = new Job();
        job2._company = "Microsoft";
        System.Console.WriteLine(job2._company);
        job2._company = "Apple";
        System.Console.WriteLine(job2._company);

        System.Console.WriteLine(job1._jobTitle);
    }
}