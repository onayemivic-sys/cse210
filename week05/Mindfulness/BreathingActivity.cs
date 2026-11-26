using System;

public class BreathingActivity : Activity
{
    // Constructor
    public BreathingActivity()
        : base(
            "Breathing Activity",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    // Run the breathing activity
    public void Run()
    {
        StartActivity();

        DateTime startTime = DateTime.Now;

        bool breatheIn = true;

        while ((DateTime.Now - startTime).TotalSeconds < Duration)
        {
            double elapsed = (DateTime.Now - startTime).TotalSeconds;
            int remaining = Duration - (int)elapsed;

            if (remaining <= 0)
            {
                break;
            }

            int breathDuration = Math.Min(4, remaining);

            if (breatheIn)
            {
                Console.WriteLine();
                Console.Write("Breathe in...");
            }
            else
            {
                Console.WriteLine();
                Console.Write("Breathe out...");
            }

            ShowCountDown(breathDuration);

            breatheIn = !breatheIn;
        }

        EndActivity();
    }
}