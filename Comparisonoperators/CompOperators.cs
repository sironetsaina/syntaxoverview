using System;
using System.Reflection;
namespace  Comparisonoperators {
    public class Compareoperations{
        public static void Compare(string[]args){
             Console.WriteLine("Enter an integer");
        int number1 = Convert.ToInt16(Console.ReadLine());
  Console.WriteLine("Enter an integer");
        int number2 = Convert.ToInt16(Console.ReadLine());
       Console.WriteLine("\nComparison Results:");
        
        if (number1 == number2)
            Console.WriteLine($"{number1} is equal to {number2}");
        else
            Console.WriteLine($"{number1} is not equal to {number2}");

        if (number1 > number2)
            Console.WriteLine($"{number1} is greater than {number2}");
        else if (number1 < number2)
            Console.WriteLine($"{number1} is less than {number2}");

        if (number1 >= number2)
            Console.WriteLine($"{number1} is greater than or equal to {number2}");
        else
            Console.WriteLine($"{number1} is less than or equal to {number2}");
    
      if (number1 % 2 == 0)
                Console.WriteLine($"{number1} is even");
            else
                Console.WriteLine($"{number1} is odd");

           
            if (number2 % 2 == 0)
                Console.WriteLine($"{number2} is even");
            else
                Console.WriteLine($"{number2} is odd");

        }
        }
    }
