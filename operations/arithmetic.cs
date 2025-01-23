using System;
namespace operations{
public class Calc{
   

    public  static void Simplecalc(string[] args)
    {
        
        Console.WriteLine("Enter the first number:");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double number2 = Convert.ToDouble(Console.ReadLine());

        double addition = number1 + number2;
        double subtraction = number1 - number2;
        double multiplication = number1 * number2;
        
        // division by zero
        double division = number2 != 0 ? number1 / number2 : double.NaN;
        double modulus = number2 != 0 ? number1 % number2 : double.NaN;

        
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
        
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}

    }
