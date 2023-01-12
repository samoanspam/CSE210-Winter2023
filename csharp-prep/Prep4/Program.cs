using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        List<int> numbers;
        numbers = new List<int>();
        int inputInt = -1;

        while (inputInt != 0)
        {
            Console.Write("Enter Number: ");
            inputInt = int.Parse(Console.ReadLine());
            numbers.Add(inputInt);
        }
        Console.WriteLine(numbers.Count - 1);
        int listLength = int.Parse(Console.ReadLine());

        // my code stops right here at line 19 and im not sure why

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum of the list is {sum}. ");

        float average = ((float)sum) / listLength;
        Console.WriteLine($"The average of the list is about {average}. ");


        int maximum = numbers[0];
        foreach (int number in numbers)
        {
            if (number > maximum)
            {
                maximum = number;
            }
        }
        Console.WriteLine($"The largest number on the list is {maximum}. ");
    }
}