using System;

class Program
{
    static void Main()
    {
        // Prompt the user for their name
        Console.WriteLine("Enter your name:");

        // Read the user input
        string name = Console.ReadLine();

        // Greet the user
        Console.WriteLine($"Hello, {name}!");

        // Wait for the user to press a key before closing
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
