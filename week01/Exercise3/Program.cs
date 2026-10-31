using System;

class Program
{

    static void Main(string[] args)
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101);
        Console.Write("What is your guess? ");
        String guess = Console.ReadLine();
        int guessNumber = int.Parse(guess);

        int guessCount = 1;
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
            guessCount++;

            Console.Write("What is your guess? ");
            guess = Console.ReadLine();
            guessNumber = int.Parse(guess);


        }
        Console.WriteLine("You guessed it!");
        Console.WriteLine($"You made {guessCount} guesses.");

        Console.Write("Do want to play again? Yes/No: ");
        String response = Console.ReadLine();

        while (response == "Yes" || response == "yes" || response == "Y" || response == "y")
        {
            secretNumber = random.Next(1, 101);
            Console.Write("What is your guess? ");
            guess = Console.ReadLine();
            guessNumber = int.Parse(guess);

            guessCount = 1;
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
                guessCount++;

                Console.Write("What is your guess? ");
                guess = Console.ReadLine();
                guessNumber = int.Parse(guess);
            }
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"You made {guessCount} guesses.");

            Console.Write("Do want to play again? Yes/No: ");
            response = Console.ReadLine();
        }
        Console.WriteLine("Thanks for playing!");



        
    }
}