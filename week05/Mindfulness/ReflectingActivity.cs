using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    // Store reflection prompts
    private List<string> _prompts;

    // Store reflection questions
    private List<string> _questions;

    // Constructor
    public ReflectingActivity()
        : base(
            "Reflecting Activity",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    // Run the reflecting activity
    public void Run()
    {
        StartActivity();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");

        Random random = new Random();

        int promptIndex = random.Next(_prompts.Count);

        Console.WriteLine();
        Console.WriteLine($"--- {_prompts[promptIndex]} ---");

        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        DateTime startTime = DateTime.Now;

        Console.WriteLine();

        while ((DateTime.Now - startTime).TotalSeconds < Duration)
        {
            double elapsed = (DateTime.Now - startTime).TotalSeconds;
            int remaining = Duration - (int)elapsed;

            if (remaining <= 0)
            {
                break;
            }

            int questionIndex = random.Next(_questions.Count);

            Console.WriteLine();
            Console.WriteLine(_questions[questionIndex]);

            int pauseTime = Math.Min(5, remaining);

            ShowSpinner(pauseTime);
        }

        EndActivity();
    }

    // Display reflection questions
    public void DisplayQuestions()
    {
        Random random = new Random();

        int index = random.Next(_questions.Count);

        Console.WriteLine(_questions[index]);
    }
}