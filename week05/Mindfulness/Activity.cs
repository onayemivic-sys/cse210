using System;
using System.Threading;

public class Activity
{
    // Private member variables
    private string _name;
    private string _description;
    private int _duration;

    // Allow child classes to read the duration
    protected int Duration
    {
        get { return _duration; }
    }

    // Constructor
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    // Common starting message
    public void StartActivity()
    {
        Console.Clear();

        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");

        while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
        {
            Console.Write("Please enter a positive whole number: ");
        }

        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    // Common ending message
    public void EndActivity()
    {
        Console.WriteLine();
        Console.WriteLine("Good job!");
        ShowSpinner(2);

        Console.WriteLine();
        Console.WriteLine($"You have completed the {_name}.");
        Console.WriteLine($"You spent {_duration} seconds on this activity.");

        ShowSpinner(3);
    }

    // Spinner animation
    public void ShowSpinner(int seconds)
    {
        string[] animation = { "|", "/", "-", "\\" };

        DateTime startTime = DateTime.Now;
        int i = 0;

        while ((DateTime.Now - startTime).TotalSeconds < seconds)
        {
            Console.Write(animation[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i = (i + 1) % animation.Length;
        }
    }

    // Countdown animation
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}