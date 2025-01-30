using System;
using System.IO;
namespace ErrorHandling
{
    class NumberValidator
    {
        public static void CheckNo(string[] args)
        {
            bool isValid = false; 

            while (!isValid)
            {
                try
                {
                    Console.Write("Enter a number: ");
                    double no1 = Convert.ToDouble(Console.ReadLine());
                    isValid = true; 
                    Console.WriteLine($"You entered: {no1}");
                }
                catch (FormatException)
                {
                    
                    Console.WriteLine("Error: Please enter a valid number.");
                }
                finally
                {
                    if (isValid)
                    {
                        Console.WriteLine("Thank you for using the number validation system.");
                    }
                }
            }
        }
    }

    class Filechecker
    {
        public static void ReadFile(string[] args)
        {
            //  path to the file in project directory
            string filePath =@"example.md"; 

            try
            {
                // Try to read the file
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine("File content:");
                Console.WriteLine(fileContent);
            }
            catch (FileNotFoundException ex)
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
        }

        static void Mainfile(string[] args)
        {
            ReadFile(args); 
        }
    
}
}