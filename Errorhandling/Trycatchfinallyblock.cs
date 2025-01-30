using System;
using System.IO;

namespace ErrorHandling
{
    class Filereader
    {
        public static void ReadFileData(string[]args)
        {
            string filePath =@"example.md"; 

            try
            {
                // Try to read the file
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine("File content:");
                Console.WriteLine(fileContent);
            }
            catch (FileNotFoundException )
            {
                // Handle  when the file does not exist
                Console.WriteLine($"Error: The file '{filePath}' does not exist. Please check the file path.");
            }
            catch (Exception ex)
            {
                // Handle  exceptions
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Attempt to read the file has finished.");
            }


            } }
            class Divideno {
                
                 
                
                public static void Numbersdiv(string[]args)
                {  
                    try
                    {
                    Console.Write("Enter a numerator: ");
                    double num3 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter denomenator ");
                    double num4 = Convert.ToDouble(Console.ReadLine());

                     double result = Divide(num3, num4);
                Console.WriteLine($"Result: {num3} / {num4} = {result}");
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
}