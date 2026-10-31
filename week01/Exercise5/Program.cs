using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Program!");
        string userName = PromptUserName();
        int userNumber = PromptUserNumber(userName);
        int squaredNumber = SquareNumber(userNumber);
       
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            return Console.ReadLine();
        }
        
        static int PromptUserNumber(string userName)
        {
            Console.Write("Please enter your favorite number: ");
            return int.Parse(Console.ReadLine());
        }

        static int SquareNumber(int number)
        {
            return number * number;
        }

        DisplayResult(userName, squaredNumber);

        static void DisplayResult(string userName, int squaredNumber)
            {
                Console.WriteLine($"{userName}, the square of your number is {squaredNumber}  ");
            }
        }
}