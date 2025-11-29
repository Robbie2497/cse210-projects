using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentageInText = Console.ReadLine();
        int percentage = int.Parse(percentageInText);
        string letter;
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else if (percentage <= 60)
        {
            letter = "F";
        }
        else
        {
            letter = "";
            Console.WriteLine("Please enter a number from 0 - 100. Do NOT include the % symbol.");
        }
        Console.WriteLine(letter);
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("Unfortunatly you did not pass the class. Give it another try!");
        }
    }
}