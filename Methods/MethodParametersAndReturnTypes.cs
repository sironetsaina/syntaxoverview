using System;

namespace Methods
{
    public class StringRepeater
    {
        public static string RepeatString(string originalString, int times)
        {
            string result = "";
            for (int i = 0; i < times; i++)
            {
                result += originalString + "\n"; 
            }
            return result;
        }

        public static void Mainstring(string[] args)
        {
            Console.Write("Enter a string: ");
            string? inputString = Console.ReadLine();

            Console.Write("Enter the number of times to repeat the string: ");
            string? inputTimes = Console.ReadLine();

            try
            {
                if (string.IsNullOrEmpty(inputString))
                {
                    throw new ArgumentException("The input string cannot be null or empty.");
                }

                if (!int.TryParse(inputTimes, out int times) || times < 0)
                {
                    throw new ArgumentException("Please enter a valid non-negative integer for the number of repetitions.");
                }
                string result = RepeatString(inputString, times);

                
                Console.WriteLine("Result:");
                Console.WriteLine(result);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }}
        public class Recarea{
        public static double CalculateArea(double length, double width)
        {
            // Calculate and return the area
            return length * width;
        }

        public static void Mainarea(string[] args)
        {
            // Get input from the user
            Console.Write("Enter the length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the width of the rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());

            // Call the CalculateArea method
            double area = CalculateArea(length, width);

            // Output the result
            Console.WriteLine($"The area of the rectangle is: {area}");
        }
    }
    }
    
        
