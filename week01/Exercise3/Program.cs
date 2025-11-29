using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        Console.Write("What is your guess? ");
        string guessInText = Console.ReadLine();
        int guess = int.Parse(guessInText);
        while (guess != number)
        {

            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            
            Console.Write("What is your guess? ");
            guessInText = Console.ReadLine();
            guess = int.Parse(guessInText);
        }
        Console.WriteLine("You guessed it!");
    }
}