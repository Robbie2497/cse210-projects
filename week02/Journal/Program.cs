// For exceeding requirements, I added in a scripture to go along with the journal entry if the user wants to enter one.

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    private static Journal journal = new Journal();
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        string userChoice = ShowMenu();
        while (userChoice != "5")
        {
            if (userChoice == "1")
            {
                WriteNewEntry();
            }
            else if (userChoice == "2")
            {
                ShowJournal();
            }
            else if (userChoice == "3")
            {
                LoadJournal();
            }
            else if (userChoice == "4")
            {
                SaveJournal();
            }
            else
            {
                Console.WriteLine("Please only enter a number 1 - 5");
            }
            userChoice = ShowMenu();
        }
        if (userChoice == "5")
        {
            Console.WriteLine("See you next time!");
            Environment.Exit(0);
        }
    }

    static string ShowMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        string userChoice = Console.ReadLine();
        userChoice = userChoice.Trim();
        return userChoice;
    }

    static void WriteNewEntry()
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("> ");
        string userEntry = Console.ReadLine();
        Entry newEntry = new Entry();
        newEntry._date = DateTime.Now.ToShortDateString();
        newEntry._prompt = prompt;
        newEntry._response = userEntry;

        // For exceeding requirements, I added in a scripture to go along with the journal entry if the user wants to enter one.
        Console.Write("Have you read your scriptures yet today? (y/n) ");
        string scriptures = Console.ReadLine().Trim().ToLower();
        string scripture = "";
        if (scriptures == "y" || scriptures == "yes")
        {
            Console.WriteLine("Great job! What scripture did you read today?");
            scripture = Console.ReadLine();
        }
        else if (scriptures == "n" || scriptures == "no")
        {
            Console.WriteLine("Don't forget to set time aside today read your scriptures!");
            scripture = "No scripture entered today.";
        }
        else
        {
            Console.WriteLine("Please answer by yes, y, no, or n only.");
        }
        newEntry._scripture = scripture;
        journal.AddEntry(newEntry);
    }

    static void ShowJournal()
    {
        journal.DisplayAllEntries();
    }
    static void SaveJournal()
    {
        journal.SaveToFile();
    }
    static void LoadJournal()
    {
        journal.LoadFromFile();
    }


}