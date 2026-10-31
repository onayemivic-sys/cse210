using System;

class Program
{
    static void Main(string[] args)
    {
        //Ask the student grade in a variable
        Console.Write("Enter your course percentage:");
        int percentage = int.Parse(Console.ReadLine());
        
        //store grade
        string letter;

        //determine the letter grade
        if (percentage >= 90)
        {
            letter = "A";
        }
        
        else if(percentage >=80)
        {
            letter = "B";
        }
        else if (percentage >=70)
        {
            letter = "C";
        }
        else if(percentage >=60)
        {
            letter ="D";
        }
        else
        {
            letter="F";
        }

        //display the letter grade
        Console.WriteLine($"Your letter grade is: {letter}");

        if (percentage >=70)
        {
            Console.WriteLine("Congratulations!! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep trying! Don't give up. You can do better next time.");
        }
    }
}