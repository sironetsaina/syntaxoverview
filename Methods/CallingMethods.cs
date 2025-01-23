using System;
namespace Method{
public class Add
{
    // Method to accept two integers and return their sum
    public static int AddNumbers(int num1, int num2)
    {
        return num1 + num2;
    }

    public static void Sum(string[] args)
    {
        
        int number1 = GetValidInteger("Enter the first number: ");
        int number2 = GetValidInteger("Enter the second number: ");
        int result = AddNumbers(number1, number2);
        Console.WriteLine($"The sum of {number1} and {number2} is: {result}");
    }
    static int GetValidInteger(string prompt)
    {
        int validNumber;
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out validNumber))
            {
                return validNumber;
            }
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}


public class Getlength
{
    // Method to calculate the length of a string
    public static int StringLength(string input)
    {
        return input.Length;
    }

    // Main method
    public static void Mainlength(string[] args)
    {
        // Handle user input
        Console.Write("Enter a string: ");
        string? userInput = Console.ReadLine();

        if (!string.IsNullOrEmpty(userInput))
        {
            int length = StringLength(userInput);
            Console.WriteLine($"The length of the string \"{userInput}\" is: {length}");
        }
        else
        {
            Console.WriteLine("You entered an empty or null string.");
        }

        if (args.Length > 0)
        {
            string firstArg = args[0];
            int argLength = StringLength(firstArg);
            Console.WriteLine($"The length of the first command-line argument \"{firstArg}\" is: {argLength}");
        }
        else if (args.Length < 0)
        {
            Console.WriteLine("No command-line arguments were passed.");
        }
    }
}
}