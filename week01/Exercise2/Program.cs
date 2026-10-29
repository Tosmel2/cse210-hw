using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        String gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);

        string sign = "";
        int lastDigit = grade % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        if (grade >= 90)
        {
            Console.WriteLine("You received an A" + sign + " and passed the course.");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("You received a B" + sign + " and passed the course.");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("You received a C" + sign + " and passed the course.");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("You received a D" + sign + " and failed the course. Try again next semester. ");
        }
        else
        {
            Console.WriteLine("You received an F" + sign + " and failed the course. Try again next semester.");
        }
    }
}