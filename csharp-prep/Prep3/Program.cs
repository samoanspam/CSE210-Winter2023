using System;

class Program
{
    static void Main(string[] args)
    {
    Random randomGenerator = new Random();

    int actualNumber = randomGenerator.Next(1,101);
    int guess = -1;
    int count = 1;
    string playAgain = "yes";
    
    while (playAgain == "yes")
    {
        while (guess != actualNumber)
        {
            Console.Write("Guess a number 1-100: ");
            guess = int.Parse(Console.ReadLine());
            if (actualNumber > guess)
            {
                Console.WriteLine("Higher! ");
            }
            else if (actualNumber < guess)
            {
                Console.WriteLine("Lower! ");
            }
            else
            {
                Console.WriteLine("Bingo, you guessed it! ");
            }
            count += 1;
        }
        Console.Write("Do you want to play again? ");
        playAgain = Console.ReadLine().ToLower();
    }
    
    Console.WriteLine($"It took you {count} time(s) to guess it! ");
    }
}