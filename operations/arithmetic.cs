using System;
namespace operations{
public class Calc{
   

    public  static void Simplecalc(string[] args)
    {
        // Prompt the user to enter two numbers
        Console.WriteLine("Enter the first number:");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double number2 = Convert.ToDouble(Console.ReadLine());

        // Perform arithmetic operations
        double addition = number1 + number2;
        double subtraction = number1 - number2;
        double multiplication = number1 * number2;
        
        // Handle division by zero
        double division = number2 != 0 ? number1 / number2 : double.NaN;
        double modulus = number2 != 0 ? number1 % number2 : double.NaN;

        // Display the results
        Console.WriteLine("\nResults:");
        Console.WriteLine($"Addition: {addition}");
        Console.WriteLine($"Subtraction: {subtraction}");
        Console.WriteLine($"Multiplication: {multiplication}");
        Console.WriteLine($"Division: {(number2 != 0 ? division.ToString() : "Undefined (division by zero)")}");
        Console.WriteLine($"Modulus: {(number2 != 0 ? modulus.ToString() : "Undefined (division by zero)")}");
          Console.WriteLine("Area");
         Console.WriteLine("Enter the Width:");
        double  Width = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length:");
        double Length = Convert.ToDouble(Console.ReadLine());
        double Area = Width * Length;
        Console.WriteLine($"Area: {Area}");
        // Wait for the user to press a key before exiting
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}

    }
