using System;
namespace operations

{
   public  class NumberRange
    {
        public static void Checknumberrange(string[]args)
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if the number is between 10 and 100, inclusive
            if (number >= 10 && number <= 100)
            {
                Console.WriteLine($"{number} is between 10 and 100 (inclusive).");
            }
            else
            {
                Console.WriteLine($"{number} is not between 10 and 100.");
            }
        }
    }
    public class Checkage{
        public static void Checkvotingage(string[]args){
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18 )
            {
                Console.WriteLine($"You are eligible to vote.");
            }
            else
            {
                Console.WriteLine($"Not of voting age.");
            }

        }

    }
}
