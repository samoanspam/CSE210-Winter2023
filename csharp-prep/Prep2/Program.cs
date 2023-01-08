using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);
        int plusMinus = gradePercentage % 10;
        string plusMinusAnswer = plusMinus.ToString();
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

        if (plusMinus <= 3)
        {
           plusMinusAnswer = "-";
        }
        else if (plusMinus >= 7)
        {
           plusMinusAnswer = plusMinus.ToString();
           plusMinusAnswer = "+";
        }

        if (gradePercentage >= 93)
        {
            plusMinusAnswer = "";
        }
        // for the record I think there should be an "A+"
        
        if (finalGrade == "F")
        {
            plusMinusAnswer = "";
        }

        Console.WriteLine($"Your grade is an {finalGrade}{plusMinusAnswer}.");

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