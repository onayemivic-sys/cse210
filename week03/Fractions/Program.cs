using System;

class Program
{
    static void Main(string[] args)
    {
        // Create fractions using the three constructors

Fraction fraction1 = new Fraction();
Fraction fraction2 = new Fraction(5);
Fraction fraction3 = new Fraction(3, 4);
Fraction fraction4 = new Fraction(1, 3);

// Display the first fraction
Console.WriteLine(fraction1.GetFractionString());
Console.WriteLine(fraction1.GetDecimalValue());

// Display the second fraction
Console.WriteLine(fraction2.GetFractionString());
Console.WriteLine(fraction2.GetDecimalValue());

// Display the third fraction
Console.WriteLine(fraction3.GetFractionString());
Console.WriteLine(fraction3.GetDecimalValue());

// Display the fourth fraction
Console.WriteLine(fraction4.GetFractionString());
Console.WriteLine(fraction4.GetDecimalValue());

// Test the getters
Console.WriteLine();
Console.WriteLine("Testing Getters:");

Console.WriteLine($"Top: {fraction3.GetTop()}");
Console.WriteLine($"Bottom: {fraction3.GetBottom()}");

// Test the setters
Console.WriteLine();
Console.WriteLine("Testing Setters:");

fraction3.SetTop(6);
fraction3.SetBottom(7);

Console.WriteLine($"New Top: {fraction3.GetTop()}");
Console.WriteLine($"New Bottom: {fraction3.GetBottom()}");

// Display the updated fraction
Console.WriteLine(fraction3.GetFractionString());
Console.WriteLine(fraction3.GetDecimalValue());
    }
}