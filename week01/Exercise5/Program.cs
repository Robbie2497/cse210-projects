using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program!");
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Please enter your favorite number: ");
        string numberAsText = Console.ReadLine();
        double number = int.Parse(numberAsText);
        double squareOfNumber = number * number;
        Console.WriteLine($"{name}, the square of your number is {squareOfNumber}");
    }
}