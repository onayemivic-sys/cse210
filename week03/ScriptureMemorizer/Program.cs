using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // CREATIVE ENHANCEMENTS:
        // This program includes a library of three scriptures,
        // random scripture selection, memorization progress tracking,
        // and completion statistics to improve the learning experience.

        // Create a library of scriptures.
        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."
        ));

        scriptures.Add(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
        ));

        scriptures.Add(new Scripture(
            new Reference("Philippians", 4, 13),
            "I can do all things through Christ which strengtheneth me."
        ));

        // Display the scripture selection menu.
        Console.WriteLine("================================");
        Console.WriteLine("     SCRIPTURE MEMORIZER");
        Console.WriteLine("================================");
        Console.WriteLine("Choose a scripture to memorize:");
        Console.WriteLine("1. Proverbs 3:5-6");
        Console.WriteLine("2. John 3:16");
        Console.WriteLine("3. Philippians 4:13");
        Console.WriteLine("4. Choose a random scripture");
        Console.WriteLine("0. Quit");

        Console.Write("\nEnter your choice: ");
        string choice = Console.ReadLine() ?? "";

        Scripture selectedScripture;

        // Select the scripture.
        switch (choice)
        {
            case "1":
                selectedScripture = scriptures[0];
                break;

            case "2":
                selectedScripture = scriptures[1];
                break;

            case "3":
                selectedScripture = scriptures[2];
                break;

            case "4":
                Random random = new Random();
                selectedScripture = scriptures[random.Next(scriptures.Count)];
                break;

            case "0":
                return;

            default:
                Console.WriteLine("Invalid choice. Please restart the program.");
                return;
        }

        // Start the memorization process.
        MemorizeScripture(selectedScripture);
    }

    static void MemorizeScripture(Scripture scripture)
    {
        while (true)
        {
            // Clear the console and display the scripture.
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            // Calculate memorization progress.
            int totalWords = scripture.GetWordCount();
            int hiddenWords = scripture.GetHiddenWordCount();

            double progress = (double)hiddenWords / totalWords * 100;

            Console.WriteLine("\n--------------------------------");
            Console.WriteLine("MEMORIZATION PROGRESS");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Total words: {totalWords}");
            Console.WriteLine($"Hidden words: {hiddenWords}");
            Console.WriteLine($"Progress: {progress:F0}%");

            // End when all words have been hidden.
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nCongratulations!");
                Console.WriteLine("You have hidden every word.");
                Console.WriteLine("Keep practicing until you memorize it!");
                break;
            }

            // Ask the user what to do next.
            Console.WriteLine("\nPress ENTER to hide 3 random words.");
            Console.WriteLine("Type 'quit' to exit.");

            string input = Console.ReadLine() ?? "";

            if (input.Trim().ToLower() == "quit")
            {
                break;
            }

            // Hide three additional random words.
            scripture.HideRandomWords(3);
        }
    }
}
