using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);
        string finalGrade = "E";
        if (gradePercentage >= 90)
        {
            finalGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
            finalGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            finalGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            finalGrade = "D";
        }
        else
        {
            finalGrade = "F";
        }
        
        Console.WriteLine($"Your grade is an {finalGrade}.");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congradulations, you passed the class! ");
        }
        else
        {
            Console.WriteLine("Unfortunately you failed, try again next semester! ");
        }
    }
}