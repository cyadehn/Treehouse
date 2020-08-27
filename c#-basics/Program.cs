using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new random number generator.
        Random generator = new Random();
        // Generate a floating-point number between 0 and 1.
        double randomNumber = generator.NextDouble();
        // Round the number to a single decimal place.
        double roundedNumber = Math.Round(randomNumber, 1);
        // Print the rounded number.
        Console.WriteLine(roundedNumber);
    }
}
