using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        bool keepPlaying = true;

        while (keepPlaying != true)
        {
            int number = randomGenerator.Next(1,101);  

            Console.Write("What is your guess? ");
            string guessInput = Console.ReadLine();
            int guess = int.Parse(guessInput);
            int count = 0;
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

                count += 1;
            }
            Console.WriteLine("You guessed it! ");
            Console.WriteLine($"It took you {count} tries!");

            Console.Write("Would you like to play again? ");
            string keepPlayingInput = Console.ReadLine().ToLower();

            if (keepPlayingInput == "yes")
            {
                keepPlaying = bool.Parse(keepPlayingInput);
                keepPlaying = true;
            }
            else if (keepPlayingInput == "no")
            {
                keepPlaying = bool.Parse(keepPlayingInput);
                keepPlaying = false;  
            }
        }
    }
}