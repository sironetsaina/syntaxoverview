using System;
namespace ControlFlow{
public class Switch
{
    public static void Days(string[] args)
    {
        
        Console.WriteLine("Enter a number (1–7) to represent a day of the week:");

        if (int.TryParse(Console.ReadLine(), out int day))
        {
           switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
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
    }
}
public class Switchmonth
{
    public static void Month(string[] args)
    {
        
        Console.WriteLine("Enter a number (1–12) to represent a day of the week:");

        if (int.TryParse(Console.ReadLine(), out int month))
        {
           switch (month)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                      case 8:
                    Console.WriteLine("August");
                    break;
                      case 9:
                    Console.WriteLine("September");
                    break;
                      case 10:
                    Console.WriteLine("October");
                    break;
                      case 11:
                    Console.WriteLine("November");
                    break;
                      case 12:
                    Console.WriteLine("December");
                    break;

                default:
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 12.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
}