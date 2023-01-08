using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);

        if (gradePercentage > 90)
        {
            string finalGrade = "A";
            Console.WriteLine($"Your grade is an {finalGrade}. Amazing Job! ");
        }
        else if (gradePercentage > 80)
        {
            string finalGrade = "B";
            Console.WriteLine($"Your grade is an {finalGrade}. Good Job! ");
        }
        else if (gradePercentage > 70)
        {
            string finalGrade = "C";
            Console.WriteLine($"Your grade is an {finalGrade}. Alright Job! ");
        }
        else if (gradePercentage > 60)
        {
            string finalGrade = "D";
            Console.WriteLine($"Your grade is an {finalGrade}. Not Good Job! ");
        }
        else
        {
            string finalGrade = "F";
            Console.WriteLine($"Your grade is an {finalGrade}. Bad Job! ");
        }


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