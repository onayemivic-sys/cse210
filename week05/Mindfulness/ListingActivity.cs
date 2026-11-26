using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    // Store listing prompts
    private List<string> _prompts;

    // Store user responses
    private List<string> _responses;

    // Constructor
    public ListingActivity()
        : base(
            "Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        _responses = new List<string>();
    }

    // Run the listing activity
    public void Run()
    {
        StartActivity();

        Random random = new Random();

        int promptIndex = random.Next(_prompts.Count);

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {_prompts[promptIndex]} ---");

        Console.WriteLine();
        Console.Write("You may begin in: ");

        ShowCountDown(5);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Start listing your responses below.");
        Console.WriteLine("Press Enter after each response.");

        _responses.Clear();

        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < Duration)
        {
            Console.Write("> ");

            string response = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(response))
            {
                _responses.Add(response);
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {_responses.Count} items!");

        EndActivity();
    }

    // Get a list of responses from the user
    public List<string> GetListFromUser()
    {
        return new List<string>(_responses);
    }
}