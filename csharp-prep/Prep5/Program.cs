using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        
        int number = randomGenerator.Next(1,101);  

        Console.Write("What is your guess? ");
        string guessInput = Console.ReadLine();
        int guess = int.Parse(guessInput);

        while (guess != number)
        {
            if (guess > number)
            {
                Console.WriteLine("Lower! ");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher! ");
            }
            Console.Write("What is your guess? ");
            string newGuess = Console.ReadLine();
            guess = int.Parse(newGuess);
        }
        Console.WriteLine("You guessed it! ");
    }
}