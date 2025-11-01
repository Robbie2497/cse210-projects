using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        double number = PromptUserNumber();
        double squareNumber = SquareNumber(number);
        DisplayResult(name, squareNumber);
    }
    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static double PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string numberAsText = Console.ReadLine();
        double number = int.Parse(numberAsText);
        return number;
    }

    static double SquareNumber(double number)
    {
        return number * number;
    }

    static void DisplayResult(string name, double squareNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squareNumber}");
    }
}