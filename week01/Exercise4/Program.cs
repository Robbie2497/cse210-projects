using System;
using System.ComponentModel.Design.Serialization;

// using System.Diagnostics.CodeAnalysis;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        Console.Write("Enter number: ");
        string numberAsText = Console.ReadLine();
        int number = int.Parse(numberAsText);
        int largestNumber = number;
        List<int> numbers = new List<int>();
        while (number != 0)
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }
            numbers.Add(number);
            Console.Write("Enter number: ");
            numberAsText = Console.ReadLine();
            number = int.Parse(numberAsText);
        }
        foreach (int listNumber in numbers)
        {
            Console.WriteLine(listNumber);
        }
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");
        double avgerage = numbers.Average();
        Console.WriteLine($"The average is: {avgerage}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}