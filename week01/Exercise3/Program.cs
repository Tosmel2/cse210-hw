using System;

class Program
{
    static void Main(string[] args)
    {
        int secretNumber = 7;
        Console.Write("What is your guess? ");
        String guess = Console.ReadLine();
        int guessNumber = int.Parse(guess);

        while (guessNumber != secretNumber)
        {
            if (guessNumber < secretNumber)
            {
                Console.WriteLine("Lower.");
            }
            else if (guessNumber > secretNumber)
            {
                Console.WriteLine("Higher.");
            }

            Console.Write("What is your guess? ");
            guess = Console.ReadLine();
            guessNumber = int.Parse(guess);

        Console.WriteLine("You guessed it!");
        }

        
    }
}