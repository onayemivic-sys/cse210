using System;

class Program
{
    static void Main(string[] args)
    {
          
        DisplayWelcome();

        
        string name = PromptUserName();

        int number = PromptUserNumber();

        
        int squaredNumber = SquareNumber(number);

        DisplayResult(name, squaredNumber);
    }

   
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Ask for the user's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    //  Ask for the user's favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    //  Square the user's number
    static int SquareNumber(int number)
    {
        int squared = number * number;
        return squared;
    }

    //kDisplay the final result
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    
    }
}