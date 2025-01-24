using System;
namespace Methods{
    public class Message{ 
         public static void PrintMessage()
        {
            Console.WriteLine("Hello! This is a message from the method.");
        }

        public static void Mainmessage(string[] args)
        {
            PrintMessage();
        }
    }

namespace FactorialCalculator
{
    public class Factorialcalc
    {
        public static long Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }

            long result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        public static void Mainfactor(string[] args)
        {
            Console.Write("Enter a number to calculate its factorial: ");
            string? input = Console.ReadLine();

            try
            {
                if (string.IsNullOrEmpty(input))
                    throw new ArgumentException("Input cannot be empty.");

                
                int number = int.Parse(input);

                long result = Factorial(number);
                Console.WriteLine($"The factorial of {number} is: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
}