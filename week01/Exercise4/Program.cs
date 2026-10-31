using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        List<int> numbers = new List<int>();
        Console.Write("Enter number: ");
        
        String entry = Console.ReadLine();
        int enteredNumber = int.Parse(entry);

        while (enteredNumber != 0)
        {
            numbers.Add(enteredNumber);
            Console.Write("Enter number: ");
            entry = Console.ReadLine();
            enteredNumber = int.Parse(entry);
        }
 
        int sum = 0;
        Console.WriteLine("You entered the following numbers:");       
       
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {((double)sum / numbers.Count)}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");

        int smallestPositive = numbers.Where(n => n > 0).DefaultIfEmpty(0).Min();
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        Console.WriteLine("The sorted list is:");
        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}