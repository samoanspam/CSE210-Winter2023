using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Console.Write("What is your favorite color? ");
        string color = Console.ReadLine();
        Console.WriteLine($"Your color is {color}. ");
    }
}