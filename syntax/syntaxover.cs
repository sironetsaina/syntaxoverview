using System;
namespace syntax {
public class Variable
{
    public static void VarRun(string[] args)
    {
        int age = 12;
        double number = 23.88;
        string name = "Viena";
        char Nickname = 'V';
        
        Console.WriteLine("Name: {0}, Age: {1}, Number: {2}, Nickname: {3}", name, age, number, Nickname);
   
    DisplayDayOfWeek();
    }

    enum Daysoftheweek {
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday, 
     }
 
 public static void DisplayDayOfWeek()
    {
        Console.WriteLine("\nEnter a number (1 to 7) to get the day of the week:");

        // Get user input
        string? input = Console.ReadLine();

        // Try to parse input into an integer
        if (int.TryParse(input, out int dayNumber))
        {
            // Use a switch statement to determine the day
            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine(" Tuesday");
                    break;
                case 3:
                    Console.WriteLine(" Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine(" Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }}

}
