using System;

namespace ExceptionHandling
{
    class DivisionCalculator
    {
        public static void StartDivision(string[] args)
        {
            try
            {
                Console.Write("Enter the numerator: ");
                double numerator = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the denominator: ");
                double denominator = Convert.ToDouble(Console.ReadLine());

                double result = Divide(numerator, denominator);
                Console.WriteLine($"Result: {numerator} / {denominator} = {result}");
            }
            catch (DivideByZeroException)
            {
                // Handle divide by zero error
                Console.WriteLine("Error: Division by zero is not allowed. Please enter a valid denominator.");
            }
            catch (FormatException)
            {
                // Handle invalid input
                Console.WriteLine("Error: Please enter a valid number.");
            }
            catch (Exception ex)
            {
                // Handle unexpected errors
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Thank you for using the division calculator.");
            }
        }

        static double Divide(double numerator, double denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException();
            }
            return numerator / denominator;
        }
    }
    // Step 1: Define a custom exception class
    class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message) { }
    }

    class AgeValidator
    {        public static void ValidateAge(int age)
        {
            if (age <= 0)
            {
                throw new InvalidAgeException("Error: Age cannot be zero or negative. Please enter a valid age.");
            }
            Console.WriteLine($"Valid Age Entered: {age} years old.");
        }
        public static void MainAgechecker(string[] args)
        {
            try
            {
                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                ValidateAge(age);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a numeric value for age.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Thank you for using the age validation system.");
            }
        }
    }
}







